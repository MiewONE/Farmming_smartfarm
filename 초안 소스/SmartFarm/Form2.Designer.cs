namespace SFarm
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.picCloseForm = new System.Windows.Forms.PictureBox();
            this.picSetForm = new System.Windows.Forms.PictureBox();
            this.txtHumidity = new System.Windows.Forms.TextBox();
            this.txtTemperature = new System.Windows.Forms.TextBox();
            this.txtEndSS = new System.Windows.Forms.TextBox();
            this.txtEndMM = new System.Windows.Forms.TextBox();
            this.txtEndHH = new System.Windows.Forms.TextBox();
            this.txtStartSS = new System.Windows.Forms.TextBox();
            this.txtStartMM = new System.Windows.Forms.TextBox();
            this.txtStartHH = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtHumidity1 = new System.Windows.Forms.TextBox();
            this.txtTemperature1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picCloseForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // picCloseForm
            // 
            this.picCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("picCloseForm.Image")));
            this.picCloseForm.Location = new System.Drawing.Point(673, 27);
            this.picCloseForm.Name = "picCloseForm";
            this.picCloseForm.Size = new System.Drawing.Size(100, 65);
            this.picCloseForm.TabIndex = 22;
            this.picCloseForm.TabStop = false;
            this.picCloseForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCloseForm_MouseDown);
            this.picCloseForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCloseForm_MouseUp);
            // 
            // picSetForm
            // 
            this.picSetForm.Image = ((System.Drawing.Image)(resources.GetObject("picSetForm.Image")));
            this.picSetForm.Location = new System.Drawing.Point(552, 27);
            this.picSetForm.Name = "picSetForm";
            this.picSetForm.Size = new System.Drawing.Size(100, 64);
            this.picSetForm.TabIndex = 21;
            this.picSetForm.TabStop = false;
            this.picSetForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picSetForm_MouseDown);
            this.picSetForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picSetForm_MouseUp);
            // 
            // txtHumidity
            // 
            this.txtHumidity.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtHumidity.Location = new System.Drawing.Point(96, 391);
            this.txtHumidity.Multiline = true;
            this.txtHumidity.Name = "txtHumidity";
            this.txtHumidity.Size = new System.Drawing.Size(61, 42);
            this.txtHumidity.TabIndex = 20;
            this.txtHumidity.Text = "0";
            this.txtHumidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHumidity.Click += new System.EventHandler(this.txtHumidity_Enter);
            // 
            // txtTemperature
            // 
            this.txtTemperature.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTemperature.Location = new System.Drawing.Point(97, 321);
            this.txtTemperature.Multiline = true;
            this.txtTemperature.Name = "txtTemperature";
            this.txtTemperature.Size = new System.Drawing.Size(61, 42);
            this.txtTemperature.TabIndex = 19;
            this.txtTemperature.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTemperature.Click += new System.EventHandler(this.txtTemperature_Enter);
            // 
            // txtEndSS
            // 
            this.txtEndSS.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEndSS.Location = new System.Drawing.Point(490, 210);
            this.txtEndSS.Multiline = true;
            this.txtEndSS.Name = "txtEndSS";
            this.txtEndSS.Size = new System.Drawing.Size(73, 42);
            this.txtEndSS.TabIndex = 18;
            this.txtEndSS.Text = "0";
            this.txtEndSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEndSS.Click += new System.EventHandler(this.txtEndSS_Enter);
            // 
            // txtEndMM
            // 
            this.txtEndMM.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEndMM.Location = new System.Drawing.Point(339, 210);
            this.txtEndMM.Multiline = true;
            this.txtEndMM.Name = "txtEndMM";
            this.txtEndMM.Size = new System.Drawing.Size(73, 42);
            this.txtEndMM.TabIndex = 17;
            this.txtEndMM.Text = "0";
            this.txtEndMM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEndMM.Click += new System.EventHandler(this.txtEndMM_Enter);
            // 
            // txtEndHH
            // 
            this.txtEndHH.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtEndHH.Location = new System.Drawing.Point(185, 210);
            this.txtEndHH.Multiline = true;
            this.txtEndHH.Name = "txtEndHH";
            this.txtEndHH.Size = new System.Drawing.Size(73, 42);
            this.txtEndHH.TabIndex = 16;
            this.txtEndHH.Text = "0";
            this.txtEndHH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEndHH.Click += new System.EventHandler(this.txtEndHH_Enter);
            // 
            // txtStartSS
            // 
            this.txtStartSS.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStartSS.Location = new System.Drawing.Point(491, 153);
            this.txtStartSS.Multiline = true;
            this.txtStartSS.Name = "txtStartSS";
            this.txtStartSS.Size = new System.Drawing.Size(73, 42);
            this.txtStartSS.TabIndex = 15;
            this.txtStartSS.Text = "0";
            this.txtStartSS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStartSS.Click += new System.EventHandler(this.txtStartSS_Enter);
            // 
            // txtStartMM
            // 
            this.txtStartMM.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStartMM.Location = new System.Drawing.Point(340, 153);
            this.txtStartMM.Multiline = true;
            this.txtStartMM.Name = "txtStartMM";
            this.txtStartMM.Size = new System.Drawing.Size(73, 42);
            this.txtStartMM.TabIndex = 14;
            this.txtStartMM.Text = "0";
            this.txtStartMM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStartMM.Click += new System.EventHandler(this.txtStartMM_Enter);
            // 
            // txtStartHH
            // 
            this.txtStartHH.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtStartHH.Location = new System.Drawing.Point(186, 153);
            this.txtStartHH.Multiline = true;
            this.txtStartHH.Name = "txtStartHH";
            this.txtStartHH.Size = new System.Drawing.Size(73, 42);
            this.txtStartHH.TabIndex = 13;
            this.txtStartHH.Text = "0";
            this.txtStartHH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStartHH.Click += new System.EventHandler(this.txtStartHH_Enter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 480);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.ColumnWidth = 80;
            this.listBox1.Font = new System.Drawing.Font("굴림", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 40;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.listBox1.Location = new System.Drawing.Point(287, 259);
            this.listBox1.MultiColumn = true;
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(478, 204);
            this.listBox1.TabIndex = 23;
            this.listBox1.Visible = false;
            this.listBox1.Click += new System.EventHandler(this.listBox1_Click);
            this.listBox1.Leave += new System.EventHandler(this.listBox1_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(-200, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txtHumidity1
            // 
            this.txtHumidity1.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtHumidity1.Location = new System.Drawing.Point(219, 391);
            this.txtHumidity1.Multiline = true;
            this.txtHumidity1.Name = "txtHumidity1";
            this.txtHumidity1.Size = new System.Drawing.Size(61, 42);
            this.txtHumidity1.TabIndex = 25;
            this.txtHumidity1.Text = "0";
            this.txtHumidity1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHumidity1.Click += new System.EventHandler(this.txtHumidity1_Enter);
            // 
            // txtTemperature1
            // 
            this.txtTemperature1.Font = new System.Drawing.Font("굴림", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtTemperature1.Location = new System.Drawing.Point(219, 321);
            this.txtTemperature1.Multiline = true;
            this.txtTemperature1.Name = "txtTemperature1";
            this.txtTemperature1.Size = new System.Drawing.Size(61, 42);
            this.txtTemperature1.TabIndex = 24;
            this.txtTemperature1.Text = "88";
            this.txtTemperature1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTemperature1.Click += new System.EventHandler(this.txtTemperature1_Enter);
            // 
            // Form2
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.txtHumidity1);
            this.Controls.Add(this.txtTemperature1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.picCloseForm);
            this.Controls.Add(this.picSetForm);
            this.Controls.Add(this.txtHumidity);
            this.Controls.Add(this.txtTemperature);
            this.Controls.Add(this.txtEndSS);
            this.Controls.Add(this.txtEndMM);
            this.Controls.Add(this.txtEndHH);
            this.Controls.Add(this.txtStartSS);
            this.Controls.Add(this.txtStartMM);
            this.Controls.Add(this.txtStartHH);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form2";
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form2_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.picCloseForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSetForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCloseForm;
        private System.Windows.Forms.PictureBox picSetForm;
        private System.Windows.Forms.TextBox txtHumidity;
        private System.Windows.Forms.TextBox txtTemperature;
        private System.Windows.Forms.TextBox txtEndSS;
        private System.Windows.Forms.TextBox txtEndMM;
        private System.Windows.Forms.TextBox txtEndHH;
        private System.Windows.Forms.TextBox txtStartSS;
        private System.Windows.Forms.TextBox txtStartMM;
        private System.Windows.Forms.TextBox txtStartHH;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtHumidity1;
        private System.Windows.Forms.TextBox txtTemperature1;
    }
}