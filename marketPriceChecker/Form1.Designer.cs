namespace marketPriceChecker
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
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            panel2 = new Panel();
            homePage1 = new homePage();
            metalsPrices1 = new metalsPrices();
            companyCheck1 = new companyCheck();
            homeBtn = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(47, 68, 160);
            panel1.Controls.Add(homeBtn);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(254, 577);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(28, 85, 133);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.FromArgb(27, 166, 222);
            button4.Location = new Point(0, 453);
            button4.Name = "button4";
            button4.Size = new Size(254, 66);
            button4.TabIndex = 4;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(28, 85, 133);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.FromArgb(27, 166, 222);
            button3.Location = new Point(-3, 381);
            button3.Name = "button3";
            button3.Size = new Size(257, 66);
            button3.TabIndex = 2;
            button3.Text = "Get A Quote";
            button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(28, 85, 133);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.FromArgb(27, 166, 222);
            button1.Location = new Point(0, 309);
            button1.Name = "button1";
            button1.Size = new Size(250, 66);
            button1.TabIndex = 0;
            button1.Text = "Company Checker";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(28, 85, 133);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.FromArgb(27, 166, 222);
            button2.Location = new Point(0, 237);
            button2.Name = "button2";
            button2.Size = new Size(250, 66);
            button2.TabIndex = 1;
            button2.Text = "Metals Prices";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(46, 51, 73);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(253, 147);
            panel2.TabIndex = 1;
            // 
            // homePage1
            // 
            homePage1.BackColor = Color.FromArgb(47, 68, 160);
            homePage1.Dock = DockStyle.Top;
            homePage1.Location = new Point(254, 0);
            homePage1.Name = "homePage1";
            homePage1.Size = new Size(697, 615);
            homePage1.TabIndex = 1;
            // 
            // metalsPrices1
            // 
            metalsPrices1.BackColor = Color.Gray;
            metalsPrices1.Location = new Point(254, 0);
            metalsPrices1.Name = "metalsPrices1";
            metalsPrices1.Size = new Size(697, 577);
            metalsPrices1.TabIndex = 2;
            // 
            // companyCheck1
            // 
            companyCheck1.BackColor = Color.FromArgb(47, 68, 160);
            companyCheck1.Location = new Point(254, 0);
            companyCheck1.Name = "companyCheck1";
            companyCheck1.Size = new Size(697, 577);
            companyCheck1.TabIndex = 3;
            // 
            // homeBtn
            // 
            homeBtn.BackColor = Color.FromArgb(28, 85, 133);
            homeBtn.FlatStyle = FlatStyle.Flat;
            homeBtn.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point);
            homeBtn.ForeColor = Color.FromArgb(27, 166, 222);
            homeBtn.Location = new Point(0, 153);
            homeBtn.Name = "homeBtn";
            homeBtn.Size = new Size(251, 78);
            homeBtn.TabIndex = 5;
            homeBtn.Text = "Home";
            homeBtn.UseVisualStyleBackColor = false;
            homeBtn.Click += homeBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(46, 51, 73);
            ClientSize = new Size(951, 577);
            Controls.Add(companyCheck1);
            Controls.Add(metalsPrices1);
            Controls.Add(homePage1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button button2;
        private Button button1;
        private Button button3;
        private homePage homePage1;
        private metalsPrices metalsPrices1;
        private companyCheck companyCheck1;
        private Button button4;
        private Button homeBtn;
    }
}