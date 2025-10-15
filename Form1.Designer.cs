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
            buttonQuit = new Button();
            buttonReRun = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Yu Gothic UI", 12F, FontStyle.Bold);
            label1.Location = new Point(103, 68);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(254, 168);
            label1.TabIndex = 0;
            label1.Text = "label1  ";
            // 
            // buttonQuit
            // 
            buttonQuit.Location = new Point(320, 11);
            buttonQuit.Margin = new Padding(2);
            buttonQuit.Name = "buttonQuit";
            buttonQuit.Size = new Size(76, 38);
            buttonQuit.TabIndex = 1;
            buttonQuit.Text = "終了";
            buttonQuit.UseVisualStyleBackColor = true;
            buttonQuit.Click += button1_Click;
            // 
            // buttonReRun
            // 
            buttonReRun.Location = new Point(77, 11);
            buttonReRun.Margin = new Padding(2);
            buttonReRun.Name = "buttonReRun";
            buttonReRun.Size = new Size(76, 38);
            buttonReRun.TabIndex = 2;
            buttonReRun.Text = "ReRun";
            buttonReRun.UseVisualStyleBackColor = true;
            buttonReRun.Click += buttonReRun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 271);
            Controls.Add(buttonReRun);
            Controls.Add(buttonQuit);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Form1";
            Text = "COM  Checker　 (一社) 大津市水泳協会";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button buttonQuit;
        private Button buttonReRun;
    }
}
