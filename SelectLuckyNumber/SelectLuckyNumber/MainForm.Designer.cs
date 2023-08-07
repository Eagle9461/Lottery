namespace SelectLuckyNumber
{
    partial class MainForm
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
            selGameType = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // selGameType
            // 
            selGameType.FormattingEnabled = true;
            selGameType.Location = new Point(93, 82);
            selGameType.Name = "selGameType";
            selGameType.Size = new Size(162, 23);
            selGameType.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 61);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "GameType";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(selGameType);
            Name = "MainForm";
            Text = "SelectLuckyNumber";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox selGameType;
        private Label label1;
    }
}