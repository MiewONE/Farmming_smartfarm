namespace smartfarm
{
    partial class setting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pl_UIback = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Se_logo = new System.Windows.Forms.PictureBox();
            this.Se_Temp = new System.Windows.Forms.PictureBox();
            this.Se_Humi = new System.Windows.Forms.PictureBox();
            this.Se_Fan = new System.Windows.Forms.PictureBox();
            this.Se_Water = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Se_Title = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Se_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Se_Temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Se_Humi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Se_Fan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Se_Water)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Se_Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.Se_Title);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 81);
            this.panel1.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pl_UIback);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 81);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 399);
            this.panel3.TabIndex = 22;
            // 
            // pl_UIback
            // 
            this.pl_UIback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_UIback.Location = new System.Drawing.Point(0, 64);
            this.pl_UIback.Name = "pl_UIback";
            this.pl_UIback.Size = new System.Drawing.Size(800, 335);
            this.pl_UIback.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Se_logo);
            this.panel2.Controls.Add(this.Se_Temp);
            this.panel2.Controls.Add(this.Se_Humi);
            this.panel2.Controls.Add(this.Se_Fan);
            this.panel2.Controls.Add(this.Se_Water);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 64);
            this.panel2.TabIndex = 21;
            // 
            // Se_logo
            // 
            this.Se_logo.Image = global::smartfarm.Properties.Resources.farmmin1sg1;
            this.Se_logo.Location = new System.Drawing.Point(520, 14);
            this.Se_logo.Name = "Se_logo";
            this.Se_logo.Size = new System.Drawing.Size(209, 40);
            this.Se_logo.TabIndex = 25;
            this.Se_logo.TabStop = false;
            // 
            // Se_Temp
            // 
            this.Se_Temp.Image = global::smartfarm.Properties.Resources.heater;
            this.Se_Temp.Location = new System.Drawing.Point(302, -1);
            this.Se_Temp.Name = "Se_Temp";
            this.Se_Temp.Size = new System.Drawing.Size(100, 64);
            this.Se_Temp.TabIndex = 22;
            this.Se_Temp.TabStop = false;
            // 
            // Se_Humi
            // 
            this.Se_Humi.Image = global::smartfarm.Properties.Resources.humin;
            this.Se_Humi.Location = new System.Drawing.Point(201, 0);
            this.Se_Humi.Name = "Se_Humi";
            this.Se_Humi.Size = new System.Drawing.Size(100, 64);
            this.Se_Humi.TabIndex = 22;
            this.Se_Humi.TabStop = false;
            // 
            // Se_Fan
            // 
            this.Se_Fan.Image = global::smartfarm.Properties.Resources.fan;
            this.Se_Fan.Location = new System.Drawing.Point(101, 0);
            this.Se_Fan.Name = "Se_Fan";
            this.Se_Fan.Size = new System.Drawing.Size(100, 64);
            this.Se_Fan.TabIndex = 22;
            this.Se_Fan.TabStop = false;
            this.Se_Fan.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Se_Fan_MouseDown);
            this.Se_Fan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Se_Fan_MouseUp);
            // 
            // Se_Water
            // 
            this.Se_Water.Image = global::smartfarm.Properties.Resources.pump;
            this.Se_Water.Location = new System.Drawing.Point(1, -1);
            this.Se_Water.Name = "Se_Water";
            this.Se_Water.Size = new System.Drawing.Size(100, 64);
            this.Se_Water.TabIndex = 22;
            this.Se_Water.TabStop = false;
            this.Se_Water.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Se_Water_MouseDown);
            this.Se_Water.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Se_Water_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::smartfarm.Properties.Resources.apply;
            this.pictureBox2.Location = new System.Drawing.Point(573, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::smartfarm.Properties.Resources.close;
            this.pictureBox3.Location = new System.Drawing.Point(673, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseDown);
            this.pictureBox3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox3_MouseUp);
            // 
            // Se_Title
            // 
            this.Se_Title.Image = global::smartfarm.Properties.Resources.환경설정1;
            this.Se_Title.Location = new System.Drawing.Point(30, 12);
            this.Se_Title.Name = "Se_Title";
            this.Se_Title.Size = new System.Drawing.Size(400, 50);
            this.Se_Title.TabIndex = 24;
            this.Se_Title.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 81);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "setting";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Se_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Se_Temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Se_Humi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Se_Fan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Se_Water)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Se_Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel pl_UIback;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox Se_Temp;
        private System.Windows.Forms.PictureBox Se_Humi;
        private System.Windows.Forms.PictureBox Se_Fan;
        private System.Windows.Forms.PictureBox Se_Water;
        private System.Windows.Forms.PictureBox Se_Title;
        private System.Windows.Forms.PictureBox Se_logo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}