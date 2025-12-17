using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class TeacherForm : Form
    {
        private readonly string userId;
        private readonly int userRole;
        private int teacherClassNo;
        private int teacherLevel;

        public TeacherForm(string id, int role)
        {
            InitializeComponent();
            userId = id;
            userRole = role;
            this.Load += TeacherForm_Load;
            listView1.SelectedIndexChanged += ListView1_SelectedIndexChanged;
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            LoadTeacherInfo();
            LoadTeacherClass();
            SetupListView();
            LoadStudents();
        }

        private void LoadTeacherInfo()
        {
            var (name, surname) = DatabaseManager.GetUserInfo(userId);
            label2.Text = userId;
            label3.Text = name;
            label4.Text = surname;
        }

        private void LoadTeacherClass()
        {
            using (var con = new SQLiteConnection("Data Source=users.db;Version=3;"))
            {
                con.Open();
                var cmd = new SQLiteCommand(
                    "SELECT class1, class2, class3 FROM Users WHERE id=@id AND role=2", con);
                cmd.Parameters.AddWithValue("@id", userId);

                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        if (Convert.ToInt32(dr["class1"]) != 0) { teacherClassNo = 1; teacherLevel = Convert.ToInt32(dr["class1"]); }
                        else if (Convert.ToInt32(dr["class2"]) != 0) { teacherClassNo = 2; teacherLevel = Convert.ToInt32(dr["class2"]); }
                        else if (Convert.ToInt32(dr["class3"]) != 0) { teacherClassNo = 3; teacherLevel = Convert.ToInt32(dr["class3"]); }
                    }
                }
            }

            string language = teacherClassNo == 1 ? "English" :
                              teacherClassNo == 2 ? "German" :
                              teacherClassNo == 3 ? "Spanish" : "Unknown";

            string levelText = teacherLevel == 1 ? "A1" :
                               teacherLevel == 2 ? "A2" :
                               teacherLevel == 3 ? "B1" :
                               teacherLevel == 4 ? "B2" : "";

            label5.Text = $"{language} {levelText}";
        }

        private void SetupListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Scrollable = true;

            listView1.Columns.Clear();
            listView1.Columns.Add("ID", 50);
            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Surname", 100);
            listView1.Columns.Add("Exam 1", 70);
            listView1.Columns.Add("Exam 2", 70);
            listView1.Columns.Add("Exam 3", 70);
            listView1.Columns.Add("Exam 4", 70);
        }

        private void LoadStudents()
        {
            listView1.Items.Clear();
            DataTable dt = DatabaseManager.GetStudentsForTeacher(userId);

            foreach (DataRow dr in dt.Rows)
            {
                var item = new ListViewItem(dr["id"].ToString());
                item.SubItems.Add(dr["name"].ToString());
                item.SubItems.Add(dr["surname"].ToString());
                item.SubItems.Add(dr["exam1"].ToString());
                item.SubItems.Add(dr["exam2"].ToString());
                item.SubItems.Add(dr["exam3"].ToString());
                item.SubItems.Add(dr["exam4"].ToString());
                listView1.Items.Add(item);
            }
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;

            var selected = listView1.SelectedItems[0];

            // Write student ID to textbox or label
            idTextBox.Content = selected.SubItems[0].Text;

            exam1TextBox.Content = selected.SubItems[3].Text;
            exam2TextBox.Content = selected.SubItems[4].Text;
            exam3TextBox.Content = selected.SubItems[5].Text;
            exam4TextBox.Content = selected.SubItems[6].Text;
        }

        private void cuiButton2_Click(object sender, EventArgs e) => this.Close();

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            Passwords cp = new Passwords(userId, userRole, this);
            cp.Show();
            this.Enabled = false;
        }

        private void updateButton_Click_1(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a student first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selected = listView1.SelectedItems[0];

            if (!long.TryParse(selected.SubItems[0].Text, out long studentId))
                return;

            if (teacherClassNo == 0)
            {
                MessageBox.Show("Teacher class information not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int successfulUpdates = 0;

            // --- Exam 1 ---
            if (int.TryParse(exam1TextBox.Content, out int score1))
            {
                DatabaseManager.UpsertStudentScore(studentId, teacherClassNo, 1, score1);
                successfulUpdates++;
            }

            // --- Exam 2 ---
            if (int.TryParse(exam2TextBox.Content, out int score2))
            {
                DatabaseManager.UpsertStudentScore(studentId, teacherClassNo, 2, score2);
                successfulUpdates++;
            }

            // --- Exam 3 ---
            if (int.TryParse(exam3TextBox.Content, out int score3))
            {
                DatabaseManager.UpsertStudentScore(studentId, teacherClassNo, 3, score3);
                successfulUpdates++;
            }

            // --- Exam 4 ---
            if (int.TryParse(exam4TextBox.Content, out int score4))
            {
                DatabaseManager.UpsertStudentScore(studentId, teacherClassNo, 4, score4);
                successfulUpdates++;
            }

            if (successfulUpdates == 0)
            {
                MessageBox.Show("No exam scores were updated. Please ensure all score fields contain numbers (no spaces or letters).",
                                "Warning: Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Reload the ListView after updating database
            LoadStudents();

            // Re-select the same student
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.SubItems[0].Text == studentId.ToString())
                {
                    item.Selected = true;
                    item.Focused = true;
                    item.EnsureVisible();
                    break;
                }
            }

            MessageBox.Show($"Successfully updated {successfulUpdates} score(s)!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}