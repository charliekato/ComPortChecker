namespace ComPortCheck
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
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label1.Location = new Point(168, 109);
            label1.Name = "label1";
            label1.Size = new Size(413, 268);
            label1.TabIndex = 0;
            label1.Text = "label1  ";
            // 
            // button1
            // 
            button1.Location = new Point(319, 19);
            button1.Name = "button1";
            button1.Size = new Size(124, 61);
            button1.TabIndex = 1;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(770, 433);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "COM  Checker　 (一社) 大津市水泳協会";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}
