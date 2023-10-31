namespace LibraryManagementSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            panel2 = new Panel();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightSkyBlue;
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1287, 119);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(180, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 62);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1213, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(74, 62);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.LightSkyBlue;
            button5.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(1078, 68);
            button5.Name = "button5";
            button5.Size = new Size(209, 51);
            button5.TabIndex = 5;
            button5.Text = "Librarians";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.LightSkyBlue;
            button4.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(848, 68);
            button4.Name = "button4";
            button4.Size = new Size(209, 51);
            button4.TabIndex = 4;
            button4.Text = "Return Books";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(639, 68);
            button3.Name = "button3";
            button3.Size = new Size(191, 51);
            button3.TabIndex = 3;
            button3.Text = "Issue Books";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(480, 68);
            button2.Name = "button2";
            button2.Size = new Size(138, 51);
            button2.TabIndex = 2;
            button2.Text = "Books";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(314, 68);
            button1.Name = "button1";
            button1.Size = new Size(145, 51);
            button1.TabIndex = 1;
            button1.Text = "Members";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Cambria", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(52, 72);
            label1.Name = "label1";
            label1.Size = new Size(134, 40);
            label1.TabIndex = 0;
            label1.Text = "Library";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSkyBlue;
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 561);
            panel2.Name = "panel2";
            panel2.Size = new Size(1287, 119);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // button8
            // 
            button8.BackColor = Color.LightSkyBlue;
            button8.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button8.Location = new Point(855, 0);
            button8.Name = "button8";
            button8.Size = new Size(429, 119);
            button8.TabIndex = 7;
            button8.Text = "Tips";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.LightSkyBlue;
            button7.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(426, 0);
            button7.Name = "button7";
            button7.Size = new Size(429, 119);
            button7.TabIndex = 6;
            button7.Text = "DashBoard";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.LightSkyBlue;
            button6.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(0, 0);
            button6.Name = "button6";
            button6.Size = new Size(429, 119);
            button6.TabIndex = 5;
            button6.Text = "About Us";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(1287, 442);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 680);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Button button1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button5;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button button8;
        private Button button7;
        private Button button6;
    }
}