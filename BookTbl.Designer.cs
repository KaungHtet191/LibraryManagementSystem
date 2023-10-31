namespace LibraryManagementSystem
{
    partial class BookTbl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookTbl));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            bookQty = new TextBox();
            label6 = new Label();
            bookPublisher = new TextBox();
            bookAuthor = new TextBox();
            bookName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label5 = new Label();
            bookPrice = new TextBox();
            BookDGV = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).BeginInit();
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
            panel1.TabIndex = 1;
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
            label1.Location = new Point(286, 38);
            label1.Name = "label1";
            label1.Size = new Size(666, 49);
            label1.TabIndex = 0;
            label1.Text = "Books Management System ";
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuHighlight;
            button4.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(201, 668);
            button4.Name = "button4";
            button4.Size = new Size(139, 47);
            button4.TabIndex = 29;
            button4.Text = "Home";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Red;
            button3.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(362, 603);
            button3.Name = "button3";
            button3.Size = new Size(139, 47);
            button3.TabIndex = 28;
            button3.Text = "DELETE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Lime;
            button2.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(201, 603);
            button2.Name = "button2";
            button2.Size = new Size(139, 47);
            button2.TabIndex = 27;
            button2.Text = "EDIT";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(39, 603);
            button1.Name = "button1";
            button1.Size = new Size(139, 47);
            button1.TabIndex = 26;
            button1.Text = "ADD";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // bookQty
            // 
            bookQty.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookQty.Location = new Point(286, 490);
            bookQty.Name = "bookQty";
            bookQty.Size = new Size(215, 31);
            bookQty.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(39, 490);
            label6.Name = "label6";
            label6.Size = new Size(135, 36);
            label6.TabIndex = 24;
            label6.Text = "Quantity";
            // 
            // bookPublisher
            // 
            bookPublisher.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookPublisher.Location = new Point(286, 353);
            bookPublisher.Name = "bookPublisher";
            bookPublisher.Size = new Size(215, 31);
            bookPublisher.TabIndex = 23;
            // 
            // bookAuthor
            // 
            bookAuthor.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookAuthor.Location = new Point(286, 288);
            bookAuthor.Name = "bookAuthor";
            bookAuthor.Size = new Size(215, 31);
            bookAuthor.TabIndex = 22;
            // 
            // bookName
            // 
            bookName.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookName.Location = new Point(286, 218);
            bookName.Name = "bookName";
            bookName.Size = new Size(215, 31);
            bookName.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(39, 353);
            label4.Name = "label4";
            label4.Size = new Size(149, 36);
            label4.TabIndex = 19;
            label4.Text = "Publisher";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(39, 288);
            label3.Name = "label3";
            label3.Size = new Size(112, 36);
            label3.TabIndex = 18;
            label3.Text = "Author";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(39, 218);
            label2.Name = "label2";
            label2.Size = new Size(173, 36);
            label2.TabIndex = 17;
            label2.Text = "Book Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(39, 424);
            label5.Name = "label5";
            label5.Size = new Size(86, 36);
            label5.TabIndex = 31;
            label5.Text = "Price";
            // 
            // bookPrice
            // 
            bookPrice.Font = new Font("Cambria", 12F, FontStyle.Bold, GraphicsUnit.Point);
            bookPrice.Location = new Point(286, 424);
            bookPrice.Name = "bookPrice";
            bookPrice.Size = new Size(215, 31);
            bookPrice.TabIndex = 32;
            // 
            // BookDGV
            // 
            BookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BookDGV.Location = new Point(561, 171);
            BookDGV.Name = "BookDGV";
            BookDGV.RowHeadersWidth = 51;
            BookDGV.RowTemplate.Height = 29;
            BookDGV.Size = new Size(669, 584);
            BookDGV.TabIndex = 49;
            BookDGV.CellClick += BookDGV_CellClick;
            // 
            // BookTbl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1242, 828);
            Controls.Add(BookDGV);
            Controls.Add(bookPrice);
            Controls.Add(label5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(bookQty);
            Controls.Add(label6);
            Controls.Add(bookPublisher);
            Controls.Add(bookAuthor);
            Controls.Add(bookName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "BookTbl";
            Text = "BookTbl";
            Load += BookTbl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BookDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox bookQty;
        private Label label6;
        private TextBox bookPublisher;
        private TextBox bookAuthor;
        private TextBox bookName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label5;
        private TextBox bookPrice;
        private DataGridView BookDGV;
    }
}