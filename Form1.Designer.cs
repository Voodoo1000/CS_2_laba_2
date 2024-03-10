namespace _2
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
            txtSequence = new TextBox();
            txtCount = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(453, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите последовательность натуральных чисел через пробел:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(367, 20);
            label2.TabIndex = 1;
            label2.Text = "Введите количество соседних чисел для проверки: ";
            // 
            // txtSequence
            // 
            txtSequence.Location = new Point(471, 22);
            txtSequence.Name = "txtSequence";
            txtSequence.Size = new Size(287, 27);
            txtSequence.TabIndex = 2;
            // 
            // txtCount
            // 
            txtCount.Location = new Point(385, 59);
            txtCount.Name = "txtCount";
            txtCount.Size = new Size(125, 27);
            txtCount.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(307, 106);
            button1.Name = "button1";
            button1.Size = new Size(167, 51);
            button1.TabIndex = 4;
            button1.Text = "Найти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 185);
            Controls.Add(button1);
            Controls.Add(txtCount);
            Controls.Add(txtSequence);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Программа 2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSequence;
        private TextBox txtCount;
        private Button button1;
    }
}
