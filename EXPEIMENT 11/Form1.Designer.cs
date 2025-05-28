namespace EXP11
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
            txtStudentID = new TextBox();
            txtAge = new TextBox();
            btnUpdate = new Button();
            label1 = new Label();
            label2 = new Label();
            btnDelete = new Button();
            dataGridViewStudents = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panelmain = new Panel();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            pictureBox4 = new PictureBox();
            label6 = new Label();
            CourseBox = new ComboBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            panelmain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // txtStudentID
            // 
            txtStudentID.BackColor = Color.FromArgb(255, 192, 128);
            txtStudentID.BorderStyle = BorderStyle.None;
            txtStudentID.Font = new Font("Tahoma", 13.8F);
            txtStudentID.ForeColor = Color.Yellow;
            txtStudentID.Location = new Point(16, 109);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(292, 28);
            txtStudentID.TabIndex = 0;
            txtStudentID.TextChanged += txtStudentID_TextChanged;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.FromArgb(255, 192, 128);
            txtAge.BorderStyle = BorderStyle.None;
            txtAge.Font = new Font("Tahoma", 13.8F);
            txtAge.ForeColor = Color.Yellow;
            txtAge.Location = new Point(16, 259);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(77, 28);
            txtAge.TabIndex = 1;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Red;
            btnUpdate.BackgroundImage = (Image)resources.GetObject("btnUpdate.BackgroundImage");
            btnUpdate.BackgroundImageLayout = ImageLayout.Zoom;
            btnUpdate.Font = new Font("Tahoma", 9F);
            btnUpdate.Location = new Point(200, 357);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(50, 45);
            btnUpdate.TabIndex = 2;
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("TechnicBold", 16.2F);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(16, 76);
            label1.Name = "label1";
            label1.Size = new Size(168, 30);
            label1.TabIndex = 3;
            label1.Text = "STUDENT ID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TechnicBold", 16.2F);
            label2.ForeColor = Color.Yellow;
            label2.Location = new Point(16, 226);
            label2.Name = "label2";
            label2.Size = new Size(66, 30);
            label2.TabIndex = 4;
            label2.Text = "AGE";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.BackgroundImage = (Image)resources.GetObject("btnDelete.BackgroundImage");
            btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
            btnDelete.Font = new Font("Tahoma", 9F);
            btnDelete.Location = new Point(72, 357);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(50, 45);
            btnDelete.TabIndex = 5;
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.BackgroundColor = Color.Red;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.GridColor = Color.FromArgb(59, 95, 138);
            dataGridViewStudents.Location = new Point(382, 32);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.RowHeadersWidth = 51;
            dataGridViewStudents.Size = new Size(598, 448);
            dataGridViewStudents.TabIndex = 6;
            dataGridViewStudents.CellContentClick += dataGridViewStudents_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("TechnicBold", 16.2F);
            label3.ForeColor = Color.Yellow;
            label3.Location = new Point(16, 151);
            label3.Name = "label3";
            label3.Size = new Size(115, 30);
            label3.TabIndex = 8;
            label3.Text = "COURSE";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("TechnicBold", 11.999999F);
            label4.ForeColor = Color.Yellow;
            label4.Location = new Point(188, 329);
            label4.Name = "label4";
            label4.Size = new Size(73, 22);
            label4.TabIndex = 10;
            label4.Text = "Update";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("TechnicBold", 11.999999F);
            label5.ForeColor = Color.Yellow;
            label5.Location = new Point(60, 329);
            label5.Name = "label5";
            label5.Size = new Size(71, 22);
            label5.TabIndex = 11;
            label5.Text = "Delete";
            // 
            // panelmain
            // 
            panelmain.BackColor = Color.FromArgb(192, 0, 0);
            panelmain.Controls.Add(pictureBox6);
            panelmain.Controls.Add(pictureBox5);
            panelmain.Controls.Add(label7);
            panelmain.Controls.Add(pictureBox4);
            panelmain.Controls.Add(label3);
            panelmain.Controls.Add(label5);
            panelmain.Controls.Add(label6);
            panelmain.Controls.Add(label4);
            panelmain.Controls.Add(CourseBox);
            panelmain.Controls.Add(label1);
            panelmain.Controls.Add(txtStudentID);
            panelmain.Controls.Add(btnDelete);
            panelmain.Controls.Add(btnUpdate);
            panelmain.Controls.Add(txtAge);
            panelmain.Controls.Add(label2);
            panelmain.Dock = DockStyle.Left;
            panelmain.Font = new Font("TechnicBold", 11.999999F);
            panelmain.ForeColor = Color.FromArgb(209, 227, 240);
            panelmain.Location = new Point(0, 0);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(330, 502);
            panelmain.TabIndex = 12;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.Red;
            pictureBox6.Location = new Point(0, 433);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(337, 69);
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.Red;
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(10, 502);
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Red;
            label7.Font = new Font("TechnicBold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 2);
            label7.ForeColor = Color.Yellow;
            label7.Location = new Point(60, 32);
            label7.Name = "label7";
            label7.Size = new Size(217, 30);
            label7.TabIndex = 16;
            label7.Text = "EXPERIMENT 11";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Red;
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(335, 73);
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 460);
            label6.Name = "label6";
            label6.Size = new Size(327, 20);
            label6.TabIndex = 13;
            label6.Text = "_____________________________________________________";
            // 
            // CourseBox
            // 
            CourseBox.BackColor = Color.FromArgb(255, 192, 128);
            CourseBox.ForeColor = Color.Yellow;
            CourseBox.FormattingEnabled = true;
            CourseBox.Location = new Point(16, 184);
            CourseBox.Name = "CourseBox";
            CourseBox.Size = new Size(201, 30);
            CourseBox.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Red;
            pictureBox3.Location = new Point(327, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(10, 502);
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1017, 502);
            Controls.Add(pictureBox3);
            Controls.Add(dataGridViewStudents);
            Controls.Add(panelmain);
            ForeColor = Color.FromArgb(59, 95, 138);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "EXPERIMENT 11";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            panelmain.ResumeLayout(false);
            panelmain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtStudentID;
        private TextBox txtAge;
        private Button btnUpdate;
        private Label label1;
        private Label label2;
        private Button btnDelete;
        private DataGridView dataGridViewStudents;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panelmain;
        private ComboBox CourseBox;
        private Label label6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label7;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}
