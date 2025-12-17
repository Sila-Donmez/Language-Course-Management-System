namespace WindowsFormsApp6
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentForm));
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cuiChartLine3 = new CuoreUI.Controls.Charts.cuiChartLine();
            this.cuiChartLine2 = new CuoreUI.Controls.Charts.cuiChartLine();
            this.label2 = new System.Windows.Forms.Label();
            this.cuiChartLine1 = new CuoreUI.Controls.Charts.cuiChartLine();
            this.label1 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.surnameLbel = new System.Windows.Forms.Label();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.cuiButton2 = new CuoreUI.Controls.cuiButton();
            this.IdLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cuiPictureBox1
            // 
            this.cuiPictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cuiPictureBox1.BackgroundImage")));
            this.cuiPictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cuiPictureBox1.Content = null;
            this.cuiPictureBox1.ImageTint = System.Drawing.Color.White;
            this.cuiPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.cuiPictureBox1.Name = "cuiPictureBox1";
            this.cuiPictureBox1.OutlineThickness = 1F;
            this.cuiPictureBox1.PanelOutlineColor = System.Drawing.Color.Empty;
            this.cuiPictureBox1.Rotation = 0;
            this.cuiPictureBox1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiPictureBox1.Size = new System.Drawing.Size(150, 150);
            this.cuiPictureBox1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cuiChartLine3);
            this.panel1.Controls.Add(this.cuiChartLine2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cuiChartLine1);
            this.panel1.Location = new System.Drawing.Point(150, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(640, 475);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(430, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 33);
            this.label4.TabIndex = 8;
            this.label4.Text = "Spanish";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(193, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "German";
            // 
            // cuiChartLine3
            // 
            this.cuiChartLine3.AutoMaxValue = false;
            this.cuiChartLine3.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiChartLine3.ChartLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiChartLine3.ChartPadding = 40;
            this.cuiChartLine3.CustomXAxis = new string[] {
        "Exam1",
        "Exam2",
        "Exam3",
        "Exam4"};
            this.cuiChartLine3.DataPoints = new float[] {
        0F,
        0F,
        0F,
        0F};
            this.cuiChartLine3.DayColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiChartLine3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cuiChartLine3.GradientBackground = true;
            this.cuiChartLine3.Location = new System.Drawing.Point(385, 217);
            this.cuiChartLine3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cuiChartLine3.MaxValue = 100F;
            this.cuiChartLine3.Name = "cuiChartLine3";
            this.cuiChartLine3.PointColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiChartLine3.ShortDates = true;
            this.cuiChartLine3.ShowLines = true;
            this.cuiChartLine3.Size = new System.Drawing.Size(250, 250);
            this.cuiChartLine3.TabIndex = 6;
            this.cuiChartLine3.UseBezier = false;
            this.cuiChartLine3.UsePercent = false;
            // 
            // cuiChartLine2
            // 
            this.cuiChartLine2.AutoMaxValue = false;
            this.cuiChartLine2.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiChartLine2.ChartLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiChartLine2.ChartPadding = 40;
            this.cuiChartLine2.CustomXAxis = new string[] {
        "Exam1",
        "Exam2",
        "Exam3",
        "Exam4"};
            this.cuiChartLine2.DataPoints = new float[] {
        0F,
        0F,
        0F,
        0F};
            this.cuiChartLine2.DayColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiChartLine2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cuiChartLine2.GradientBackground = true;
            this.cuiChartLine2.Location = new System.Drawing.Point(161, 0);
            this.cuiChartLine2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cuiChartLine2.MaxValue = 100F;
            this.cuiChartLine2.Name = "cuiChartLine2";
            this.cuiChartLine2.PointColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiChartLine2.ShortDates = true;
            this.cuiChartLine2.ShowLines = true;
            this.cuiChartLine2.Size = new System.Drawing.Size(250, 250);
            this.cuiChartLine2.TabIndex = 5;
            this.cuiChartLine2.UseBezier = false;
            this.cuiChartLine2.UsePercent = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "English";
            // 
            // cuiChartLine1
            // 
            this.cuiChartLine1.AutoMaxValue = false;
            this.cuiChartLine1.AxisColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiChartLine1.ChartLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiChartLine1.ChartPadding = 40;
            this.cuiChartLine1.CustomXAxis = new string[] {
        "Exam1",
        "Exam2",
        "Exam3",
        "Exam4"};
            this.cuiChartLine1.DataPoints = new float[] {
        0F,
        0F,
        0F,
        0F};
            this.cuiChartLine1.DayColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiChartLine1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cuiChartLine1.GradientBackground = true;
            this.cuiChartLine1.Location = new System.Drawing.Point(5, 217);
            this.cuiChartLine1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cuiChartLine1.MaxValue = 100F;
            this.cuiChartLine1.Name = "cuiChartLine1";
            this.cuiChartLine1.PointColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiChartLine1.ShortDates = true;
            this.cuiChartLine1.ShowLines = true;
            this.cuiChartLine1.Size = new System.Drawing.Size(250, 250);
            this.cuiChartLine1.TabIndex = 2;
            this.cuiChartLine1.UseBezier = false;
            this.cuiChartLine1.UsePercent = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.nameLabel.Location = new System.Drawing.Point(12, 199);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 23);
            this.nameLabel.TabIndex = 3;
            // 
            // surnameLbel
            // 
            this.surnameLbel.AutoSize = true;
            this.surnameLbel.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameLbel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.surnameLbel.Location = new System.Drawing.Point(12, 237);
            this.surnameLbel.Name = "surnameLbel";
            this.surnameLbel.Size = new System.Drawing.Size(0, 23);
            this.surnameLbel.TabIndex = 4;
            // 
            // cuiButton1
            // 
            this.cuiButton1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cuiButton1.CheckButton = false;
            this.cuiButton1.Checked = false;
            this.cuiButton1.CheckedBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.cuiButton1.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiButton1.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton1.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiButton1.Content = "Change Password";
            this.cuiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton1.ForeColor = System.Drawing.Color.White;
            this.cuiButton1.HoverBackground = System.Drawing.Color.Azure;
            this.cuiButton1.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiButton1.HoverImageTint = System.Drawing.Color.White;
            this.cuiButton1.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiButton1.Image = null;
            this.cuiButton1.ImageAutoCenter = true;
            this.cuiButton1.ImageExpand = new System.Drawing.Point(4, 4);
            this.cuiButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Location = new System.Drawing.Point(10, 300);
            this.cuiButton1.Name = "cuiButton1";
            this.cuiButton1.NormalBackground = System.Drawing.Color.SteelBlue;
            this.cuiButton1.NormalForeColor = System.Drawing.Color.White;
            this.cuiButton1.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton1.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiButton1.OutlineThickness = 1F;
            this.cuiButton1.PressedBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.cuiButton1.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiButton1.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton1.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.cuiButton1.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton1.Size = new System.Drawing.Size(130, 40);
            this.cuiButton1.TabIndex = 34;
            this.cuiButton1.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton1.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton1.Click += new System.EventHandler(this.cuiButton1_Click);
            // 
            // cuiButton2
            // 
            this.cuiButton2.BackColor = System.Drawing.Color.Azure;
            this.cuiButton2.CheckButton = false;
            this.cuiButton2.Checked = false;
            this.cuiButton2.CheckedBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.cuiButton2.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiButton2.CheckedImageTint = System.Drawing.Color.White;
            this.cuiButton2.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiButton2.Content = "Menu";
            this.cuiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cuiButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.cuiButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.cuiButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiButton2.HoverBackground = System.Drawing.Color.Azure;
            this.cuiButton2.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiButton2.HoverImageTint = System.Drawing.Color.White;
            this.cuiButton2.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiButton2.Image = ((System.Drawing.Image)(resources.GetObject("cuiButton2.Image")));
            this.cuiButton2.ImageAutoCenter = true;
            this.cuiButton2.ImageExpand = new System.Drawing.Point(3, 3);
            this.cuiButton2.ImageOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.Location = new System.Drawing.Point(10, 360);
            this.cuiButton2.Name = "cuiButton2";
            this.cuiButton2.NormalBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.cuiButton2.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiButton2.NormalImageTint = System.Drawing.Color.White;
            this.cuiButton2.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiButton2.OutlineThickness = 1F;
            this.cuiButton2.PressedBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.cuiButton2.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiButton2.PressedImageTint = System.Drawing.Color.White;
            this.cuiButton2.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.cuiButton2.Rounding = new System.Windows.Forms.Padding(8);
            this.cuiButton2.Size = new System.Drawing.Size(130, 40);
            this.cuiButton2.TabIndex = 35;
            this.cuiButton2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton2.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.Click += new System.EventHandler(this.cuiButton2_Click);
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IdLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.IdLabel.Location = new System.Drawing.Point(55, 165);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(0, 23);
            this.IdLabel.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(111, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 33);
            this.label5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(311, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 33);
            this.label6.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(539, 217);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 33);
            this.label7.TabIndex = 11;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.IdLabel);
            this.Controls.Add(this.cuiButton2);
            this.Controls.Add(this.cuiButton1);
            this.Controls.Add(this.surnameLbel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cuiPictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "StudentForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label surnameLbel;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label label2;
        private CuoreUI.Controls.Charts.cuiChartLine cuiChartLine1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private CuoreUI.Controls.Charts.cuiChartLine cuiChartLine3;
        private CuoreUI.Controls.Charts.cuiChartLine cuiChartLine2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}