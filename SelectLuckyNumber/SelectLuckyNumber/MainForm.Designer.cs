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
            tabControl1 = new TabControl();
            tabDataEntry = new TabPage();
            btnSave = new Button();
            calendar = new MonthCalendar();
            label9 = new Label();
            selDrawingTime = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            selExtraNumberRange = new ComboBox();
            selNumbersRange = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            numDataExtra = new NumericUpDown();
            numData6 = new NumericUpDown();
            numData5 = new NumericUpDown();
            numData4 = new NumericUpDown();
            numData3 = new NumericUpDown();
            numData2 = new NumericUpDown();
            numData1 = new NumericUpDown();
            label1 = new Label();
            selGameType = new ComboBox();
            tabCalculate = new TabPage();
            lstHistory = new ListView();
            tabControl1.SuspendLayout();
            tabDataEntry.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDataExtra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numData6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numData5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numData4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numData3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numData2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numData1).BeginInit();
            tabCalculate.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabDataEntry);
            tabControl1.Controls.Add(tabCalculate);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(865, 352);
            tabControl1.TabIndex = 0;
            // 
            // tabDataEntry
            // 
            tabDataEntry.Controls.Add(btnSave);
            tabDataEntry.Controls.Add(calendar);
            tabDataEntry.Controls.Add(label9);
            tabDataEntry.Controls.Add(selDrawingTime);
            tabDataEntry.Controls.Add(label11);
            tabDataEntry.Controls.Add(label10);
            tabDataEntry.Controls.Add(selExtraNumberRange);
            tabDataEntry.Controls.Add(selNumbersRange);
            tabDataEntry.Controls.Add(label8);
            tabDataEntry.Controls.Add(label7);
            tabDataEntry.Controls.Add(label6);
            tabDataEntry.Controls.Add(label5);
            tabDataEntry.Controls.Add(label4);
            tabDataEntry.Controls.Add(label3);
            tabDataEntry.Controls.Add(label2);
            tabDataEntry.Controls.Add(numDataExtra);
            tabDataEntry.Controls.Add(numData6);
            tabDataEntry.Controls.Add(numData5);
            tabDataEntry.Controls.Add(numData4);
            tabDataEntry.Controls.Add(numData3);
            tabDataEntry.Controls.Add(numData2);
            tabDataEntry.Controls.Add(numData1);
            tabDataEntry.Controls.Add(label1);
            tabDataEntry.Controls.Add(selGameType);
            tabDataEntry.Location = new Point(4, 24);
            tabDataEntry.Name = "tabDataEntry";
            tabDataEntry.Padding = new Padding(3);
            tabDataEntry.Size = new Size(857, 324);
            tabDataEntry.TabIndex = 0;
            tabDataEntry.Text = "Data Entry";
            tabDataEntry.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(583, 269);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 33;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // calendar
            // 
            calendar.Location = new Point(583, 95);
            calendar.Name = "calendar";
            calendar.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(583, 33);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 31;
            label9.Text = "Drawing Time :";
            // 
            // selDrawingTime
            // 
            selDrawingTime.FormattingEnabled = true;
            selDrawingTime.Location = new Point(583, 54);
            selDrawingTime.Name = "selDrawingTime";
            selDrawingTime.Size = new Size(162, 23);
            selDrawingTime.TabIndex = 30;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(228, 208);
            label11.Name = "label11";
            label11.Size = new Size(122, 15);
            label11.TabIndex = 29;
            label11.Text = "Extra Number Range :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(47, 208);
            label10.Name = "label10";
            label10.Size = new Size(98, 15);
            label10.TabIndex = 28;
            label10.Text = "Numbers Range :";
            // 
            // selExtraNumberRange
            // 
            selExtraNumberRange.FormattingEnabled = true;
            selExtraNumberRange.Location = new Point(228, 229);
            selExtraNumberRange.Name = "selExtraNumberRange";
            selExtraNumberRange.Size = new Size(162, 23);
            selExtraNumberRange.TabIndex = 27;
            // 
            // selNumbersRange
            // 
            selNumbersRange.FormattingEnabled = true;
            selNumbersRange.Location = new Point(47, 229);
            selNumbersRange.Name = "selNumbersRange";
            selNumbersRange.Size = new Size(162, 23);
            selNumbersRange.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(467, 95);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 24;
            label8.Text = "Extra :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(397, 95);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 23;
            label7.Text = "Num 6 :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(327, 95);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 25;
            label6.Text = "Num 5 :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(257, 95);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 22;
            label5.Text = "Num 4 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(187, 95);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 21;
            label4.Text = "Num 3 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 95);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 20;
            label3.Text = "Num 2 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 95);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 19;
            label2.Text = "Num 1 :";
            // 
            // numDataExtra
            // 
            numDataExtra.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            numDataExtra.Location = new Point(466, 121);
            numDataExtra.Name = "numDataExtra";
            numDataExtra.Size = new Size(64, 46);
            numDataExtra.TabIndex = 18;
            numDataExtra.TextAlign = HorizontalAlignment.Center;
            // 
            // numData6
            // 
            numData6.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            numData6.Location = new Point(396, 121);
            numData6.Name = "numData6";
            numData6.Size = new Size(64, 46);
            numData6.TabIndex = 17;
            numData6.TextAlign = HorizontalAlignment.Center;
            // 
            // numData5
            // 
            numData5.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            numData5.Location = new Point(326, 121);
            numData5.Name = "numData5";
            numData5.Size = new Size(64, 46);
            numData5.TabIndex = 16;
            numData5.TextAlign = HorizontalAlignment.Center;
            // 
            // numData4
            // 
            numData4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            numData4.Location = new Point(256, 121);
            numData4.Name = "numData4";
            numData4.Size = new Size(64, 46);
            numData4.TabIndex = 15;
            numData4.TextAlign = HorizontalAlignment.Center;
            // 
            // numData3
            // 
            numData3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            numData3.Location = new Point(186, 121);
            numData3.Name = "numData3";
            numData3.Size = new Size(64, 46);
            numData3.TabIndex = 14;
            numData3.TextAlign = HorizontalAlignment.Center;
            // 
            // numData2
            // 
            numData2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            numData2.Location = new Point(116, 121);
            numData2.Name = "numData2";
            numData2.Size = new Size(64, 46);
            numData2.TabIndex = 13;
            numData2.TextAlign = HorizontalAlignment.Center;
            // 
            // numData1
            // 
            numData1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            numData1.Location = new Point(46, 121);
            numData1.Name = "numData1";
            numData1.Size = new Size(64, 46);
            numData1.TabIndex = 12;
            numData1.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 33);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 11;
            label1.Text = "Game Type :";
            // 
            // selGameType
            // 
            selGameType.FormattingEnabled = true;
            selGameType.Location = new Point(47, 54);
            selGameType.Name = "selGameType";
            selGameType.Size = new Size(162, 23);
            selGameType.TabIndex = 10;
            // 
            // tabCalculate
            // 
            tabCalculate.Controls.Add(lstHistory);
            tabCalculate.Location = new Point(4, 24);
            tabCalculate.Name = "tabCalculate";
            tabCalculate.Padding = new Padding(3);
            tabCalculate.Size = new Size(857, 324);
            tabCalculate.TabIndex = 1;
            tabCalculate.Text = "Get Lucky";
            tabCalculate.UseVisualStyleBackColor = true;
            // 
            // lstHistory
            // 
            lstHistory.Location = new Point(21, 37);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(286, 261);
            lstHistory.TabIndex = 0;
            lstHistory.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 376);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MainForm";
            Text = "SelectLuckyNumber";
            tabControl1.ResumeLayout(false);
            tabDataEntry.ResumeLayout(false);
            tabDataEntry.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDataExtra).EndInit();
            ((System.ComponentModel.ISupportInitialize)numData6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numData5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numData4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numData3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numData2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numData1).EndInit();
            tabCalculate.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabDataEntry;
        private Button btnSave;
        private MonthCalendar calendar;
        private Label label9;
        private ComboBox selDrawingTime;
        private Label label11;
        private Label label10;
        private ComboBox selExtraNumberRange;
        private ComboBox selNumbersRange;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown numDataExtra;
        private NumericUpDown numData6;
        private NumericUpDown numData5;
        private NumericUpDown numData4;
        private NumericUpDown numData3;
        private NumericUpDown numData2;
        private NumericUpDown numData1;
        private Label label1;
        private ComboBox selGameType;
        private TabPage tabCalculate;
        private ListView lstHistory;
    }
}