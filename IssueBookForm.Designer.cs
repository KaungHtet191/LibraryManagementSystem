namespace LibraryManagementSystem
{
    partial class IssueBookForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBookForm));
            StdDepTb = new TextBox();
            label5 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            StdPhoneTb = new TextBox();
            label6 = new Label();
            StdNameTb = new TextBox();
            issueNumTb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            StdCb = new ComboBox();
            label7 = new Label();
            bookCb = new ComboBox();
            label8 = new Label();
            issueDate = new DateTimePicker();
            IssueBookDGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)IssueBookDGV).BeginInit();
            SuspendLayout();
            // 
            // StdDepTb
            // 
            StdDepTb.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StdDepTb.Location = new Point(266, 393);
            StdDepTb.Name = "StdDepTb";
            StdDepTb.Size = new Size(215, 31);
            StdDepTb.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(19, 393);
            label5.Name = "label5";
            label5.Size = new Size(183, 36);
            label5.TabIndex = 46;
            label5.Text = "Department";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuHighlight;
            button4.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(183, 721);
            button4.Name = "button4";
            button4.Size = new Size(139, 47);
            button4.TabIndex = 44;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(344, 656);
            button3.Name = "button3";
            button3.Size = new Size(139, 47);
            button3.TabIndex = 43;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(183, 656);
            button2.Name = "button2";
            button2.Size = new Size(139, 47);
            button2.TabIndex = 42;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(19, 656);
            button1.Name = "button1";
            button1.Size = new Size(139, 47);
            button1.TabIndex = 41;
            button1.Text = "ISSUE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // StdPhoneTb
            // 
            StdPhoneTb.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StdPhoneTb.Location = new Point(266, 459);
            StdPhoneTb.Name = "StdPhoneTb";
            StdPhoneTb.Size = new Size(215, 31);
            StdPhoneTb.TabIndex = 40;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(19, 459);
            label6.Name = "label6";
            label6.Size = new Size(102, 36);
            label6.TabIndex = 39;
            label6.Text = "Phone";
            // 
            // StdNameTb
            // 
            StdNameTb.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StdNameTb.Location = new Point(266, 322);
            StdNameTb.Name = "StdNameTb";
            StdNameTb.Size = new Size(215, 31);
            StdNameTb.TabIndex = 38;
            StdNameTb.TextChanged += textBox3_TextChanged;
            // 
            // issueNumTb
            // 
            issueNumTb.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            issueNumTb.Location = new Point(266, 187);
            issueNumTb.Name = "issueNumTb";
            issueNumTb.Size = new Size(215, 31);
            issueNumTb.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(19, 322);
            label4.Name = "label4";
            label4.Size = new Size(94, 36);
            label4.TabIndex = 35;
            label4.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(19, 257);
            label3.Name = "label3";
            label3.Size = new Size(110, 36);
            label3.TabIndex = 34;
            label3.Text = "UserID";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(19, 187);
            label2.Name = "label2";
            label2.Size = new Size(128, 36);
            label2.TabIndex = 33;
            label2.Text = "Number";
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1241, 125);
            panel1.TabIndex = 48;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1168, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 62);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(255, 40);
            label1.Name = "label1";
            label1.Size = new Size(798, 49);
            label1.TabIndex = 0;
            label1.Text = "Issue Books Management System ";
            // 
            // StdCb
            // 
            StdCb.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            StdCb.FormattingEnabled = true;
            StdCb.Items.AddRange(new object[] { "Grade-1", "Grade-2", "Grade-3", "Grade-4", "Grade-5", "Grade-6", "Grade-7", "Grade-8", "Grade-9", "Grade-10", "Grade-11", "Grade-12" });
            StdCb.Location = new Point(266, 257);
            StdCb.Name = "StdCb";
            StdCb.Size = new Size(215, 31);
            StdCb.TabIndex = 49;
            StdCb.SelectedIndexChanged += StdCb_SelectedIndexChanged;
            StdCb.SelectionChangeCommitted += StdCb_SelectionChangeCommitted;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(19, 528);
            label7.Name = "label7";
            label7.Size = new Size(87, 36);
            label7.TabIndex = 50;
            label7.Text = "Book";
            label7.Click += label7_Click;
            // 
            // bookCb
            // 
            bookCb.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookCb.FormattingEnabled = true;
            bookCb.Location = new Point(266, 528);
            bookCb.Name = "bookCb";
            bookCb.Size = new Size(215, 31);
            bookCb.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(19, 592);
            label8.Name = "label8";
            label8.Size = new Size(79, 36);
            label8.TabIndex = 52;
            label8.Text = "Date";
            // 
            // issueDate
            // 
            issueDate.CalendarMonthBackground = SystemColors.MenuHighlight;
            issueDate.CalendarTitleBackColor = SystemColors.Highlight;
            issueDate.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            issueDate.Location = new Point(266, 592);
            issueDate.Name = "issueDate";
            issueDate.Size = new Size(215, 25);
            issueDate.TabIndex = 53;
            // 
            // IssueBookDGV
            // 
            IssueBookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IssueBookDGV.Location = new Point(507, 161);
            IssueBookDGV.Name = "IssueBookDGV";
            IssueBookDGV.RowHeadersWidth = 51;
            IssueBookDGV.RowTemplate.Height = 29;
            IssueBookDGV.Size = new Size(722, 634);
            IssueBookDGV.TabIndex = 54;
            IssueBookDGV.CellClick += IssueBookDGV_CellClick;
            // 
            // IssueBookForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 853);
            Controls.Add(IssueBookDGV);
            Controls.Add(issueDate);
            Controls.Add(label8);
            Controls.Add(bookCb);
            Controls.Add(label7);
            Controls.Add(StdCb);
            Controls.Add(panel1);
            Controls.Add(StdDepTb);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(StdPhoneTb);
            Controls.Add(label6);
            Controls.Add(StdNameTb);
            Controls.Add(issueNumTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IssueBookForm";
            Text = "IssueBookForm";
            Load += IssueBookForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)IssueBookDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox StdDepTb;
        private Label label5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox StdPhoneTb;
        private Label label6;
        private TextBox StdNameTb;
        private TextBox issueNumTb;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox StdCb;
        private Label label7;
        private ComboBox bookCb;
        private Label label8;
        private DateTimePicker issueDate;
        private DataGridView IssueBookDGV;
    }
}