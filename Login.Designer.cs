namespace WinFormsApp1
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            UnameTb = new TextBox();
            UPassTb = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.MediumBlue;
            button1.Location = new Point(274, 506);
            button1.Name = "button1";
            button1.Size = new Size(152, 55);
            button1.TabIndex = 0;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(274, 274);
            label1.Name = "label1";
            label1.Size = new Size(173, 36);
            label1.TabIndex = 1;
            label1.Text = "UserName :";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.MediumBlue;
            label2.Location = new Point(274, 394);
            label2.Name = "label2";
            label2.Size = new Size(163, 36);
            label2.TabIndex = 2;
            label2.Text = "Password :";
            label2.Click += label2_Click;
            // 
            // UnameTb
            // 
            UnameTb.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            UnameTb.ForeColor = Color.MediumBlue;
            UnameTb.Location = new Point(465, 271);
            UnameTb.Name = "UnameTb";
            UnameTb.Size = new Size(299, 39);
            UnameTb.TabIndex = 3;
            UnameTb.TextChanged += textBox1_TextChanged;
            // 
            // UPassTb
            // 
            UPassTb.Font = new Font("Cambria", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            UPassTb.ForeColor = Color.MediumBlue;
            UPassTb.Location = new Point(465, 394);
            UPassTb.Name = "UPassTb";
            UPassTb.Size = new Size(299, 39);
            UPassTb.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.DimGray;
            label3.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.MediumBlue;
            label3.Location = new Point(465, 197);
            label3.Name = "label3";
            label3.Size = new Size(163, 36);
            label3.TabIndex = 5;
            label3.Text = "User Login";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.DeepSkyBlue;
            label4.Location = new Point(84, 39);
            label4.Name = "label4";
            label4.Size = new Size(492, 34);
            label4.TabIndex = 6;
            label4.Text = "Library Management System";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cambria", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(677, 525);
            label5.Name = "label5";
            label5.Size = new Size(87, 36);
            label5.TabIndex = 7;
            label5.Text = "Clear";
            label5.Click += label5_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1155, 710);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(UPassTb);
            Controls.Add(UnameTb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Font = new Font("Segoe UI Symbol", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = Color.Navy;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox UnameTb;
        private TextBox UPassTb;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}