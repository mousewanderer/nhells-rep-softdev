namespace whatACT9
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LABELUSERNAME = new Label();
            Minimize = new Button();
            exit = new Button();
            textBoxUsername = new TextBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            textBoxPassword = new TextBox();
            buttonLogin = new Button();
            buttonExit = new Button();
            FORGOTpass = new LinkLabel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // LABELUSERNAME
            // 
            LABELUSERNAME.AutoSize = true;
            LABELUSERNAME.BackColor = Color.DarkGray;
            LABELUSERNAME.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LABELUSERNAME.Location = new Point(466, 144);
            LABELUSERNAME.Name = "LABELUSERNAME";
            LABELUSERNAME.Size = new Size(329, 46);
            LABELUSERNAME.TabIndex = 0;
            LABELUSERNAME.Text = "ENTER USERNAME:";
            // 
            // Minimize
            // 
            Minimize.BackColor = Color.Cyan;
            Minimize.BackgroundImage = (Image)resources.GetObject("Minimize.BackgroundImage");
            Minimize.BackgroundImageLayout = ImageLayout.Zoom;
            Minimize.FlatStyle = FlatStyle.Flat;
            Minimize.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Minimize.Location = new Point(1018, 12);
            Minimize.Name = "Minimize";
            Minimize.Size = new Size(45, 45);
            Minimize.TabIndex = 1;
            Minimize.UseVisualStyleBackColor = false;
            Minimize.Click += Minimize_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.Cyan;
            exit.BackgroundImage = (Image)resources.GetObject("exit.BackgroundImage");
            exit.BackgroundImageLayout = ImageLayout.Zoom;
            exit.FlatStyle = FlatStyle.Flat;
            exit.Location = new Point(1085, 12);
            exit.Name = "exit";
            exit.Size = new Size(45, 45);
            exit.TabIndex = 2;
            exit.UseVisualStyleBackColor = false;
            exit.Click += exit_Click;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(463, 205);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(332, 27);
            textBoxUsername.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Silver;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(466, 246);
            label1.Name = "label1";
            label1.Size = new Size(322, 46);
            label1.TabIndex = 4;
            label1.Text = "ENTER PASSWORD";
            label1.Click += label1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Cyan;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(320, 111);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(611, 340);
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(463, 308);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(332, 27);
            textBoxPassword.TabIndex = 8;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.White;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Location = new Point(511, 359);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(94, 29);
            buttonLogin.TabIndex = 9;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.White;
            buttonExit.FlatStyle = FlatStyle.Flat;
            buttonExit.Location = new Point(660, 359);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 10;
            buttonExit.Text = "EXIT";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // FORGOTpass
            // 
            FORGOTpass.ActiveLinkColor = Color.Maroon;
            FORGOTpass.AutoSize = true;
            FORGOTpass.BackColor = Color.FromArgb(128, 128, 255);
            FORGOTpass.Location = new Point(568, 401);
            FORGOTpass.Name = "FORGOTpass";
            FORGOTpass.Size = new Size(125, 20);
            FORGOTpass.TabIndex = 11;
            FORGOTpass.TabStop = true;
            FORGOTpass.Text = "Forgot Password?";
            FORGOTpass.LinkClicked += FORGOTpass_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(Minimize);
            panel1.Controls.Add(exit);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1151, 63);
            panel1.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(163, 8, 11);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1151, 534);
            Controls.Add(panel1);
            Controls.Add(FORGOTpass);
            Controls.Add(buttonExit);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxPassword);
            Controls.Add(label1);
            Controls.Add(textBoxUsername);
            Controls.Add(LABELUSERNAME);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LABELUSERNAME;
        private Button Minimize;
        private Button exit;
        private TextBox textBoxUsername;
        private Label label1;
        private PictureBox pictureBox2;
        private TextBox textBoxPassword;
        private Button buttonLogin;
        private Button buttonExit;
        private LinkLabel FORGOTpass;
        private Panel panel1;
    }
}
