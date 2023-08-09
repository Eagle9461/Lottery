namespace UndergroundPlayBook
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabPane = new System.Windows.Forms.TabControl();
            this.tabDataEntry = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.selDrawingTime = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numDataExtra = new System.Windows.Forms.NumericUpDown();
            this.numData6 = new System.Windows.Forms.NumericUpDown();
            this.numData5 = new System.Windows.Forms.NumericUpDown();
            this.numData4 = new System.Windows.Forms.NumericUpDown();
            this.numData3 = new System.Windows.Forms.NumericUpDown();
            this.numData2 = new System.Windows.Forms.NumericUpDown();
            this.numData1 = new System.Windows.Forms.NumericUpDown();
            this.selExtraNumberRange = new System.Windows.Forms.ComboBox();
            this.selNumbersRange = new System.Windows.Forms.ComboBox();
            this.selGameType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabCalculate = new System.Windows.Forms.TabPage();
            this.selGameTypeToCalculate = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClearResult = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lstResult = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstHistory = new System.Windows.Forms.ListView();
            this.tabPane.SuspendLayout();
            this.tabDataEntry.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDataExtra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numData6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numData5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numData4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numData3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numData2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numData1)).BeginInit();
            this.tabCalculate.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPane
            // 
            this.tabPane.Controls.Add(this.tabDataEntry);
            this.tabPane.Controls.Add(this.tabCalculate);
            this.tabPane.Location = new System.Drawing.Point(3, 12);
            this.tabPane.Name = "tabPane";
            this.tabPane.SelectedIndex = 0;
            this.tabPane.Size = new System.Drawing.Size(847, 386);
            this.tabPane.TabIndex = 0;
            this.tabPane.SelectedIndexChanged += new System.EventHandler(this.tabPane_SelectedIndexChanged);
            // 
            // tabDataEntry
            // 
            this.tabDataEntry.Controls.Add(this.groupBox2);
            this.tabDataEntry.Controls.Add(this.groupBox1);
            this.tabDataEntry.Location = new System.Drawing.Point(4, 22);
            this.tabDataEntry.Name = "tabDataEntry";
            this.tabDataEntry.Padding = new System.Windows.Forms.Padding(3);
            this.tabDataEntry.Size = new System.Drawing.Size(839, 360);
            this.tabDataEntry.TabIndex = 0;
            this.tabDataEntry.Text = "Data Entry";
            this.tabDataEntry.UseVisualStyleBackColor = true;
            this.tabDataEntry.Click += new System.EventHandler(this.tabDataEntry_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.calendar);
            this.groupBox2.Controls.Add(this.selDrawingTime);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(558, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 306);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(87, 267);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(12, 93);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 1;
            // 
            // selDrawingTime
            // 
            this.selDrawingTime.FormattingEnabled = true;
            this.selDrawingTime.Location = new System.Drawing.Point(12, 60);
            this.selDrawingTime.Name = "selDrawingTime";
            this.selDrawingTime.Size = new System.Drawing.Size(150, 21);
            this.selDrawingTime.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Drawing Time :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.numDataExtra);
            this.groupBox1.Controls.Add(this.numData6);
            this.groupBox1.Controls.Add(this.numData5);
            this.groupBox1.Controls.Add(this.numData4);
            this.groupBox1.Controls.Add(this.numData3);
            this.groupBox1.Controls.Add(this.numData2);
            this.groupBox1.Controls.Add(this.numData1);
            this.groupBox1.Controls.Add(this.selExtraNumberRange);
            this.groupBox1.Controls.Add(this.selNumbersRange);
            this.groupBox1.Controls.Add(this.selGameType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(16, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 307);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Input";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(454, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Extra :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(383, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Num 6 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(312, 127);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Num 5 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Num 4 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(170, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Num 3 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Num 2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Num 1 :";
            // 
            // numDataExtra
            // 
            this.numDataExtra.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numDataExtra.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numDataExtra.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.numDataExtra.Location = new System.Drawing.Point(454, 149);
            this.numDataExtra.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDataExtra.Name = "numDataExtra";
            this.numDataExtra.Size = new System.Drawing.Size(65, 47);
            this.numDataExtra.TabIndex = 2;
            this.numDataExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDataExtra.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numData6
            // 
            this.numData6.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numData6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numData6.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.numData6.Location = new System.Drawing.Point(383, 149);
            this.numData6.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numData6.Name = "numData6";
            this.numData6.Size = new System.Drawing.Size(65, 47);
            this.numData6.TabIndex = 2;
            this.numData6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numData6.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numData5
            // 
            this.numData5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numData5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numData5.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.numData5.Location = new System.Drawing.Point(312, 149);
            this.numData5.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numData5.Name = "numData5";
            this.numData5.Size = new System.Drawing.Size(65, 47);
            this.numData5.TabIndex = 2;
            this.numData5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numData5.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numData4
            // 
            this.numData4.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numData4.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numData4.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.numData4.Location = new System.Drawing.Point(241, 149);
            this.numData4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numData4.Name = "numData4";
            this.numData4.Size = new System.Drawing.Size(65, 47);
            this.numData4.TabIndex = 2;
            this.numData4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numData4.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numData3
            // 
            this.numData3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numData3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numData3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.numData3.Location = new System.Drawing.Point(170, 149);
            this.numData3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numData3.Name = "numData3";
            this.numData3.Size = new System.Drawing.Size(65, 47);
            this.numData3.TabIndex = 2;
            this.numData3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numData3.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numData2
            // 
            this.numData2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numData2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numData2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.numData2.Location = new System.Drawing.Point(99, 149);
            this.numData2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numData2.Name = "numData2";
            this.numData2.Size = new System.Drawing.Size(65, 47);
            this.numData2.TabIndex = 2;
            this.numData2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numData2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numData1
            // 
            this.numData1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.numData1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numData1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.numData1.Location = new System.Drawing.Point(28, 149);
            this.numData1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numData1.Name = "numData1";
            this.numData1.Size = new System.Drawing.Size(65, 47);
            this.numData1.TabIndex = 2;
            this.numData1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numData1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // selExtraNumberRange
            // 
            this.selExtraNumberRange.FormattingEnabled = true;
            this.selExtraNumberRange.Location = new System.Drawing.Point(257, 255);
            this.selExtraNumberRange.Name = "selExtraNumberRange";
            this.selExtraNumberRange.Size = new System.Drawing.Size(202, 21);
            this.selExtraNumberRange.TabIndex = 1;
            // 
            // selNumbersRange
            // 
            this.selNumbersRange.FormattingEnabled = true;
            this.selNumbersRange.Location = new System.Drawing.Point(28, 255);
            this.selNumbersRange.Name = "selNumbersRange";
            this.selNumbersRange.Size = new System.Drawing.Size(202, 21);
            this.selNumbersRange.TabIndex = 1;
            // 
            // selGameType
            // 
            this.selGameType.FormattingEnabled = true;
            this.selGameType.Location = new System.Drawing.Point(28, 60);
            this.selGameType.Name = "selGameType";
            this.selGameType.Size = new System.Drawing.Size(150, 21);
            this.selGameType.TabIndex = 1;
            this.selGameType.SelectedIndexChanged += new System.EventHandler(this.selGameType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Extra Number Range :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Number Range :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Type :";
            // 
            // tabCalculate
            // 
            this.tabCalculate.Controls.Add(this.selGameTypeToCalculate);
            this.tabCalculate.Controls.Add(this.label12);
            this.tabCalculate.Controls.Add(this.btnCalculate);
            this.tabCalculate.Controls.Add(this.btnClearResult);
            this.tabCalculate.Controls.Add(this.groupBox4);
            this.tabCalculate.Controls.Add(this.groupBox3);
            this.tabCalculate.Location = new System.Drawing.Point(4, 22);
            this.tabCalculate.Name = "tabCalculate";
            this.tabCalculate.Padding = new System.Windows.Forms.Padding(3);
            this.tabCalculate.Size = new System.Drawing.Size(839, 360);
            this.tabCalculate.TabIndex = 1;
            this.tabCalculate.Text = "Get Lucky";
            this.tabCalculate.UseVisualStyleBackColor = true;
            // 
            // selGameTypeToCalculate
            // 
            this.selGameTypeToCalculate.FormattingEnabled = true;
            this.selGameTypeToCalculate.Location = new System.Drawing.Point(658, 240);
            this.selGameTypeToCalculate.Name = "selGameTypeToCalculate";
            this.selGameTypeToCalculate.Size = new System.Drawing.Size(153, 21);
            this.selGameTypeToCalculate.TabIndex = 3;
            this.selGameTypeToCalculate.SelectedIndexChanged += new System.EventHandler(this.selGameTypeToCalculate_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(658, 222);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Game Type :";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(685, 288);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(101, 23);
            this.btnCalculate.TabIndex = 1;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClearResult
            // 
            this.btnClearResult.Location = new System.Drawing.Point(685, 179);
            this.btnClearResult.Name = "btnClearResult";
            this.btnClearResult.Size = new System.Drawing.Size(101, 23);
            this.btnClearResult.TabIndex = 1;
            this.btnClearResult.Text = "Clear Result";
            this.btnClearResult.UseVisualStyleBackColor = true;
            this.btnClearResult.Click += new System.EventHandler(this.btnClearResult_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lstResult);
            this.groupBox4.Location = new System.Drawing.Point(324, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(301, 335);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Suggested Combinations";
            // 
            // lstResult
            // 
            this.lstResult.HideSelection = false;
            this.lstResult.Location = new System.Drawing.Point(6, 28);
            this.lstResult.Name = "lstResult";
            this.lstResult.Size = new System.Drawing.Size(289, 301);
            this.lstResult.TabIndex = 0;
            this.lstResult.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstHistory);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(301, 335);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Drawings History";
            // 
            // lstHistory
            // 
            this.lstHistory.HideSelection = false;
            this.lstHistory.Location = new System.Drawing.Point(6, 28);
            this.lstHistory.Name = "lstHistory";
            this.lstHistory.Size = new System.Drawing.Size(289, 301);
            this.lstHistory.TabIndex = 0;
            this.lstHistory.UseCompatibleStateImageBehavior = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 403);
            this.Controls.Add(this.tabPane);
            this.Name = "Main";
            this.Text = "Underground PlayBook";
            this.tabPane.ResumeLayout(false);
            this.tabDataEntry.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDataExtra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numData6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numData5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numData4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numData3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numData2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numData1)).EndInit();
            this.tabCalculate.ResumeLayout(false);
            this.tabCalculate.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPane;
        private System.Windows.Forms.TabPage tabDataEntry;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.ComboBox selDrawingTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numDataExtra;
        private System.Windows.Forms.NumericUpDown numData6;
        private System.Windows.Forms.NumericUpDown numData5;
        private System.Windows.Forms.NumericUpDown numData4;
        private System.Windows.Forms.NumericUpDown numData3;
        private System.Windows.Forms.NumericUpDown numData2;
        private System.Windows.Forms.NumericUpDown numData1;
        private System.Windows.Forms.ComboBox selExtraNumberRange;
        private System.Windows.Forms.ComboBox selNumbersRange;
        private System.Windows.Forms.ComboBox selGameType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabCalculate;
        private System.Windows.Forms.ComboBox selGameTypeToCalculate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClearResult;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView lstResult;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lstHistory;
    }
}