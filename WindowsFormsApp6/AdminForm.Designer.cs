namespace WindowsFormsApp6
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.deleteIdTextBox = new CuoreUI.Controls.cuiTextBox();
            this.deleteUserButton = new CuoreUI.Controls.cuiButton();
            this.adminChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.cuiButton2 = new CuoreUI.Controls.cuiButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminChart)).BeginInit();
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
            this.cuiPictureBox1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.adminChart);
            this.panel1.Location = new System.Drawing.Point(150, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(657, 483);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.deleteIdTextBox);
            this.panel2.Controls.Add(this.deleteUserButton);
            this.panel2.Location = new System.Drawing.Point(0, 329);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 135);
            this.panel2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label5.Location = new System.Drawing.Point(48, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 36);
            this.label5.TabIndex = 4;
            this.label5.Text = "Delete User:";
            // 
            // deleteIdTextBox
            // 
            this.deleteIdTextBox.BackgroundColor = System.Drawing.Color.White;
            this.deleteIdTextBox.Content = "";
            this.deleteIdTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.deleteIdTextBox.FocusBackgroundColor = System.Drawing.Color.White;
            this.deleteIdTextBox.FocusImageTint = System.Drawing.Color.White;
            this.deleteIdTextBox.FocusOutlineColor = System.Drawing.Color.SteelBlue;
            this.deleteIdTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteIdTextBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.deleteIdTextBox.Image = null;
            this.deleteIdTextBox.ImageExpand = new System.Drawing.Point(0, 0);
            this.deleteIdTextBox.ImageOffset = new System.Drawing.Point(0, 0);
            this.deleteIdTextBox.Location = new System.Drawing.Point(253, 31);
            this.deleteIdTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.deleteIdTextBox.Multiline = false;
            this.deleteIdTextBox.Name = "deleteIdTextBox";
            this.deleteIdTextBox.NormalImageTint = System.Drawing.Color.White;
            this.deleteIdTextBox.OutlineColor = System.Drawing.Color.SteelBlue;
            this.deleteIdTextBox.Padding = new System.Windows.Forms.Padding(16, 27, 16, 0);
            this.deleteIdTextBox.PasswordChar = false;
            this.deleteIdTextBox.PlaceholderColor = System.Drawing.Color.SteelBlue;
            this.deleteIdTextBox.PlaceholderText = "ID to be deleted";
            this.deleteIdTextBox.Rounding = new System.Windows.Forms.Padding(8);
            this.deleteIdTextBox.Size = new System.Drawing.Size(147, 70);
            this.deleteIdTextBox.TabIndex = 1;
            this.deleteIdTextBox.TextOffset = new System.Drawing.Size(0, 0);
            this.deleteIdTextBox.UnderlinedStyle = true;
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.CheckButton = false;
            this.deleteUserButton.Checked = false;
            this.deleteUserButton.CheckedBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteUserButton.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deleteUserButton.CheckedImageTint = System.Drawing.Color.White;
            this.deleteUserButton.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deleteUserButton.Content = "Delete";
            this.deleteUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteUserButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deleteUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.deleteUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deleteUserButton.HoverBackground = System.Drawing.SystemColors.GradientInactiveCaption;
            this.deleteUserButton.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deleteUserButton.HoverImageTint = System.Drawing.Color.White;
            this.deleteUserButton.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deleteUserButton.Image = null;
            this.deleteUserButton.ImageAutoCenter = true;
            this.deleteUserButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.deleteUserButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.deleteUserButton.Location = new System.Drawing.Point(427, 31);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.NormalBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteUserButton.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deleteUserButton.NormalImageTint = System.Drawing.Color.White;
            this.deleteUserButton.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deleteUserButton.OutlineThickness = 1F;
            this.deleteUserButton.PressedBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.deleteUserButton.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deleteUserButton.PressedImageTint = System.Drawing.Color.White;
            this.deleteUserButton.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.deleteUserButton.Rounding = new System.Windows.Forms.Padding(8);
            this.deleteUserButton.Size = new System.Drawing.Size(147, 70);
            this.deleteUserButton.TabIndex = 3;
            this.deleteUserButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.deleteUserButton.TextOffset = new System.Drawing.Point(0, 0);
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click_1);
            // 
            // adminChart
            // 
            this.adminChart.BackColor = System.Drawing.Color.SteelBlue;
            this.adminChart.BorderlineColor = System.Drawing.Color.SteelBlue;
            chartArea3.BackColor = System.Drawing.Color.SteelBlue;
            chartArea3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            chartArea3.Name = "ChartArea1";
            this.adminChart.ChartAreas.Add(chartArea3);
            legend3.BackColor = System.Drawing.Color.SteelBlue;
            legend3.Name = "Legend1";
            this.adminChart.Legends.Add(legend3);
            this.adminChart.Location = new System.Drawing.Point(74, 23);
            this.adminChart.Name = "adminChart";
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.SystemColors.GradientInactiveCaption;
            series7.Legend = "Legend1";
            series7.Name = "English";
            series8.ChartArea = "ChartArea1";
            series8.Color = System.Drawing.Color.CornflowerBlue;
            series8.Legend = "Legend1";
            series8.Name = "German";
            series9.ChartArea = "ChartArea1";
            series9.Color = System.Drawing.Color.Navy;
            series9.Legend = "Legend1";
            series9.Name = "Spanish";
            this.adminChart.Series.Add(series7);
            this.adminChart.Series.Add(series8);
            this.adminChart.Series.Add(series9);
            this.adminChart.Size = new System.Drawing.Size(463, 300);
            this.adminChart.TabIndex = 0;
            this.adminChart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(55, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 5;
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
            this.cuiButton1.TabIndex = 35;
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
            this.cuiButton2.TabIndex = 36;
            this.cuiButton2.TextAlignment = System.Drawing.StringAlignment.Center;
            this.cuiButton2.TextOffset = new System.Drawing.Point(0, 0);
            this.cuiButton2.Click += new System.EventHandler(this.cuiButton2_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.cuiButton2);
            this.Controls.Add(this.cuiButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cuiPictureBox1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Name = "AdminForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CuoreUI.Controls.cuiPictureBox cuiPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private CuoreUI.Controls.cuiButton cuiButton1;
        private CuoreUI.Controls.cuiButton cuiButton2;
        private System.Windows.Forms.DataVisualization.Charting.Chart adminChart;
        public CuoreUI.Controls.cuiTextBox deleteIdTextBox;
        private CuoreUI.Controls.cuiButton deleteUserButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}