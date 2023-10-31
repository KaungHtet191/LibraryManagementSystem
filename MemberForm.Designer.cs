namespace LibraryManagementSystem
{
    partial class MemberForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            StdID = new TextBox();
            StdName = new TextBox();
            StdDep = new TextBox();
            label6 = new Label();
            StdPhone = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            StudentDGV = new DataGridView();
            StdEdu = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StudentDGV).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1235, 125);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1161, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 62);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(286, 38);
            label1.Name = "label1";
            label1.Size = new Size(730, 49);
            label1.TabIndex = 0;
            label1.Text = "Members Management System ";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 209);
            label2.Name = "label2";
            label2.Size = new Size(162, 36);
            label2.TabIndex = 1;
            label2.Text = "MemberID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 279);
            label3.Name = "label3";
            label3.Size = new Size(94, 36);
            label3.TabIndex = 2;
            label3.Text = "Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(39, 344);
            label4.Name = "label4";
            label4.Size = new Size(183, 36);
            label4.TabIndex = 3;
            label4.Text = "Department";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(39, 414);
            label5.Name = "label5";
            label5.Size = new Size(144, 36);
            label5.TabIndex = 4;
            label5.Text = "Semester";
            // 
            // StdID
            // 
            StdID.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StdID.Location = new Point(286, 209);
            StdID.Name = "StdID";
            StdID.Size = new Size(205, 31);
            StdID.TabIndex = 7;
            // 
            // StdName
            // 
            StdName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StdName.Location = new Point(286, 279);
            StdName.Name = "StdName";
            StdName.Size = new Size(205, 31);
            StdName.TabIndex = 8;
            // 
            // StdDep
            // 
            StdDep.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StdDep.Location = new Point(286, 344);
            StdDep.Name = "StdDep";
            StdDep.Size = new Size(205, 31);
            StdDep.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(39, 481);
            label6.Name = "label6";
            label6.Size = new Size(153, 36);
            label6.TabIndex = 10;
            label6.Text = "Phone No.";
            // 
            // StdPhone
            // 
            StdPhone.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StdPhone.Location = new Point(286, 481);
            StdPhone.Name = "StdPhone";
            StdPhone.Size = new Size(205, 31);
            StdPhone.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(39, 594);
            button1.Name = "button1";
            button1.Size = new Size(129, 47);
            button1.TabIndex = 12;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(201, 594);
            button2.Name = "button2";
            button2.Size = new Size(129, 47);
            button2.TabIndex = 13;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(362, 594);
            button3.Name = "button3";
            button3.Size = new Size(129, 47);
            button3.TabIndex = 14;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuHighlight;
            button4.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(201, 659);
            button4.Name = "button4";
            button4.Size = new Size(129, 47);
            button4.TabIndex = 16;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // StudentDGV
            // 
            StudentDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            StudentDGV.Location = new Point(537, 157);
            StudentDGV.Name = "StudentDGV";
            StudentDGV.RowHeadersWidth = 51;
            StudentDGV.RowTemplate.Height = 29;
            StudentDGV.Size = new Size(662, 584);
            StudentDGV.TabIndex = 49;
            StudentDGV.CellClick += StudentDGV_CellClick;
            StudentDGV.CellContentClick += StudentDGV_CellContentClick;
            // 
            // StdEdu
            // 
            StdEdu.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            StdEdu.FormattingEnabled = true;
            StdEdu.Items.AddRange(new object[] { "Semester-1", "Semester-2", "Semester-3", "Semester-4", "Semester-5", "Semester-6" });
            StdEdu.Location = new Point(286, 414);
            StdEdu.Name = "StdEdu";
            StdEdu.Size = new Size(205, 28);
            StdEdu.TabIndex = 50;
            // 
            // MemberForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1235, 828);
            Controls.Add(StdEdu);
            Controls.Add(StudentDGV);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(StdPhone);
            Controls.Add(label6);
            Controls.Add(StdDep);
            Controls.Add(StdName);
            Controls.Add(StdID);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MemberForm";
            Text = "MemberForm";
            Load += MemberForm_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)StudentDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox StdID;
        private TextBox StdName;
        private TextBox StdDep;
        private Label label6;
        private TextBox StdPhone;
        private Button button1;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
        private Button button4;
        private DataGridView StudentDGV;
        private ComboBox StdEdu;
    }
}