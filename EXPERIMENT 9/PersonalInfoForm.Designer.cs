namespace whatACT9
{
    partial class PersonalInfoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalInfoForm));
            labelFullName = new Label();
            labelAge = new Label();
            labelGender = new Label();
            comboBoxGender = new ComboBox();
            textBoxFullName = new TextBox();
            textBoxAge = new TextBox();
            buttonSave = new Button();
            buttonLogout = new Button();
            pictureBox1 = new PictureBox();
            ffs = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.BackColor = Color.FromArgb(32, 32, 32);
            labelFullName.Font = new Font("Segoe UI", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFullName.ForeColor = Color.White;
            labelFullName.Location = new Point(235, 127);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(125, 45);
            labelFullName.TabIndex = 0;
            labelFullName.Text = "NAME:";
            // 
            // labelAge
            // 
            labelAge.AutoSize = true;
            labelAge.BackColor = Color.FromArgb(32, 32, 32);
            labelAge.Font = new Font("Segoe UI", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelAge.ForeColor = Color.White;
            labelAge.Location = new Point(235, 210);
            labelAge.Name = "labelAge";
            labelAge.Size = new Size(92, 45);
            labelAge.TabIndex = 1;
            labelAge.Text = "AGE:";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.BackColor = Color.FromArgb(32, 32, 32);
            labelGender.Font = new Font("Segoe UI", 19.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGender.ForeColor = Color.White;
            labelGender.Location = new Point(235, 293);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(156, 45);
            labelGender.TabIndex = 2;
            labelGender.Text = "GENDER:";
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Location = new Point(235, 346);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(156, 28);
            comboBoxGender.TabIndex = 3;
            // 
            // textBoxFullName
            // 
            textBoxFullName.Location = new Point(235, 180);
            textBoxFullName.Name = "textBoxFullName";
            textBoxFullName.Size = new Size(156, 27);
            textBoxFullName.TabIndex = 4;
            // 
            // textBoxAge
            // 
            textBoxAge.Location = new Point(235, 263);
            textBoxAge.Name = "textBoxAge";
            textBoxAge.Size = new Size(156, 27);
            textBoxAge.TabIndex = 5;
            textBoxAge.TextChanged += textBoxAge_TextChanged;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Gray;
            buttonSave.FlatStyle = FlatStyle.Flat;
            buttonSave.Location = new Point(738, 191);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "SAVE";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Gray;
            buttonLogout.FlatStyle = FlatStyle.Flat;
            buttonLogout.Location = new Point(738, 245);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(94, 29);
            buttonLogout.TabIndex = 7;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(209, 117);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(683, 314);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // ffs
            // 
            ffs.AutoSize = true;
            ffs.BackColor = Color.White;
            ffs.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ffs.Location = new Point(98, 25);
            ffs.Name = "ffs";
            ffs.Size = new Size(134, 60);
            ffs.TabIndex = 9;
            ffs.Text = "USER";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Gray;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Location = new Point(12, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(80, 75);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // PersonalInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(992, 551);
            Controls.Add(pictureBox2);
            Controls.Add(ffs);
            Controls.Add(buttonLogout);
            Controls.Add(buttonSave);
            Controls.Add(textBoxAge);
            Controls.Add(textBoxFullName);
            Controls.Add(comboBoxGender);
            Controls.Add(labelGender);
            Controls.Add(labelAge);
            Controls.Add(labelFullName);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonalInfoForm";
            Text = "PersonalInfoForm";
            Load += PersonalInfoForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelFullName;
        private Label labelAge;
        private Label labelGender;
        private ComboBox comboBoxGender;
        private TextBox textBoxFullName;
        private TextBox textBoxAge;
        private Button buttonSave;
        private Button buttonLogout;
        private PictureBox pictureBox1;
        private Label ffs;
        private PictureBox pictureBox2;
    }
}