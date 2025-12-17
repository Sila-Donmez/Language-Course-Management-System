using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Forms;
using System;
using System.Linq;

namespace WindowsFormsApp6
{
    public partial class AdminForm : Form
    {
        private readonly string userId;
        private readonly int userRole;

        public AdminForm(string id, int role)
        {
            InitializeComponent();
            userId = id;
            userRole = role;
            LoadAdminInfo();

            // YENİ: Form yüklendiğinde grafikleri çağır
            this.Load += (s, e) => LoadStudentCountCharts();
        }

        // ----------------------------------------------------------------------
        // YARDIMCI METOTLAR
        // ----------------------------------------------------------------------

        // Seviye numarasını (1, 2, 3, 4) metin karşılığına (A1, A2, B1, B2) çevirir
        private string LevelNumberToText(int level)
        {
            switch (level)
            {
                case 1: return "A1";
                case 2: return "A2";
                case 3: return "B1";
                case 4: return "B2";
                default: return "Unknown";
            }
        }

        // ----------------------------------------------------------------------
        // GRAFİK YÜKLEME VE OLUŞTURMA
        // ----------------------------------------------------------------------

        private void LoadStudentCountCharts()
        {
            // 1. Grafiği sıfırla ve temel ayarları yap
            InitializeAdminBarChart();

            // 2. Her ders için veriyi çek ve grafiğe ekle (Renkleri burada belirliyoruz)
            AddCourseDataToChart(1, "English", adminChart, Color.Azure);
            AddCourseDataToChart(2, "German", adminChart, Color.CornflowerBlue);
            AddCourseDataToChart(3, "Spanish", adminChart, Color.Navy);
        }

        private void InitializeAdminBarChart()
        {
            // Grafiği tamamen temizle
            adminChart.Series.Clear();
            adminChart.ChartAreas.Clear();

            // 1. CHART'IN KENDİ ARKA PLANI (Dış Alan)
            adminChart.BackColor = Color.SteelBlue; // Ana arka plan rengi
            adminChart.BorderlineColor = Color.Navy; // Grafiğin dış kenar rengi (isteğe bağlı)
            adminChart.ForeColor = Color.White; // Başlık ve Legend metin rengi

            // 2. CHART AREA OLUŞTURMA (Grafiğin çizim alanı)
            ChartArea chartArea = new ChartArea();

            // Çizim alanının iç arka plan rengi (Beyaza yakın, çok açık mavi)
            chartArea.BackColor = Color.SteelBlue;
            chartArea.BackSecondaryColor = Color.White;

            // Grid çizgilerini açık gri yap (varsa)
            chartArea.AxisX.MajorGrid.LineColor = Color.Navy;
            chartArea.AxisY.MajorGrid.LineColor = Color.Navy;

            // Eksen yazılarını (A1, A2, Öğrenci Sayısı vb.) daha koyu yapalım
            chartArea.AxisX.Title = "Level(A1 - B2)";
            chartArea.AxisX.TitleForeColor = Color.Black;
            chartArea.AxisX.LabelStyle.ForeColor = Color.Black;

            chartArea.AxisY.Minimum = 0;
            chartArea.AxisY.Title = "Number of Student";
            chartArea.AxisY.TitleForeColor = Color.Black;
            chartArea.AxisY.LabelStyle.ForeColor = Color.Black;

            adminChart.ChartAreas.Add(chartArea);

            // Başlık ve Başlık Rengi
            /* adminChart.Titles.Clear();
             var title = adminChart.Titles.Add("Sınıf Seviyelerine Göre Öğrenci Dağılımı");
             title.ForeColor = Color.White; // Başlık rengini SteelBlue arka plana uydur*/
        }

