namespace marketPriceChecker
{
    partial class companyCheck
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            searchBox = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 97);
            label1.Name = "label1";
            label1.Size = new Size(311, 28);
            label1.TabIndex = 0;
            label1.Text = "Please enter a company Code\r\n";
            // 
            // searchBox
            // 
            searchBox.BackColor = Color.FromArgb(47, 68, 160);
            searchBox.Location = new Point(326, 97);
            searchBox.Margin = new Padding(0);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(199, 27);
            searchBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(27, 166, 222);
            label2.Location = new Point(127, 45);
            label2.Name = "label2";
            label2.Size = new Size(372, 36);
            label2.TabIndex = 2;
            label2.Text = "Company Price Checker";
            // 
            // button1
            // 
            button1.Location = new Point(543, 95);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(12, 377);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 4;
            button2.Text = "Read";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // companyCheck
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(47, 68, 160);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(searchBox);
            Controls.Add(label1);
            Name = "companyCheck";
            Size = new Size(652, 418);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox searchBox;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}
