namespace WindowsFormsApp6
{
    partial class TeacherForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherForm));
            this.cuiPictureBox1 = new CuoreUI.Controls.cuiPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.updateButton = new CuoreUI.Controls.cuiButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cuiButton1 = new CuoreUI.Controls.cuiButton();
            this.cuiButton2 = new CuoreUI.Controls.cuiButton();
            this.idTextBox = new CuoreUI.Controls.cuiTextBox();
            this.exam1TextBox = new CuoreUI.Controls.cuiTextBox();
            this.exam2TextBox = new CuoreUI.Controls.cuiTextBox();
            this.exam3TextBox = new CuoreUI.Controls.cuiTextBox();
            this.exam4TextBox = new CuoreUI.Controls.cuiTextBox();
            this.label5 = new System.Windows.Forms.Label();
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
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.exam4TextBox);
            this.panel1.Controls.Add(this.exam3TextBox);
            this.panel1.Controls.Add(this.exam2TextBox);
            this.panel1.Controls.Add(this.exam1TextBox);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Location = new System.Drawing.Point(150, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 500);
            this.panel1.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(567, 283);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // updateButton
            // 
            this.updateButton.CheckButton = false;
            this.updateButton.Checked = false;
            this.updateButton.CheckedBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.updateButton.CheckedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateButton.CheckedImageTint = System.Drawing.Color.White;
            this.updateButton.CheckedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateButton.Content = "Update";
            this.updateButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateButton.HoverBackground = System.Drawing.SystemColors.GradientInactiveCaption;
            this.updateButton.HoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateButton.HoverImageTint = System.Drawing.Color.White;
            this.updateButton.HoverOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateButton.Image = null;
            this.updateButton.ImageAutoCenter = true;
            this.updateButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.updateButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.updateButton.Location = new System.Drawing.Point(495, 409);
            this.updateButton.Name = "updateButton";
            this.updateButton.NormalBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.updateButton.NormalForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateButton.NormalImageTint = System.Drawing.Color.White;
            this.updateButton.NormalOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateButton.OutlineThickness = 1F;
            this.updateButton.PressedBackground = System.Drawing.SystemColors.GradientActiveCaption;
            this.updateButton.PressedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateButton.PressedImageTint = System.Drawing.Color.White;
            this.updateButton.PressedOutline = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.updateButton.Rounding = new System.Windows.Forms.Padding(8);
            this.updateButton.Size = new System.Drawing.Size(120, 40);
            this.updateButton.TabIndex = 4;
            this.updateButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.updateButton.TextOffset = new System.Drawing.Point(0, 0);
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(55, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 23);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 23);
            this.label3.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 23);
            this.label4.TabIndex = 6;
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
            // idTextBox
            // 
            this.idTextBox.BackgroundColor = System.Drawing.Color.White;
            this.idTextBox.Content = "";
            this.idTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idTextBox.FocusBackgroundColor = System.Drawing.Color.White;
            this.idTextBox.FocusImageTint = System.Drawing.Color.White;
            this.idTextBox.FocusOutlineColor = System.Drawing.Color.SteelBlue;
            this.idTextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idTextBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.idTextBox.Image = null;
            this.idTextBox.ImageExpand = new System.Drawing.Point(0, 0);
            this.idTextBox.ImageOffset = new System.Drawing.Point(0, 0);
            this.idTextBox.Location = new System.Drawing.Point(15, 350);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBox.Multiline = false;
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.NormalImageTint = System.Drawing.Color.White;
            this.idTextBox.OutlineColor = System.Drawing.Color.SteelBlue;
            this.idTextBox.Padding = new System.Windows.Forms.Padding(16, 12, 16, 0);
            this.idTextBox.PasswordChar = false;
            this.idTextBox.PlaceholderColor = System.Drawing.Color.SteelBlue;
            this.idTextBox.PlaceholderText = "ID";
            this.idTextBox.Rounding = new System.Windows.Forms.Padding(8);
            this.idTextBox.Size = new System.Drawing.Size(100, 40);
            this.idTextBox.TabIndex = 23;
            this.idTextBox.TextOffset = new System.Drawing.Size(0, 0);
            this.idTextBox.UnderlinedStyle = true;
            // 
            // exam1TextBox
            // 
            this.exam1TextBox.BackgroundColor = System.Drawing.Color.White;
            this.exam1TextBox.Content = "";
            this.exam1TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exam1TextBox.FocusBackgroundColor = System.Drawing.Color.White;
            this.exam1TextBox.FocusImageTint = System.Drawing.Color.White;
            this.exam1TextBox.FocusOutlineColor = System.Drawing.Color.SteelBlue;
            this.exam1TextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exam1TextBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.exam1TextBox.Image = null;
            this.exam1TextBox.ImageExpand = new System.Drawing.Point(0, 0);
            this.exam1TextBox.ImageOffset = new System.Drawing.Point(0, 0);
            this.exam1TextBox.Location = new System.Drawing.Point(137, 350);
            this.exam1TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.exam1TextBox.Multiline = false;
            this.exam1TextBox.Name = "exam1TextBox";
            this.exam1TextBox.NormalImageTint = System.Drawing.Color.White;
            this.exam1TextBox.OutlineColor = System.Drawing.Color.SteelBlue;
            this.exam1TextBox.Padding = new System.Windows.Forms.Padding(16, 12, 16, 0);
            this.exam1TextBox.PasswordChar = false;
            this.exam1TextBox.PlaceholderColor = System.Drawing.Color.SteelBlue;
            this.exam1TextBox.PlaceholderText = "Exam1";
            this.exam1TextBox.Rounding = new System.Windows.Forms.Padding(8);
            this.exam1TextBox.Size = new System.Drawing.Size(100, 40);
            this.exam1TextBox.TabIndex = 24;
            this.exam1TextBox.TextOffset = new System.Drawing.Size(0, 0);
            this.exam1TextBox.UnderlinedStyle = true;
            // 
            // exam2TextBox
            // 
            this.exam2TextBox.BackgroundColor = System.Drawing.Color.White;
            this.exam2TextBox.Content = "";
            this.exam2TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exam2TextBox.FocusBackgroundColor = System.Drawing.Color.White;
            this.exam2TextBox.FocusImageTint = System.Drawing.Color.White;
            this.exam2TextBox.FocusOutlineColor = System.Drawing.Color.SteelBlue;
            this.exam2TextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exam2TextBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.exam2TextBox.Image = null;
            this.exam2TextBox.ImageExpand = new System.Drawing.Point(0, 0);
            this.exam2TextBox.ImageOffset = new System.Drawing.Point(0, 0);
            this.exam2TextBox.Location = new System.Drawing.Point(261, 350);
            this.exam2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.exam2TextBox.Multiline = false;
            this.exam2TextBox.Name = "exam2TextBox";
            this.exam2TextBox.NormalImageTint = System.Drawing.Color.White;
            this.exam2TextBox.OutlineColor = System.Drawing.Color.SteelBlue;
            this.exam2TextBox.Padding = new System.Windows.Forms.Padding(16, 12, 16, 0);
            this.exam2TextBox.PasswordChar = false;
            this.exam2TextBox.PlaceholderColor = System.Drawing.Color.SteelBlue;
            this.exam2TextBox.PlaceholderText = "Exam2";
            this.exam2TextBox.Rounding = new System.Windows.Forms.Padding(8);
            this.exam2TextBox.Size = new System.Drawing.Size(100, 40);
            this.exam2TextBox.TabIndex = 25;
            this.exam2TextBox.TextOffset = new System.Drawing.Size(0, 0);
            this.exam2TextBox.UnderlinedStyle = true;
            // 
            // exam3TextBox
            // 
            this.exam3TextBox.BackgroundColor = System.Drawing.Color.White;
            this.exam3TextBox.Content = "";
            this.exam3TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exam3TextBox.FocusBackgroundColor = System.Drawing.Color.White;
            this.exam3TextBox.FocusImageTint = System.Drawing.Color.White;
            this.exam3TextBox.FocusOutlineColor = System.Drawing.Color.SteelBlue;
            this.exam3TextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exam3TextBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.exam3TextBox.Image = null;
            this.exam3TextBox.ImageExpand = new System.Drawing.Point(0, 0);
            this.exam3TextBox.ImageOffset = new System.Drawing.Point(0, 0);
            this.exam3TextBox.Location = new System.Drawing.Point(388, 350);
            this.exam3TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.exam3TextBox.Multiline = false;
            this.exam3TextBox.Name = "exam3TextBox";
            this.exam3TextBox.NormalImageTint = System.Drawing.Color.White;
            this.exam3TextBox.OutlineColor = System.Drawing.Color.SteelBlue;
            this.exam3TextBox.Padding = new System.Windows.Forms.Padding(16, 12, 16, 0);
            this.exam3TextBox.PasswordChar = false;
            this.exam3TextBox.PlaceholderColor = System.Drawing.Color.SteelBlue;
            this.exam3TextBox.PlaceholderText = "Exam3";
            this.exam3TextBox.Rounding = new System.Windows.Forms.Padding(8);
            this.exam3TextBox.Size = new System.Drawing.Size(100, 40);
            this.exam3TextBox.TabIndex = 26;
            this.exam3TextBox.TextOffset = new System.Drawing.Size(0, 0);
            this.exam3TextBox.UnderlinedStyle = true;
            // 
            // exam4TextBox
            // 
            this.exam4TextBox.BackgroundColor = System.Drawing.Color.White;
            this.exam4TextBox.Content = "";
            this.exam4TextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exam4TextBox.FocusBackgroundColor = System.Drawing.Color.White;
            this.exam4TextBox.FocusImageTint = System.Drawing.Color.White;
            this.exam4TextBox.FocusOutlineColor = System.Drawing.Color.SteelBlue;
            this.exam4TextBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exam4TextBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.exam4TextBox.Image = null;
            this.exam4TextBox.ImageExpand = new System.Drawing.Point(0, 0);
            this.exam4TextBox.ImageOffset = new System.Drawing.Point(0, 0);
            this.exam4TextBox.Location = new System.Drawing.Point(515, 350);
            this.exam4TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.exam4TextBox.Multiline = false;
            this.exam4TextBox.Name = "exam4TextBox";
            this.exam4TextBox.NormalImageTint = System.Drawing.Color.White;
            this.exam4TextBox.OutlineColor = System.Drawing.Color.SteelBlue;
            this.exam4TextBox.Padding = new System.Windows.Forms.Padding(16, 12, 16, 0);
            this.exam4TextBox.PasswordChar = false;
            this.exam4TextBox.PlaceholderColor = System.Drawing.Color.SteelBlue;
            this.exam4TextBox.PlaceholderText = "Exam4";
            this.exam4TextBox.Rounding = new System.Windows.Forms.Padding(8);
            this.exam4TextBox.Size = new System.Drawing.Size(100, 40);
            this.exam4TextBox.TabIndex = 27;
            this.exam4TextBox.TextOffset = new System.Drawing.Size(0, 0);
            this.exam4TextBox.UnderlinedStyle = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(38, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 28;
            // 
            // TeacherForm
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
            this.Name = "TeacherForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Teacher Panel";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private CuoreUI.Controls.cuiButton updateButton;
        private System.Windows.Forms.ListView listView1;
        public CuoreUI.Controls.cuiTextBox exam4TextBox;
        public CuoreUI.Controls.cuiTextBox exam3TextBox;
        public CuoreUI.Controls.cuiTextBox exam2TextBox;
        public CuoreUI.Controls.cuiTextBox exam1TextBox;
        public CuoreUI.Controls.cuiTextBox idTextBox;
        private System.Windows.Forms.Label label5;
    }
}