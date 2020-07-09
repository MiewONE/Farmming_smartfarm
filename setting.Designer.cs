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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(setting));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pb_fan = new System.Windows.Forms.PictureBox();
            this.pb_pump = new System.Windows.Forms.PictureBox();
            this.pb_humi = new System.Windows.Forms.PictureBox();
            this.pb_temp = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbx_numbers = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb_apply = new System.Windows.Forms.PictureBox();
            this.pb_close = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pl_UIback = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_fan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pump)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_humi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_apply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.pl_UIback.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.pb_fan);
            this.panel3.Controls.Add(this.pb_pump);
            this.panel3.Controls.Add(this.pb_humi);
            this.panel3.Controls.Add(this.pb_temp);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(784, 43);
            this.panel3.TabIndex = 17;
            // 
            // pb_fan
            // 
            this.pb_fan.BackColor = System.Drawing.Color.LightSalmon;
            this.pb_fan.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_fan.Location = new System.Drawing.Point(337, 0);
            this.pb_fan.Margin = new System.Windows.Forms.Padding(0);
            this.pb_fan.Name = "pb_fan";
            this.pb_fan.Size = new System.Drawing.Size(104, 43);
            this.pb_fan.TabIndex = 4;
            this.pb_fan.TabStop = false;
            this.pb_fan.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_fan_MouseUp);
            // 
            // pb_pump
            // 
            this.pb_pump.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.pb_pump.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_pump.Location = new System.Drawing.Point(233, 0);
            this.pb_pump.Margin = new System.Windows.Forms.Padding(0);
            this.pb_pump.Name = "pb_pump";
            this.pb_pump.Size = new System.Drawing.Size(104, 43);
            this.pb_pump.TabIndex = 3;
            this.pb_pump.TabStop = false;
            this.pb_pump.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_pump_MouseUp);
            // 
            // pb_humi
            // 
            this.pb_humi.BackColor = System.Drawing.Color.LightBlue;
            this.pb_humi.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_humi.Location = new System.Drawing.Point(129, 0);
            this.pb_humi.Margin = new System.Windows.Forms.Padding(0);
            this.pb_humi.Name = "pb_humi";
            this.pb_humi.Size = new System.Drawing.Size(104, 43);
            this.pb_humi.TabIndex = 2;
            this.pb_humi.TabStop = false;
            this.pb_humi.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_humi_MouseUp);
            // 
            // pb_temp
            // 
            this.pb_temp.BackColor = System.Drawing.Color.Maroon;
            this.pb_temp.Dock = System.Windows.Forms.DockStyle.Left;
            this.pb_temp.Location = new System.Drawing.Point(25, 0);
            this.pb_temp.Margin = new System.Windows.Forms.Padding(0);
            this.pb_temp.Name = "pb_temp";
            this.pb_temp.Size = new System.Drawing.Size(104, 43);
            this.pb_temp.TabIndex = 1;
            this.pb_temp.TabStop = false;
            this.pb_temp.Click += new System.EventHandler(this.pb_temp_Click);
            this.pb_temp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_temp_MouseUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 43);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // lbx_numbers
            // 
            this.lbx_numbers.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbx_numbers.Font = new System.Drawing.Font("굴림", 40F);
            this.lbx_numbers.FormattingEnabled = true;
            this.lbx_numbers.ItemHeight = 53;
            this.lbx_numbers.Location = new System.Drawing.Point(765, 460);
            this.lbx_numbers.MultiColumn = true;
            this.lbx_numbers.Name = "lbx_numbers";
            this.lbx_numbers.Size = new System.Drawing.Size(111, 57);
            this.lbx_numbers.TabIndex = 15;
            this.lbx_numbers.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pb_apply);
            this.panel1.Controls.Add(this.pb_close);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 81);
            this.panel1.TabIndex = 21;
            // 
            // pb_apply
            // 
            this.pb_apply.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(99)))), ((int)(((byte)(59)))));
            this.pb_apply.Image = ((System.Drawing.Image)(resources.GetObject("pb_apply.Image")));
            this.pb_apply.Location = new System.Drawing.Point(618, 12);
            this.pb_apply.Name = "pb_apply";
            this.pb_apply.Size = new System.Drawing.Size(83, 57);
            this.pb_apply.TabIndex = 2;
            this.pb_apply.TabStop = false;
            // 
            // pb_close
            // 
            this.pb_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(99)))), ((int)(((byte)(59)))));
            this.pb_close.Image = ((System.Drawing.Image)(resources.GetObject("pb_close.Image")));
            this.pb_close.Location = new System.Drawing.Point(703, 11);
            this.pb_close.Name = "pb_close";
            this.pb_close.Size = new System.Drawing.Size(83, 57);
            this.pb_close.TabIndex = 3;
            this.pb_close.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 81);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Controls.Add(this.pl_UIback);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(784, 360);
            this.panel2.TabIndex = 22;
            // 
            // pl_UIback
            // 
            this.pl_UIback.BackColor = System.Drawing.Color.White;
            this.pl_UIback.Controls.Add(this.label1);
            this.pl_UIback.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pl_UIback.Location = new System.Drawing.Point(0, 43);
            this.pl_UIback.Name = "pl_UIback";
            this.pl_UIback.Size = new System.Drawing.Size(784, 317);
            this.pl_UIback.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(629, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.lbx_numbers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "setting";
            this.Text = "setting";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_fan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_pump)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_humi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_temp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_apply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pl_UIback.ResumeLayout(false);
            this.pl_UIback.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pb_fan;
        private System.Windows.Forms.PictureBox pb_pump;
        private System.Windows.Forms.PictureBox pb_humi;
        private System.Windows.Forms.PictureBox pb_temp;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox lbx_numbers;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_apply;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pl_UIback;
        private System.Windows.Forms.Label label1;
    }
}