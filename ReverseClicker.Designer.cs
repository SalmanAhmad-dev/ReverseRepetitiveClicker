namespace ReverseRepetitiveClicker
{
    partial class ReverseClicker
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
            textBoxMaxN = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBoxMaxN
            // 
            textBoxMaxN.Location = new Point(283, 123);
            textBoxMaxN.Name = "textBoxMaxN";
            textBoxMaxN.Size = new Size(78, 23);
            textBoxMaxN.TabIndex = 0;
            textBoxMaxN.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(202, 258);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Reset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(234, 123);
            label1.Name = "label1";
            label1.Size = new Size(43, 23);
            label1.TabIndex = 3;
            label1.Text = "Max #";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(339, 345);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 4;
            label2.Text = "Status";
            // 
            // ReverseClicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(645, 453);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(textBoxMaxN);
            Name = "ReverseClicker";
            Text = "ReverseClicker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMaxN;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}
