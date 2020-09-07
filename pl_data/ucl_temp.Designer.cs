namespace smartfarm.pl_data
{
    partial class ucl_temp
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.TimePickE = new System.Windows.Forms.DateTimePicker();
            this.datePickE = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.TimePickS = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.datePickS = new System.Windows.Forms.DateTimePicker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnZOOM = new System.Windows.Forms.Button();
            this.TimePickEZ = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.datePickEZ = new System.Windows.Forms.DateTimePicker();
            this.TimePickSZ = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.datePickSZ = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Left;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Legend = "Legend1";
            series1.Name = "온도";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.Name = "습도";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(550, 371);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.TimePickE);
            this.groupBox7.Controls.Add(this.datePickE);
            this.groupBox7.Controls.Add(this.button4);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.TimePickS);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.datePickS);
            this.groupBox7.Location = new System.Drawing.Point(566, 16);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(202, 157);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "X좌표 범위";
            // 
            // TimePickE
            // 
            this.TimePickE.CustomFormat = "HH:mm:ss";
            this.TimePickE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePickE.Location = new System.Drawing.Point(113, 85);
            this.TimePickE.Name = "TimePickE";
            this.TimePickE.ShowUpDown = true;
            this.TimePickE.Size = new System.Drawing.Size(68, 21);
            this.TimePickE.TabIndex = 8;
            this.TimePickE.Value = new System.DateTime(2017, 10, 2, 12, 30, 0, 0);
            // 
            // datePickE
            // 
            this.datePickE.CustomFormat = "yyyy-MM-dd";
            this.datePickE.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickE.Location = new System.Drawing.Point(16, 85);
            this.datePickE.Name = "datePickE";
            this.datePickE.Size = new System.Drawing.Size(86, 21);
            this.datePickE.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(17, 117);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(164, 26);
            this.button4.TabIndex = 6;
            this.button4.Text = "범위 적용";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 66);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(29, 12);
            this.label15.TabIndex = 4;
            this.label15.Text = "최대";
            // 
            // TimePickS
            // 
            this.TimePickS.CustomFormat = "HH:mm:ss";
            this.TimePickS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePickS.Location = new System.Drawing.Point(113, 32);
            this.TimePickS.Name = "TimePickS";
            this.TimePickS.ShowUpDown = true;
            this.TimePickS.Size = new System.Drawing.Size(68, 21);
            this.TimePickS.TabIndex = 2;
            this.TimePickS.Value = new System.DateTime(2017, 10, 2, 12, 30, 0, 0);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(15, 17);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(29, 12);
            this.label16.TabIndex = 1;
            this.label16.Text = "최소";
            // 
            // datePickS
            // 
            this.datePickS.CustomFormat = "yyyy-MM-dd";
            this.datePickS.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickS.Location = new System.Drawing.Point(17, 32);
            this.datePickS.Name = "datePickS";
            this.datePickS.Size = new System.Drawing.Size(86, 21);
            this.datePickS.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnZOOM);
            this.groupBox6.Controls.Add(this.TimePickEZ);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.datePickEZ);
            this.groupBox6.Controls.Add(this.TimePickSZ);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.datePickSZ);
            this.groupBox6.Location = new System.Drawing.Point(566, 190);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(202, 147);
            this.groupBox6.TabIndex = 19;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "X-axis-Zoom";
            // 
            // btnZOOM
            // 
            this.btnZOOM.Location = new System.Drawing.Point(17, 117);
            this.btnZOOM.Name = "btnZOOM";
            this.btnZOOM.Size = new System.Drawing.Size(164, 26);
            this.btnZOOM.TabIndex = 6;
            this.btnZOOM.Text = "Set Zoom";
            this.btnZOOM.UseVisualStyleBackColor = true;
            this.btnZOOM.Click += new System.EventHandler(this.btnZOOM_Click);
            // 
            // TimePickEZ
            // 
            this.TimePickEZ.CustomFormat = "HH:mm:ss";
            this.TimePickEZ.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePickEZ.Location = new System.Drawing.Point(110, 81);
            this.TimePickEZ.Name = "TimePickEZ";
            this.TimePickEZ.ShowUpDown = true;
            this.TimePickEZ.Size = new System.Drawing.Size(68, 21);
            this.TimePickEZ.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 12);
            this.label7.TabIndex = 4;
            this.label7.Text = "Maximum";
            // 
            // datePickEZ
            // 
            this.datePickEZ.CustomFormat = "yyyy-MM-dd";
            this.datePickEZ.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickEZ.Location = new System.Drawing.Point(18, 81);
            this.datePickEZ.Name = "datePickEZ";
            this.datePickEZ.Size = new System.Drawing.Size(86, 21);
            this.datePickEZ.TabIndex = 3;
            // 
            // TimePickSZ
            // 
            this.TimePickSZ.CustomFormat = "HH:mm:ss";
            this.TimePickSZ.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TimePickSZ.Location = new System.Drawing.Point(109, 32);
            this.TimePickSZ.Name = "TimePickSZ";
            this.TimePickSZ.ShowUpDown = true;
            this.TimePickSZ.Size = new System.Drawing.Size(68, 21);
            this.TimePickSZ.TabIndex = 2;
            this.TimePickSZ.Value = new System.DateTime(2017, 10, 2, 12, 30, 0, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Minimum";
            // 
            // datePickSZ
            // 
            this.datePickSZ.CustomFormat = "yyyy-MM-dd";
            this.datePickSZ.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickSZ.Location = new System.Drawing.Point(17, 32);
            this.datePickSZ.Name = "datePickSZ";
            this.datePickSZ.Size = new System.Drawing.Size(86, 21);
            this.datePickSZ.TabIndex = 0;
            // 
            // ucl_temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.chart1);
            this.Name = "ucl_temp";
            this.Size = new System.Drawing.Size(784, 371);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DateTimePicker TimePickE;
        private System.Windows.Forms.DateTimePicker datePickE;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker TimePickS;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DateTimePicker datePickS;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnZOOM;
        private System.Windows.Forms.DateTimePicker TimePickEZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker datePickEZ;
        private System.Windows.Forms.DateTimePicker TimePickSZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker datePickSZ;
    }
}
