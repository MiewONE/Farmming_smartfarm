﻿namespace smartfarm.Setting_ui
{
    partial class ucPanel_Humi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucPanel_Humi));
            this.StopSS = new System.Windows.Forms.TextBox();
            this.StartSS = new System.Windows.Forms.TextBox();
            this.StopMM = new System.Windows.Forms.TextBox();
            this.StartMM = new System.Windows.Forms.TextBox();
            this.HighHumidity = new System.Windows.Forms.TextBox();
            this.LowHumidity = new System.Windows.Forms.TextBox();
            this.StopHH = new System.Windows.Forms.TextBox();
            this.StartHH = new System.Windows.Forms.TextBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Selectbox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StopSS
            // 
            this.StopSS.BackColor = System.Drawing.SystemColors.Control;
            this.StopSS.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StopSS.Location = new System.Drawing.Point(436, 114);
            this.StopSS.Multiline = true;
            this.StopSS.Name = "StopSS";
            this.StopSS.Size = new System.Drawing.Size(58, 42);
            this.StopSS.TabIndex = 21;
            this.StopSS.Text = "0";
            this.StopSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StopSS.Click += new System.EventHandler(this.StopSS_Click);
            this.StopSS.TextChanged += new System.EventHandler(this.StopSS_TextChanged);
            // 
            // StartSS
            // 
            this.StartSS.BackColor = System.Drawing.SystemColors.Control;
            this.StartSS.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartSS.Location = new System.Drawing.Point(436, 63);
            this.StartSS.Multiline = true;
            this.StartSS.Name = "StartSS";
            this.StartSS.Size = new System.Drawing.Size(58, 42);
            this.StartSS.TabIndex = 22;
            this.StartSS.Text = "0";
            this.StartSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartSS.Click += new System.EventHandler(this.StartSS_Click);
            this.StartSS.TextChanged += new System.EventHandler(this.StartSS_TextChanged);
            // 
            // StopMM
            // 
            this.StopMM.BackColor = System.Drawing.SystemColors.Control;
            this.StopMM.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StopMM.Location = new System.Drawing.Point(325, 114);
            this.StopMM.Multiline = true;
            this.StopMM.Name = "StopMM";
            this.StopMM.Size = new System.Drawing.Size(58, 42);
            this.StopMM.TabIndex = 23;
            this.StopMM.Text = "0";
            this.StopMM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StopMM.Click += new System.EventHandler(this.StopMM_Click);
            this.StopMM.TextChanged += new System.EventHandler(this.StopMM_TextChanged);
            // 
            // StartMM
            // 
            this.StartMM.BackColor = System.Drawing.SystemColors.Control;
            this.StartMM.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartMM.Location = new System.Drawing.Point(325, 63);
            this.StartMM.Multiline = true;
            this.StartMM.Name = "StartMM";
            this.StartMM.Size = new System.Drawing.Size(58, 42);
            this.StartMM.TabIndex = 24;
            this.StartMM.Text = "0";
            this.StartMM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartMM.Click += new System.EventHandler(this.StartMM_Click);
            this.StartMM.TextChanged += new System.EventHandler(this.StartMM_TextChanged);
            // 
            // HighHumidity
            // 
            this.HighHumidity.BackColor = System.Drawing.SystemColors.Control;
            this.HighHumidity.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HighHumidity.Location = new System.Drawing.Point(294, 220);
            this.HighHumidity.Multiline = true;
            this.HighHumidity.Name = "HighHumidity";
            this.HighHumidity.Size = new System.Drawing.Size(58, 42);
            this.HighHumidity.TabIndex = 25;
            this.HighHumidity.Text = "0";
            this.HighHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HighHumidity.Click += new System.EventHandler(this.HighHumidity_Click);
            this.HighHumidity.TextChanged += new System.EventHandler(this.HighHumidity_TextChanged);
            // 
            // LowHumidity
            // 
            this.LowHumidity.BackColor = System.Drawing.SystemColors.Control;
            this.LowHumidity.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LowHumidity.Location = new System.Drawing.Point(150, 220);
            this.LowHumidity.Multiline = true;
            this.LowHumidity.Name = "LowHumidity";
            this.LowHumidity.Size = new System.Drawing.Size(58, 42);
            this.LowHumidity.TabIndex = 27;
            this.LowHumidity.Text = "0";
            this.LowHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LowHumidity.Click += new System.EventHandler(this.LowHumidity_Click);
            this.LowHumidity.TextChanged += new System.EventHandler(this.LowHumidity_TextChanged);
            // 
            // StopHH
            // 
            this.StopHH.BackColor = System.Drawing.SystemColors.Control;
            this.StopHH.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StopHH.Location = new System.Drawing.Point(210, 114);
            this.StopHH.Multiline = true;
            this.StopHH.Name = "StopHH";
            this.StopHH.Size = new System.Drawing.Size(58, 42);
            this.StopHH.TabIndex = 29;
            this.StopHH.Text = "0";
            this.StopHH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StopHH.Click += new System.EventHandler(this.StopHH_Click);
            this.StopHH.TextChanged += new System.EventHandler(this.StopHH_TextChanged);
            // 
            // StartHH
            // 
            this.StartHH.BackColor = System.Drawing.SystemColors.Control;
            this.StartHH.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartHH.Location = new System.Drawing.Point(210, 63);
            this.StartHH.Multiline = true;
            this.StartHH.Name = "StartHH";
            this.StartHH.Size = new System.Drawing.Size(58, 42);
            this.StartHH.TabIndex = 30;
            this.StartHH.Text = "0";
            this.StartHH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartHH.Click += new System.EventHandler(this.StartHH_Click);
            this.StartHH.TextChanged += new System.EventHandler(this.StartHH_TextChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(48, 179);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 35);
            this.pictureBox6.TabIndex = 19;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(48, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 35);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::smartfarm.Properties.Resources.HumiSetting;
            this.pictureBox5.Location = new System.Drawing.Point(48, 214);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(673, 50);
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(48, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(673, 50);
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 50);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Selectbox
            // 
            this.Selectbox.Font = new System.Drawing.Font("굴림", 30F);
            this.Selectbox.FormattingEnabled = true;
            this.Selectbox.ItemHeight = 40;
            this.Selectbox.Location = new System.Drawing.Point(706, 282);
            this.Selectbox.MultiColumn = true;
            this.Selectbox.Name = "Selectbox";
            this.Selectbox.Size = new System.Drawing.Size(68, 4);
            this.Selectbox.TabIndex = 31;
            this.Selectbox.Click += new System.EventHandler(this.Selectbox_Click);
            // 
            // ucPanel_Humi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.Selectbox);
            this.Controls.Add(this.StopSS);
            this.Controls.Add(this.StartSS);
            this.Controls.Add(this.StopMM);
            this.Controls.Add(this.StartMM);
            this.Controls.Add(this.HighHumidity);
            this.Controls.Add(this.LowHumidity);
            this.Controls.Add(this.StopHH);
            this.Controls.Add(this.StartHH);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucPanel_Humi";
            this.Size = new System.Drawing.Size(800, 335);
            this.Load += new System.EventHandler(this.ucPanel_Humi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StopSS;
        private System.Windows.Forms.TextBox StartSS;
        private System.Windows.Forms.TextBox StopMM;
        private System.Windows.Forms.TextBox StartMM;
        private System.Windows.Forms.TextBox HighHumidity;
        private System.Windows.Forms.TextBox LowHumidity;
        private System.Windows.Forms.TextBox StopHH;
        private System.Windows.Forms.TextBox StartHH;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox Selectbox;
    }
}
