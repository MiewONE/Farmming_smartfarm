﻿namespace smartfarm.Setting_ui
{
    partial class ucPanel_Water
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
            this.StartHH = new System.Windows.Forms.TextBox();
            this.Selectbox = new System.Windows.Forms.ListBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // StartHH
            // 
            this.StartHH.BackColor = System.Drawing.SystemColors.Control;
            this.StartHH.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.StartHH.Location = new System.Drawing.Point(226, 140);
            this.StartHH.Multiline = true;
            this.StartHH.Name = "StartHH";
            this.StartHH.Size = new System.Drawing.Size(58, 42);
            this.StartHH.TabIndex = 39;
            this.StartHH.Text = "0";
            this.StartHH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartHH.Click += new System.EventHandler(this.StartHH_Click);
            this.StartHH.TextChanged += new System.EventHandler(this.StartHH_TextChanged);
            // 
            // Selectbox
            // 
            this.Selectbox.Font = new System.Drawing.Font("굴림", 30F);
            this.Selectbox.FormattingEnabled = true;
            this.Selectbox.ItemHeight = 40;
            this.Selectbox.Location = new System.Drawing.Point(698, 295);
            this.Selectbox.MultiColumn = true;
            this.Selectbox.Name = "Selectbox";
            this.Selectbox.Size = new System.Drawing.Size(68, 4);
            this.Selectbox.TabIndex = 40;
            this.Selectbox.Click += new System.EventHandler(this.Selectbox_Click_1);
            this.Selectbox.SelectedIndexChanged += new System.EventHandler(this.Selectbox_SelectedIndexChanged);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::smartfarm.Properties.Resources.자동2;
            this.pictureBox6.Location = new System.Drawing.Point(64, 94);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 35);
            this.pictureBox6.TabIndex = 41;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::smartfarm.Properties.Resources.pump_period;
            this.pictureBox1.Location = new System.Drawing.Point(64, 135);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(673, 50);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // ucPanel_Water
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.Selectbox);
            this.Controls.Add(this.StartHH);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ucPanel_Water";
            this.Size = new System.Drawing.Size(800, 335);
            this.Load += new System.EventHandler(this.ucPanel_Water_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox StartHH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox Selectbox;
        private System.Windows.Forms.PictureBox pictureBox6;
    }
}
