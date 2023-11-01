namespace simpleCalculator
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
            firstNumbBox = new TextBox();
            secondNumbBox = new TextBox();
            resultBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            subtractBtn = new Button();
            multiplyBtn = new Button();
            divideBtn = new Button();
            clearBtn = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // firstNumbBox
            // 
            firstNumbBox.Location = new Point(145, 28);
            firstNumbBox.Name = "firstNumbBox";
            firstNumbBox.Size = new Size(125, 27);
            firstNumbBox.TabIndex = 0;
            firstNumbBox.KeyPress += firstNumbBox_KeyPress;
            // 
            // secondNumbBox
            // 
            secondNumbBox.Location = new Point(145, 81);
            secondNumbBox.Name = "secondNumbBox";
            secondNumbBox.Size = new Size(125, 27);
            secondNumbBox.TabIndex = 1;
            secondNumbBox.KeyPress += secondNumbBox_KeyPress;
            // 
            // resultBox
            // 
            resultBox.Location = new Point(145, 141);
            resultBox.Name = "resultBox";
            resultBox.ReadOnly = true;
            resultBox.Size = new Size(125, 27);
            resultBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 28);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 3;
            label1.Text = "First Number";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 4;
            label2.Text = "Second Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(50, 141);
            label3.Name = "label3";
            label3.Size = new Size(65, 25);
            label3.TabIndex = 5;
            label3.Text = "Result";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(3, 264);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // subtractBtn
            // 
            subtractBtn.BackColor = Color.LightCoral;
            subtractBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            subtractBtn.Location = new Point(103, 264);
            subtractBtn.Name = "subtractBtn";
            subtractBtn.Size = new Size(94, 29);
            subtractBtn.TabIndex = 7;
            subtractBtn.Text = "Subtract";
            subtractBtn.UseVisualStyleBackColor = false;
            subtractBtn.Click += subtractBtn_Click;
            // 
            // multiplyBtn
            // 
            multiplyBtn.BackColor = Color.Cyan;
            multiplyBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            multiplyBtn.Location = new Point(203, 264);
            multiplyBtn.Name = "multiplyBtn";
            multiplyBtn.Size = new Size(94, 29);
            multiplyBtn.TabIndex = 8;
            multiplyBtn.Text = "Multiply";
            multiplyBtn.UseVisualStyleBackColor = false;
            multiplyBtn.Click += multiplyBtn_Click;
            // 
            // divideBtn
            // 
            divideBtn.BackColor = Color.FromArgb(128, 128, 255);
            divideBtn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            divideBtn.Location = new Point(303, 264);
            divideBtn.Name = "divideBtn";
            divideBtn.Size = new Size(94, 29);
            divideBtn.TabIndex = 9;
            divideBtn.Text = "Divide";
            divideBtn.UseVisualStyleBackColor = false;
            divideBtn.Click += divideBtn_Click;
            // 
            // clearBtn
            // 
            clearBtn.BackColor = Color.Red;
            clearBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            clearBtn.Location = new Point(75, 330);
            clearBtn.Name = "clearBtn";
            clearBtn.Size = new Size(110, 43);
            clearBtn.TabIndex = 10;
            clearBtn.Text = "CLEAR";
            clearBtn.UseVisualStyleBackColor = false;
            clearBtn.Click += clearBtn_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.FromArgb(255, 255, 128);
            button6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(203, 330);
            button6.Name = "button6";
            button6.Size = new Size(108, 43);
            button6.TabIndex = 11;
            button6.Text = "Use Result";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(403, 450);
            Controls.Add(button6);
            Controls.Add(clearBtn);
            Controls.Add(divideBtn);
            Controls.Add(multiplyBtn);
            Controls.Add(subtractBtn);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(resultBox);
            Controls.Add(secondNumbBox);
            Controls.Add(firstNumbBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstNumbBox;
        private TextBox secondNumbBox;
        private TextBox resultBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button subtractBtn;
        private Button multiplyBtn;
        private Button divideBtn;
        private Button clearBtn;
        private Button button6;
    }
}