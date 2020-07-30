namespace smartfarm.Setting_ui
{
    partial class ucPanel_fan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPanel_fan));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.txtStartHH = new System.Windows.Forms.TextBox();
            this.StartMM = new System.Windows.Forms.TextBox();
            this.StartSS = new System.Windows.Forms.TextBox();
            this.StopHH = new System.Windows.Forms.TextBox();
            this.StopMM = new System.Windows.Forms.TextBox();
            this.StopSS = new System.Windows.Forms.TextBox();
            this.LowTemperature = new System.Windows.Forms.TextBox();
            this.HighTemperature = new System.Windows.Forms.TextBox();
            this.LowHumidity = new System.Windows.Forms.TextBox();
            this.HighHumidity = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(673, 50);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::smartfarm.Properties.Resources.FanManual;
            this.pictureBox3.Location = new System.Drawing.Point(48, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(149, 35);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(48, 215);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(673, 50);
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(48, 265);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(673, 50);
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(48, 179);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 35);
            this.pictureBox6.TabIndex = 1;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // txtStartHH
            // 
            this.txtStartHH.BackColor = System.Drawing.SystemColors.Control;
            this.txtStartHH.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStartHH.Location = new System.Drawing.Point(210, 63);
            this.txtStartHH.Multiline = true;
            this.txtStartHH.Name = "txtStartHH";
            this.txtStartHH.Size = new System.Drawing.Size(58, 42);
            this.txtStartHH.TabIndex = 14;
            this.txtStartHH.Text = "0";
            this.txtStartHH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartMM
            // 
            this.StartMM.BackColor = System.Drawing.SystemColors.Control;
            this.StartMM.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartMM.Location = new System.Drawing.Point(325, 63);
            this.StartMM.Multiline = true;
            this.StartMM.Name = "StartMM";
            this.StartMM.Size = new System.Drawing.Size(58, 42);
            this.StartMM.TabIndex = 14;
            this.StartMM.Text = "0";
            this.StartMM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StartSS
            // 
            this.StartSS.BackColor = System.Drawing.SystemColors.Control;
            this.StartSS.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartSS.Location = new System.Drawing.Point(436, 63);
            this.StartSS.Multiline = true;
            this.StartSS.Name = "StartSS";
            this.StartSS.Size = new System.Drawing.Size(58, 42);
            this.StartSS.TabIndex = 14;
            this.StartSS.Text = "0";
            this.StartSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StopHH
            // 
            this.StopHH.BackColor = System.Drawing.SystemColors.Control;
            this.StopHH.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StopHH.Location = new System.Drawing.Point(210, 114);
            this.StopHH.Multiline = true;
            this.StopHH.Name = "StopHH";
            this.StopHH.Size = new System.Drawing.Size(58, 42);
            this.StopHH.TabIndex = 14;
            this.StopHH.Text = "0";
            this.StopHH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StopMM
            // 
            this.StopMM.BackColor = System.Drawing.SystemColors.Control;
            this.StopMM.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StopMM.Location = new System.Drawing.Point(325, 114);
            this.StopMM.Multiline = true;
            this.StopMM.Name = "StopMM";
            this.StopMM.Size = new System.Drawing.Size(58, 42);
            this.StopMM.TabIndex = 14;
            this.StopMM.Text = "0";
            this.StopMM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StopSS
            // 
            this.StopSS.BackColor = System.Drawing.SystemColors.Control;
            this.StopSS.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StopSS.Location = new System.Drawing.Point(436, 114);
            this.StopSS.Multiline = true;
            this.StopSS.Name = "StopSS";
            this.StopSS.Size = new System.Drawing.Size(58, 42);
            this.StopSS.TabIndex = 14;
            this.StopSS.Text = "0";
            this.StopSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LowTemperature
            // 
            this.LowTemperature.BackColor = System.Drawing.SystemColors.Control;
            this.LowTemperature.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LowTemperature.Location = new System.Drawing.Point(152, 220);
            this.LowTemperature.Multiline = true;
            this.LowTemperature.Name = "LowTemperature";
            this.LowTemperature.Size = new System.Drawing.Size(58, 42);
            this.LowTemperature.TabIndex = 14;
            this.LowTemperature.Text = "0";
            this.LowTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HighTemperature
            // 
            this.HighTemperature.BackColor = System.Drawing.SystemColors.Control;
            this.HighTemperature.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HighTemperature.Location = new System.Drawing.Point(290, 220);
            this.HighTemperature.Multiline = true;
            this.HighTemperature.Name = "HighTemperature";
            this.HighTemperature.Size = new System.Drawing.Size(58, 42);
            this.HighTemperature.TabIndex = 14;
            this.HighTemperature.Text = "0";
            this.HighTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LowHumidity
            // 
            this.LowHumidity.BackColor = System.Drawing.SystemColors.Control;
            this.LowHumidity.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LowHumidity.Location = new System.Drawing.Point(152, 271);
            this.LowHumidity.Multiline = true;
            this.LowHumidity.Name = "LowHumidity";
            this.LowHumidity.Size = new System.Drawing.Size(58, 42);
            this.LowHumidity.TabIndex = 14;
            this.LowHumidity.Text = "0";
            this.LowHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HighHumidity
            // 
            this.HighHumidity.BackColor = System.Drawing.SystemColors.Control;
            this.HighHumidity.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HighHumidity.Location = new System.Drawing.Point(290, 271);
            this.HighHumidity.Multiline = true;
            this.HighHumidity.Name = "HighHumidity";
            this.HighHumidity.Size = new System.Drawing.Size(58, 42);
            this.HighHumidity.TabIndex = 14;
            this.HighHumidity.Text = "0";
            this.HighHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ucPanel_fan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StopSS);
            this.Controls.Add(this.StartSS);
            this.Controls.Add(this.StopMM);
            this.Controls.Add(this.StartMM);
            this.Controls.Add(this.HighHumidity);
            this.Controls.Add(this.HighTemperature);
            this.Controls.Add(this.LowHumidity);
            this.Controls.Add(this.LowTemperature);
            this.Controls.Add(this.StopHH);
            this.Controls.Add(this.txtStartHH);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucPanel_fan";
            this.Size = new System.Drawing.Size(800, 335);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox txtStartHH;
        private System.Windows.Forms.TextBox StartMM;
        private System.Windows.Forms.TextBox StartSS;
        private System.Windows.Forms.TextBox StopHH;
        private System.Windows.Forms.TextBox StopMM;
        private System.Windows.Forms.TextBox StopSS;
        private System.Windows.Forms.TextBox LowTemperature;
        private System.Windows.Forms.TextBox HighTemperature;
        private System.Windows.Forms.TextBox LowHumidity;
        private System.Windows.Forms.TextBox HighHumidity;
    }
}