        // KRİTİK DÜZELTME: Renk parametresi eklendi ve AddXY metin etiketini kullanıyor.
        private void AddCourseDataToChart(int classNo, string courseName, Chart chart, Color color)
        {
            // Veriyi DatabaseManager'dan çek
            var counts = DatabaseManager.GetStudentCountByLevel(classNo);

            // Yeni SERIES oluştur: İsim (Legend'da gözükecek)
            Series series = new Series(courseName);

            // Grafik tipini Sütun (Dikey Bar) olarak ayarla
            series.ChartType = SeriesChartType.Column;
            series.IsVisibleInLegend = true;
            series.Color = color;
            series.BorderWidth = 1;

            // Verileri Series'e ekle (A1=1, A2=2, B1=3, B2=4)
            for (int level = 1; level <= 4; level++)
            {
                int count = counts.ContainsKey(level) ? counts[level] : 0;

                string levelText = LevelNumberToText(level);

                // AddXY: X ekseni etiketi (Metin), Y ekseni değeri (Sayı)
                series.Points.AddXY(levelText, count);

                // Veri etiketini sütun üzerine yaz (Öğrenci Sayısı)
                series.Points.Last().Label = count.ToString();
                series.Points.Last().Font = new Font("Arial", 8f, FontStyle.Bold);
            }

            chart.Series.Add(series);
        }

        // ----------------------------------------------------------------------
        // ADMIN KONTROL VE BUTON METOTLARI
        // ----------------------------------------------------------------------

        private void LoadAdminInfo()
        {
            try
            {
                // DatabaseManager.GetUserInfo'nin (string, string) tuple döndürdüğü varsayılır.
                var (name, surname) = DatabaseManager.GetUserInfo(userId);
                if (!string.IsNullOrEmpty(name))
                {
                    // label2, label3, label4 formunuzdaki ilgili etiketler olmalı
                    label2.Text = userId;
                    label3.Text = name;
                    label4.Text = surname;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load error: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cuiButton2_Click(object sender, EventArgs e) // LOGOUT
        {
            this.Close();
        }

        private void cuiButton1_Click(object sender, EventArgs e) // CHANGE PASSWORD
        {
            Passwords cp = new Passwords(userId, userRole, this);
            cp.Show();
            this.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e) // RASGELE NOT ATAMA
        {
            // DatabaseManager.GenerateRandomScoresForExistingStudents() çağrıldığı varsayılır
            DatabaseManager.GenerateRandomScoresForExistingStudents();
            MessageBox.Show("Mevcut öğrencilere notlar başarıyla atandı!");
        }


        private void deleteUserButton_Click_1(object sender, EventArgs e)
        {
            // deleteIdTextBox'ın CuoreUI'dan cuiTextBox olduğu varsayılır
            // NOT: Bu satır, formunuzdaki cuiTextBox.Content özelliğini kullanır.
            string idToDelete = deleteIdTextBox.Content.Trim();

            if (string.IsNullOrEmpty(idToDelete))
            {
                MessageBox.Show("Please enter the student's ID.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(
                $"Are you sure you want to permanently delete the student with ID {idToDelete}? This action cannot be undone.",
                "Deletion Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    // Silme işlemini DatabaseManager'a gönder
                    int rowsAffected = DatabaseManager.DeleteUser(idToDelete);

                    if (rowsAffected > 0)
                    {
                        // Silme Başarılı Mesajı (İngilizce)
                        MessageBox.Show($"Student (ID: {idToDelete}) and all related exam scores were successfully deleted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Grafik verilerini güncelle (Çünkü öğrenci sayısı değişti)
                        LoadStudentCountCharts();
                    }
                    else
                    {
                        // Silme Başarısız Mesajı (İngilizce)
                        MessageBox.Show($"No student found with ID {idToDelete} or deletion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    // Olası bir runtime hatasını yakalamak için (DatabaseManager'da da try-catch var, bu sadece ek koruma)
                    MessageBox.Show($"An unexpected error occurred during deletion: {ex.Message}", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            // deleteIdTextBox.Content = ""; // Temizleme isteğe bağlıdır, kontrol sizin.

        }

        /*private void button1_Click_1(object sender, EventArgs e)
        {
            DatabaseManager.FixTeacherClasses();
            MessageBox.Show("Teacher classes updated successfully.");
        }*/
    }
}