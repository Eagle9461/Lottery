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
            tabPane = new TabControl();
            tabDataEntry = new TabPage();
            groupBox2 = new GroupBox();
            btnSave = new Button();
            calendar = new MonthCalendar();
            label9 = new Label();
            selDrawingTime = new ComboBox();
            groupBox1 = new GroupBox();
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
            button1 = new Button();
            groupBox4 = new GroupBox();
            listView1 = new ListView();
            groupBox3 = new GroupBox();
            lstHistory = new ListView();
            tabPane.SuspendLayout();
            tabDataEntry.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numDataExtra).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numData6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numData5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numData4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numData3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numData2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numData1).BeginInit();
            tabCalculate.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // tabPane
            // 
            tabPane.Controls.Add(tabDataEntry);
            tabPane.Controls.Add(tabCalculate);
            tabPane.Location = new Point(12, 12);
            tabPane.Name = "tabPane";
            tabPane.SelectedIndex = 0;
            tabPane.Size = new Size(808, 352);
            tabPane.TabIndex = 0;
            tabPane.SelectedIndexChanged += tabPane_SelectedIndexChanged;
            // 
            // tabDataEntry
            // 
            tabDataEntry.Controls.Add(groupBox2);
            tabDataEntry.Controls.Add(groupBox1);
            tabDataEntry.Location = new Point(4, 24);
            tabDataEntry.Name = "tabDataEntry";
            tabDataEntry.Padding = new Padding(3);
            tabDataEntry.Size = new Size(800, 324);
            tabDataEntry.TabIndex = 0;
            tabDataEntry.Text = "Data Entry";
            tabDataEntry.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSave);
            groupBox2.Controls.Add(calendar);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(selDrawingTime);
            groupBox2.Location = new Point(522, 18);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 303);
            groupBox2.TabIndex = 35;
            groupBox2.TabStop = false;
            groupBox2.Text = "Action";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(80, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 33;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // calendar
            // 
            calendar.Location = new Point(19, 76);
            calendar.Name = "calendar";
            calendar.TabIndex = 32;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 14);
            label9.Name = "label9";
            label9.Size = new Size(86, 15);
            label9.TabIndex = 31;
            label9.Text = "Drawing Time :";
            // 
            // selDrawingTime
            // 
            selDrawingTime.FormattingEnabled = true;
            selDrawingTime.Location = new Point(19, 33);
            selDrawingTime.Name = "selDrawingTime";
            selDrawingTime.Size = new Size(162, 23);
            selDrawingTime.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(selExtraNumberRange);
            groupBox1.Controls.Add(selNumbersRange);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(numDataExtra);
            groupBox1.Controls.Add(numData6);
            groupBox1.Controls.Add(numData5);
            groupBox1.Controls.Add(numData4);
            groupBox1.Controls.Add(numData3);
            groupBox1.Controls.Add(numData2);
            groupBox1.Controls.Add(numData1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(selGameType);
            groupBox1.Location = new Point(6, 18);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(510, 303);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Data Input";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(275, 211);
            label11.Name = "label11";
            label11.Size = new Size(122, 15);
            label11.TabIndex = 29;
            label11.Text = "Extra Number Range :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 211);
            label10.Name = "label10";
            label10.Size = new Size(98, 15);
            label10.TabIndex = 28;
            label10.Text = "Numbers Range :";
            // 
            // selExtraNumberRange
            // 
            selExtraNumberRange.FormattingEnabled = true;
            selExtraNumberRange.Location = new Point(275, 232);
            selExtraNumberRange.Name = "selExtraNumberRange";
            selExtraNumberRange.Size = new Size(222, 23);
            selExtraNumberRange.TabIndex = 27;
            // 
            // selNumbersRange
            // 
            selNumbersRange.FormattingEnabled = true;
            selNumbersRange.Location = new Point(14, 232);
            selNumbersRange.Name = "selNumbersRange";
            selNumbersRange.Size = new Size(222, 23);
            selNumbersRange.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(434, 110);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 24;
            label8.Text = "Extra :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(364, 110);
            label7.Name = "label7";
            label7.Size = new Size(49, 15);
            label7.TabIndex = 23;
            label7.Text = "Num 6 :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(294, 110);
            label6.Name = "label6";
            label6.Size = new Size(49, 15);
            label6.TabIndex = 25;
            label6.Text = "Num 5 :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(224, 110);
            label5.Name = "label5";
            label5.Size = new Size(49, 15);
            label5.TabIndex = 22;
            label5.Text = "Num 4 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(154, 110);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 21;
            label4.Text = "Num 3 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 110);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 20;
            label3.Text = "Num 2 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 110);
            label2.Name = "label2";
            label2.Size = new Size(49, 15);
            label2.TabIndex = 19;
            label2.Text = "Num 1 :";
            // 
            // numDataExtra
            // 
            numDataExtra.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            numDataExtra.Location = new Point(433, 136);
            numDataExtra.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numDataExtra.Name = "numDataExtra";
            numDataExtra.Size = new Size(64, 46);
            numDataExtra.TabIndex = 18;
            numDataExtra.TextAlign = HorizontalAlignment.Center;
            numDataExtra.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numData6
            // 
            numData6.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            numData6.Location = new Point(363, 136);
            numData6.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numData6.Name = "numData6";
            numData6.Size = new Size(64, 46);
            numData6.TabIndex = 17;
            numData6.TextAlign = HorizontalAlignment.Center;
            numData6.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numData5
            // 
            numData5.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            numData5.Location = new Point(293, 136);
            numData5.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numData5.Name = "numData5";
            numData5.Size = new Size(64, 46);
            numData5.TabIndex = 16;
            numData5.TextAlign = HorizontalAlignment.Center;
            numData5.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numData4
            // 
            numData4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            numData4.Location = new Point(223, 136);
            numData4.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numData4.Name = "numData4";
            numData4.Size = new Size(64, 46);
            numData4.TabIndex = 15;
            numData4.TextAlign = HorizontalAlignment.Center;
            numData4.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numData3
            // 
            numData3.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            numData3.Location = new Point(153, 136);
            numData3.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numData3.Name = "numData3";
            numData3.Size = new Size(64, 46);
            numData3.TabIndex = 14;
            numData3.TextAlign = HorizontalAlignment.Center;
            numData3.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numData2
            // 
            numData2.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            numData2.Location = new Point(83, 136);
            numData2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numData2.Name = "numData2";
            numData2.Size = new Size(64, 46);
            numData2.TabIndex = 13;
            numData2.TextAlign = HorizontalAlignment.Center;
            numData2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numData1
            // 
            numData1.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            numData1.Location = new Point(13, 136);
            numData1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numData1.Name = "numData1";
            numData1.Size = new Size(64, 46);
            numData1.TabIndex = 12;
            numData1.TextAlign = HorizontalAlignment.Center;
            numData1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 36);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 11;
            label1.Text = "Game Type :";
            // 
            // selGameType
            // 
            selGameType.FormattingEnabled = true;
            selGameType.Location = new Point(14, 57);
            selGameType.Name = "selGameType";
            selGameType.Size = new Size(162, 23);
            selGameType.TabIndex = 10;
            selGameType.SelectedIndexChanged += selGameType_SelectedIndexChanged;
            // 
            // tabCalculate
            // 
            tabCalculate.Controls.Add(button1);
            tabCalculate.Controls.Add(groupBox4);
            tabCalculate.Controls.Add(groupBox3);
            tabCalculate.Location = new Point(4, 24);
            tabCalculate.Name = "tabCalculate";
            tabCalculate.Padding = new Padding(3);
            tabCalculate.Size = new Size(800, 324);
            tabCalculate.TabIndex = 1;
            tabCalculate.Text = "Get Lucky";
            tabCalculate.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(664, 90);
            button1.Name = "button1";
            button1.Size = new Size(96, 23);
            button1.TabIndex = 1;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(listView1);
            groupBox4.Location = new Point(310, 16);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(289, 290);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Suggested Combinations";
            // 
            // listView1
            // 
            listView1.Location = new Point(6, 23);
            listView1.Name = "listView1";
            listView1.Size = new Size(277, 261);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lstHistory);
            groupBox3.Location = new Point(6, 16);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(289, 290);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Drawings History";
            // 
            // lstHistory
            // 
            lstHistory.Location = new Point(6, 23);
            lstHistory.Name = "lstHistory";
            lstHistory.Size = new Size(277, 261);
            lstHistory.TabIndex = 0;
            lstHistory.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 376);
            Controls.Add(tabPane);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MainForm";
            Text = "SelectLuckyNumber";
            tabPane.ResumeLayout(false);
            tabDataEntry.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numDataExtra).EndInit();
            ((System.ComponentModel.ISupportInitialize)numData6).EndInit();
            ((System.ComponentModel.ISupportInitialize)numData5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numData4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numData3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numData2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numData1).EndInit();
            tabCalculate.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabPane;
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
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private Button button1;
        private GroupBox groupBox4;
        private ListView listView1;
        private GroupBox groupBox3;
    }
}