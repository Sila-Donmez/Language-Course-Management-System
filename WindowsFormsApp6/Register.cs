using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp6
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            DatabaseManager.InitializeDatabase();
        }

        // --------------------------------------
        // HELPERS
        // --------------------------------------
        private int LevelToNumber(string level)
        {
            switch (level)
            {
                case "A1": return 1;
                case "A2": return 2;
                case "B1": return 3;
                case "B2": return 4;
                default: return 0;
            }
        }

        private string Sha256Hash(string raw)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(raw));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private void cuiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // --------------------------------------
        // REGISTER
        // --------------------------------------
        private void cuiButton1_Click(object sender, EventArgs e)
        {
            // 🔴 ZORUNLU ALANLAR
            if (string.IsNullOrWhiteSpace(nameCuiTextBox.Content) ||
                string.IsNullOrWhiteSpace(surnameCuiTextBox.Content) ||
                string.IsNullOrWhiteSpace(passwordCuiTextBox.Content))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (passwordCuiTextBox.Content.Length < 4)
            {
                MessageBox.Show("Password must be at least 4 characters.");
                return;
            }

            // 🔴 EN AZ 1 DERS
            if (!English.Checked && !German.Checked && !Spanish.Checked)
            {
                MessageBox.Show("You must choose at least one course.");
                return;
            }

            // 🔴 SEVİYE KONTROL
            if ((English.Checked && string.IsNullOrEmpty(comboBox1.Text)) ||
                (German.Checked && string.IsNullOrEmpty(comboBox2.Text)) ||
                (Spanish.Checked && string.IsNullOrEmpty(comboBox3.Text)))
            {
                MessageBox.Show("Specify the level for the courses you choose.");
                return;
            }

            int c1 = English.Checked ? LevelToNumber(comboBox1.Text) : 0;
            int c2 = German.Checked ? LevelToNumber(comboBox2.Text) : 0;
            int c3 = Spanish.Checked ? LevelToNumber(comboBox3.Text) : 0;

            string hashedPass = Sha256Hash(passwordCuiTextBox.Content);

            try
            {
                using (var con = new SQLiteConnection(
                    "Data Source=users.db;Version=3;Journal Mode=WAL;"))
                {
                    con.Open();
                    using (var trans = con.BeginTransaction())
                    {
                        long newId;

                        // 1️⃣ USERS
                        string q1 = @"
                        INSERT INTO Users (name, surname, password, role, class1, class2, class3)
                        VALUES (@n, @s, @p, 3, @c1, @c2, @c3);
                        SELECT last_insert_rowid();";

                        using (var cmd = new SQLiteCommand(q1, con, trans))
                        {
                            cmd.Parameters.AddWithValue("@n", nameCuiTextBox.Content.Trim());
                            cmd.Parameters.AddWithValue("@s", surnameCuiTextBox.Content.Trim());
                            cmd.Parameters.AddWithValue("@p", hashedPass);
                            cmd.Parameters.AddWithValue("@c1", c1);
                            cmd.Parameters.AddWithValue("@c2", c2);
                            cmd.Parameters.AddWithValue("@c3", c3);

                            newId = (long)cmd.ExecuteScalar();
                        }

                        trans.Commit();

                        // 2️⃣ EXAMS (BOŞ NOTLAR)
                        DatabaseManager.CreateEmptyExamsForStudent(
                            newId,
                            c1,
                            c2,
                            c3
                        );

                        MessageBox.Show(
                            "Registration successful!\nStudent ID: " + newId,
                            "Successful",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Registration error:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // --------------------------------------
        // CHECKBOX EVENTS
        // --------------------------------------
        private void English_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = English.Checked;
            if (!English.Checked) comboBox1.SelectedIndex = -1;
        }

        private void German_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = German.Checked;
            if (!German.Checked) comboBox2.SelectedIndex = -1;
        }

        private void Spanish_CheckedChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = Spanish.Checked;
            if (!Spanish.Checked) comboBox3.SelectedIndex = -1;
        }
    }
}