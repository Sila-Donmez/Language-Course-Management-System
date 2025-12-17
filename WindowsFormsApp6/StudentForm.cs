using System;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using CuoreUI.Controls.Charts;

namespace WindowsFormsApp6
{
    public partial class StudentForm : Form
    {
        private readonly string userId;
        private readonly int userRole;

        public StudentForm(string id, int role)
        {
            InitializeComponent();
            userId = id;
            userRole = role;

            this.Load += StudentForm_Load;
            this.Activated += StudentForm_Activated;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadStudentInfo();
            LoadStudentCharts();
        }

        private void StudentForm_Activated(object sender, EventArgs e)
        {
            LoadStudentCharts();
        }

        // -------------------------------------------------
        // STUDENT INFO
        // -------------------------------------------------
        private void LoadStudentInfo()
        {
            var (name, surname) = DatabaseManager.GetUserInfo(userId);

            IdLabel.Text = userId;
            nameLabel.Text = name;
            surnameLbel.Text = surname;
        }

        // -------------------------------------------------
        // LOAD ALL CHARTS
        // -------------------------------------------------
        private void LoadStudentCharts()
        {
            try
            {
                using (var con = new SQLiteConnection(
                    "Data Source=users.db;Version=3;Journal Mode=WAL;"))
                {
                    con.Open();

                    LoadSingleChart(con, 1, cuiChartLine1, label5);
                    LoadSingleChart(con, 2, cuiChartLine2, label6);
                    LoadSingleChart(con, 3, cuiChartLine3, label7);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Graphics loading error:\n" + ex.Message);
            }
        }

        // -------------------------------------------------
        // LOAD SINGLE CHART
        // -------------------------------------------------
        private void LoadSingleChart(
            SQLiteConnection con,
            int classNo,
            cuiChartLine chart,
            Label titleLabel)
        {
            string language =
                classNo == 1 ? "English" :
                classNo == 2 ? "German" :
                "Spanish";

            // ----------------------------
            // LEVEL CHECK
            // ----------------------------
            int level = 0;
            using (var cmd = new SQLiteCommand(
                $"SELECT class{classNo} FROM Users WHERE id=@id", con))
            {
                cmd.Parameters.AddWithValue("@id", userId);
                object result = cmd.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                    level = Convert.ToInt32(result);
            }

            string levelText =
                level == 1 ? "A1" :
                level == 2 ? "A2" :
                level == 3 ? "B1" :
                level == 4 ? "B2" :
                "None";

            // ----------------------------
            // TITLE LABEL (label5/6/7)
            // ----------------------------
            titleLabel.Text = $"- {levelText}";
            titleLabel.Visible = true;

            // ----------------------------
            // SCORES (DEFAULT 0)
            // ----------------------------
            float[] points = new float[4] { 0, 0, 0, 0 };

            string scoreQuery = @"
                SELECT examNo, score
                FROM Exams
                WHERE studentId=@sid AND classNo=@class";

            using (var cmd = new SQLiteCommand(scoreQuery, con))
            {
                cmd.Parameters.AddWithValue("@sid", userId);
                cmd.Parameters.AddWithValue("@class", classNo);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int exam = Convert.ToInt32(dr["examNo"]);
                        int score = Convert.ToInt32(dr["score"]);
                        if (exam >= 1 && exam <= 4)
                            points[exam - 1] = score;
                    }
                }
            }

            // ----------------------------
            // CHART REFRESH
            // ----------------------------
            chart.Visible = true;
            chart.DataPoints = null;
            chart.DataPoints = points;
            chart.Invalidate();
            chart.Refresh();
        }

        // -------------------------------------------------
        // BUTTONS
        // -------------------------------------------------
        private void cuiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cuiButton1_Click(object sender, EventArgs e)
        {
            Passwords cp = new Passwords(userId, userRole, this);
            cp.Show();
            this.Enabled = false;
        }
    }
}