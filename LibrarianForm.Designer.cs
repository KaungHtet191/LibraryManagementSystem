namespace LibraryManagementSystem
{
    partial class LibrarianForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LibrarianForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            LibPhone = new TextBox();
            label5 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            LibPassword = new TextBox();
            LibName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            LibID = new TextBox();
            label7 = new Label();
            LibrarianDGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LibrarianDGV).BeginInit();
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
            panel1.Size = new Size(1242, 125);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
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
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Algerian", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(255, 40);
            label1.Name = "label1";
            label1.Size = new Size(785, 49);
            label1.TabIndex = 0;
            label1.Text = "Librarians Management System ";
            // 
            // LibPhone
            // 
            LibPhone.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LibPhone.Location = new Point(354, 441);
            LibPhone.Name = "LibPhone";
            LibPhone.Size = new Size(215, 31);
            LibPhone.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(107, 441);
            label5.Name = "label5";
            label5.Size = new Size(102, 36);
            label5.TabIndex = 46;
            label5.Text = "Phone";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuHighlight;
            button4.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(269, 685);
            button4.Name = "button4";
            button4.Size = new Size(139, 47);
            button4.TabIndex = 45;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(430, 620);
            button3.Name = "button3";
            button3.Size = new Size(139, 47);
            button3.TabIndex = 44;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(269, 620);
            button2.Name = "button2";
            button2.Size = new Size(139, 47);
            button2.TabIndex = 43;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(107, 620);
            button1.Name = "button1";
            button1.Size = new Size(139, 47);
            button1.TabIndex = 42;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // LibPassword
            // 
            LibPassword.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LibPassword.Location = new Point(354, 370);
            LibPassword.Name = "LibPassword";
            LibPassword.Size = new Size(215, 31);
            LibPassword.TabIndex = 39;
            // 
            // LibName
            // 
            LibName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LibName.Location = new Point(354, 305);
            LibName.Name = "LibName";
            LibName.Size = new Size(215, 31);
            LibName.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(107, 370);
            label4.Name = "label4";
            label4.Size = new Size(148, 36);
            label4.TabIndex = 36;
            label4.Text = "Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(107, 305);
            label3.Name = "label3";
            label3.Size = new Size(94, 36);
            label3.TabIndex = 35;
            label3.Text = "Name";
            // 
            // LibID
            // 
            LibID.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LibID.Location = new Point(354, 235);
            LibID.Name = "LibID";
            LibID.Size = new Size(215, 31);
            LibID.TabIndex = 37;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(107, 235);
            label7.Name = "label7";
            label7.Size = new Size(46, 36);
            label7.TabIndex = 34;
            label7.Text = "ID";
            // 
            // LibrarianDGV
            // 
            LibrarianDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            LibrarianDGV.Location = new Point(602, 199);
            LibrarianDGV.Name = "LibrarianDGV";
            LibrarianDGV.RowHeadersWidth = 51;
            LibrarianDGV.RowTemplate.Height = 29;
            LibrarianDGV.Size = new Size(553, 584);
            LibrarianDGV.TabIndex = 48;
            LibrarianDGV.CellClick += LibrarianDGV_CellClick;
            LibrarianDGV.CellContentClick += LibrarianDGV_CellContentClick;
            // 
            // LibrarianForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1242, 828);
            Controls.Add(LibrarianDGV);
            Controls.Add(LibPhone);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(LibPassword);
            Controls.Add(LibName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LibID);
            Controls.Add(label7);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LibrarianForm";
            Text = "LibrarianForm";
            Load += LibrarianForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)LibrarianDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox LibPhone;
        private Label label5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox LibPassword;
        private TextBox LibName;
        private Label label4;
        private Label label3;
        private TextBox LibID;
        private Label label7;
        private DataGridView LibrarianDGV;
    }
}