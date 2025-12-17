using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form6 : Form
    {
        // ✔ Giriş yapan kişinin ID'si burada tutulacak
        public static string LoggedUserId = "";

        public Form6()
        {
            InitializeComponent();
            InitializeSystem();

            // ✅ Form her gösterildiğinde temizle
            this.Activated += Form6_Activated;
        }

        // ----------------------------------------------------
        // ✔ Form aktif olduğunda alanları temizle
        // ----------------------------------------------------
        private void Form6_Activated(object sender, EventArgs e)
        {
            ClearLoginFields();
        }

        // ----------------------------------------------------
        // ✔ Login Alanlarını Temizle
        // ----------------------------------------------------
        private void ClearLoginFields()
        {
            try
            {
                if (IdTextBox != null)
                    IdTextBox.Content = "";

                if (passwordTextBox != null)
                    passwordTextBox.Content = "";
            }
            catch
            {
                // Kontroller henüz yüklenmemişse hata vermesin
            }
        }

        // ----------------------------------------------------
        // ✔ Sistem Başlatma (Veritabanı + Öğretmen/Admin Ekleme)
        // ----------------------------------------------------
        private void InitializeSystem()
        {
            try
            {
                // Veritabanını oluştur
                DatabaseManager.InitializeDatabase();

                // Admin yoksa öğretmen ve admin ekle
                if (!DatabaseManager.AdminExists())
                {
                    string hashedPassword = Sha256Hash("123456");
                    DatabaseManager.AddTeachersAndAdmin(hashedPassword);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sistem başlatma hatası: " + ex.Message, "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------------------
        // SHA256 HASH
        // ----------------------------------------------------
        private string Sha256Hash(string raw)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(raw));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));

                return builder.ToString();
            }
        }

        // ----------------------------------------------------
        // ✔ LOGIN BUTONU
        // ----------------------------------------------------
        private void button1_Click(object sender, EventArgs e)
        {
            string id = IdTextBox.Content;
            string password = passwordTextBox.Content;

            // Boş kontrol
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("ID and password cannot be empty!", "Warning",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Şifreyi hashle
            string hashedPass = Sha256Hash(password);

            try
            {
                // ✅ DatabaseManager ile giriş kontrolü
                int? role = DatabaseManager.CheckLogin(id, hashedPass);

                if (role == null)
                {
                    MessageBox.Show("Invalid ID or password!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // ✔ Giriş yapan kişinin ID'si kaydediliyor
                LoggedUserId = id;

                // ✅ Rol'e göre form aç (Veritabanı işlemi bittikten SONRA)
                if (role == 1)
                {
                    AdminForm admin = new AdminForm(id,1);
                    admin.FormClosed += (s, args) => this.Show(); // Admin formu kapanınca login'i göster
                    admin.Show();
                    this.Hide();
                }
                else if (role == 2)
                {
                    TeacherForm teacher = new TeacherForm(id,2);
                    teacher.FormClosed += (s, args) => this.Show();
                    teacher.Show();
                    this.Hide();
                }
                else if (role == 3)
                {
                    StudentForm student = new StudentForm(id,3); //?
                    student.FormClosed += (s, args) => this.Show();
                    student.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------------------
        // ✔ KAYIT OL BUTONU
        // ----------------------------------------------------
        private void button2_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.FormClosed += (s, args) => this.Show();
            reg.Show();
            this.Hide();
        }

        // ----------------------------------------------------
        // ✔ Form kapanırken uygulamayı tamamen kapat
        // ----------------------------------------------------
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            // Eğer bu ana form ise ve kapatılıyorsa, uygulamayı kapat
            if (e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}