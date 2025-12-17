using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApp6
{
    public partial class Passwords : Form
    {
        private readonly string userId;
        private readonly int userRole;
        private readonly Form parentForm;

        public Passwords(string id, int role, Form parent)
        {
            InitializeComponent();
            userId = id;
            userRole = role;
            parentForm = parent;

            IdTextBox.Content = id;
            IdTextBox.Enabled = false;
        }

        private string Sha256Hash(string raw)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(raw));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e) // SAVE
        {
            string oldPass = passwordTextBox.Content;
            string newPass = newPasswordTextBox.Content;
            string confirmPass = confirmNewPasswordTextBox.Content;

            if (string.IsNullOrWhiteSpace(oldPass) ||
                string.IsNullOrWhiteSpace(newPass) ||
                string.IsNullOrWhiteSpace(confirmPass))
            {
                MessageBox.Show("Fill all fields.");
                return;
            }

            if (newPass != confirmPass)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            string hashedOld = Sha256Hash(oldPass);
            var check = DatabaseManager.CheckLogin(userId, hashedOld);

            if (check == null)
            {
                MessageBox.Show("Incorrect old password.");
                return;
            }

            string hashedNew = Sha256Hash(newPass);

            try
            {
                using (var con = new SQLiteConnection("Data Source=users.db;Version=3;"))
                {
                    con.Open();
                    using (var cmd = new SQLiteCommand("UPDATE Users SET password=@p WHERE id=@id", con))
                    {
                        cmd.Parameters.AddWithValue("@p", hashedNew);
                        cmd.Parameters.AddWithValue("@id", userId);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Password updated!");
                parentForm.Enabled = true;
                parentForm.BringToFront();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating password: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e) // BACK
        {
            parentForm.Enabled = true;
            parentForm.BringToFront();
            this.Close();
        }
    }
}
