namespace AdditionCalculator
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
            label1 = new Label();
            label2 = new Label();
            lblResult = new Label();
            btnCalculate = new Button();
            txtFirstNumber = new TextBox();
            txtSecondNumber = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(55, 99);
            label1.Name = "label1";
            label1.Padding = new Padding(5);
            label1.Size = new Size(89, 25);
            label1.TabIndex = 0;
            label1.Text = "First Number:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(55, 136);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(109, 25);
            label2.TabIndex = 1;
            label2.Text = "Second Number :";
            label2.Click += label2_Click;
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Location = new Point(272, 203);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(39, 15);
            lblResult.TabIndex = 2;
            lblResult.Text = "Result";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(55, 195);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(123, 23);
            btnCalculate.TabIndex = 3;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // txtFirstNumber
            // 
            txtFirstNumber.Cursor = Cursors.Hand;
            txtFirstNumber.Location = new Point(176, 101);
            txtFirstNumber.Name = "txtFirstNumber";
            txtFirstNumber.Size = new Size(147, 23);
            txtFirstNumber.TabIndex = 4;
            // 
            // txtSecondNumber
            // 
            txtSecondNumber.Location = new Point(176, 138);
            txtSecondNumber.Name = "txtSecondNumber";
            txtSecondNumber.Size = new Size(147, 23);
            txtSecondNumber.TabIndex = 5;
            txtSecondNumber.TextChanged += txtSecondNumber_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 60);
            label3.MaximumSize = new Size(100, 100);
            label3.MinimumSize = new Size(50, 50);
            label3.Name = "label3";
            label3.Size = new Size(62, 50);
            label3.TabIndex = 6;
            label3.Text = "SIMPLE ADDITION";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(568, 310);
            Controls.Add(label3);
            Controls.Add(txtSecondNumber);
            Controls.Add(txtFirstNumber);
            Controls.Add(btnCalculate);
            Controls.Add(lblResult);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblResult;
        private Button btnCalculate;
        private TextBox txtFirstNumber;
        private TextBox txtSecondNumber;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
    }
}
