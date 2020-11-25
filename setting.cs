using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smartfarm.Setting_ui;
using smartfarm.Properties;
using smartfarms;

namespace smartfarm
{
    public partial class setting : Form
    {
        private static setting Instance;
        public int lowTemp { get; set; }
        public int hightemp { get; set; }
        public int tempStartHH { get; set; }
        public int tempStartMM { get; set; }
        public int tempStartSS { get; set; }
        public int tempStopHH { get; set; }
        public int tempStopMM { get; set; }
        public int tempStopSs { get; set; }
        public int lowHumi { get; set; }
        public int highHumi { get; set; }
        public int humiStartHH { get; set; }
        public int humiStartMM { get; set; }
        public int humiStartSS { get; set; }
        public int humiStopHH { get; set; }
        public int humiStopMM { get; set; }
        public int humiStopSs { get; set; }
        public int pumpPeriod { get; set; }
        List<Image> icons = new List<Image>();
        public static setting instance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new setting();
                }
                return Instance;
            }
        }
        public setting()
        {
            InitializeComponent();
            icons.Add(Resources.펌프_bar);
        }


        private void pb_temp_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Test");
            if (!pl_UIback.Controls.Contains(ucPanel_temp.instance))
            {
                pl_UIback.Controls.Add(ucPanel_temp.instance);
                ucPanel_temp.instance.Dock = DockStyle.Fill;
                ucPanel_temp.instance.BringToFront();
            }
            else
                ucPanel_temp.instance.BringToFront();
        }

        private void pb_humi_MouseUp(object sender, MouseEventArgs e)
        {
            if (!pl_UIback.Controls.Contains(ucPanel_Humi.instance))
            {
                pl_UIback.Controls.Add(ucPanel_Humi.instance);
                ucPanel_Humi.instance.Dock = DockStyle.Fill;
                ucPanel_Humi.instance.BringToFront();
            }
            else
                ucPanel_Humi.instance.BringToFront();
        }

        private void pb_pump_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void pb_fan_MouseUp(object sender, MouseEventArgs e)
        {
            if (!pl_UIback.Controls.Contains(ucPanel_fan.instance))
            {
                pl_UIback.Controls.Add(ucPanel_fan.instance);
                ucPanel_fan.instance.Dock = DockStyle.Fill;
                ucPanel_fan.instance.BringToFront();
            }
            else
                ucPanel_fan.instance.BringToFront();
        }

        private void pb_temp_Click(object sender, EventArgs e)
        {
            
        }

        private void Se_Water_MouseDown(object sender, MouseEventArgs e)
        {
            Se_Water.Image = Resources.pump_bar;
            Se_Humi.Image = Resources.humin_bar;
            //Se_Fan.Image = Resources.fan_bar;
            Se_Temp.Image = Resources.heater_bar;
        }

        private void Se_Water_MouseUp(object sender, MouseEventArgs e)
        {
            if(ucPanel_Water.instance.IsDisposed)
            {
                //ucPanel_Water.instance.Show();
                ucPanel_Water.instance.CreateControl();
            }
            else
            {
                Se_Water.Image = Resources.pump;
                if (!pl_UIback.Controls.Contains(ucPanel_Water.instance))
                {
                    pl_UIback.Controls.Add(ucPanel_Water.instance);
                    ucPanel_Water.instance.Dock = DockStyle.Fill;
                    ucPanel_Water.instance.BringToFront();
                }
                else
                    ucPanel_Water.instance.BringToFront();
            }
            
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Resources.닫기Push;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Resources.닫기;
            //ucPanel_fan.instance.Dispose();
            //ucPanel_Humi.instance.Dispose();
            //ucPanel_temp.instance.Dispose();
            //ucPanel_Water.instance.Dispose();

            this.Close();
            //this.Dispose();
            //this.RemoveOwnedForm(this);

            //Instance = null;

        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            
            pictureBox2.Image = Resources.apply;

            variable.instance.auto_TempLOW = this.lowTemp;
            variable.instance.auto_TempHIGH = this.hightemp;
            variable.instance.temp_runTimeMM = this.tempStartHH;
            variable.instance.temp_runTimeHH = this.tempStartMM;
            variable.instance.temp_runTimeSS = this.tempStartSS;
            variable.instance.temp_stoptimeHH = this.tempStopHH;
            variable.instance.temp_stoptimeMM = this.tempStopMM;
            variable.instance.temp_stoptimeSS = this.tempStopSs;
            variable.instance.humi_runTimeHH = this.humiStartHH;
            variable.instance.humi_runTimeMM = this.humiStartMM;
            variable.instance.humi_runTimeSS = this.humiStartSS;
            variable.instance.humi_stoptimeHH = this.humiStopHH;
            variable.instance.humi_stoptimeMM = this.humiStopMM;
            variable.instance.humi_stoptimeSS = this.humiStopSs;
            variable.instance.auto_HumLOW = this.lowHumi;
            variable.instance.auto_HumHIGH = this.highHumi;
            variable.instance.Pump_period = this.pumpPeriod;
            //db 세팅 저장
            DB.Instance.query_execute("update setting set " +
                $"auto_HumLOW = {variable.instance.auto_HumLOW}," +
                $"auto_HumHIGH = {variable.instance.auto_HumHIGH}," +
                $"auto_TempHIGH = {variable.instance.auto_TempHIGH}," +
                $"auto_TempLOW = {variable.instance.auto_TempLOW}," +
                $"temp_runtimeHH ={variable.instance.temp_runTimeHH}," +
                $"temp_runtimeMM ={variable.instance.temp_runTimeMM}," +
                $"temp_runtimeSS ={variable.instance.temp_runTimeSS}," +
                $"temp_stoptimeHH ={variable.instance.temp_stoptimeHH}," +
                $"temp_stoptimeMM ={variable.instance.temp_stoptimeMM}," +
                $"temp_stoptimeSS ={variable.instance.temp_stoptimeSS}," +//te
                $"humi_runtimeHH ={variable.instance.humi_runTimeHH}," +
                $"humi_runtimeMM ={variable.instance.humi_runTimeMM}," +
                $"humi_runtimeSS ={variable.instance.humi_runTimeSS}," +
                $"humi_stoptimeHH ={variable.instance.humi_stoptimeHH}," +
                $"humi_stoptimeMM ={variable.instance.humi_stoptimeMM}," +
                $"humi_stoptimeSS ={variable.instance.humi_stoptimeSS}," +//hu
                //$"water_runtimeHH ={}," +
                //$"water_runtimeMM ={}," +
                //$"water_runtimeSS ={}," +
                //$"water_stoptimeHH ={}," +
                //$"water_stoptimeMM ={}," +
                //$"water_stoptimeSS ={}," +//w
                //$"fan_runtimeHH ={}," +
                //$"fan_runtimeMM ={}," +
                //$"fan_runtimeSS ={}," +
                //$"fan_stoptimeHH ={}," +
                //$"fan_stoptimeMM ={}," +
                //$"fan_stoptimeSS ={}," +//fan
                $"save_period ={variable.instance.save_period}," +
                $"PumP_period ={variable.instance.Pump_period};"+
                $"","insert");
            DB.Instance.query_execute("select * from setting;", "select");
            MessageBox.Show("설정 저장이 완료되었습니다.");
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Resources.apply_push;
        }

        //private void Se_Fan_MouseUp(object sender, MouseEventArgs e)
        //{
        //    Se_Fan.Image = Resources.fan;
        //    if (!pl_UIback.Controls.Contains(ucPanel_fan.instance))
        //    {
        //        pl_UIback.Controls.Add(ucPanel_fan.instance);
        //        ucPanel_fan.instance.Dock = DockStyle.Fill;
        //        ucPanel_fan.instance.BringToFront();
        //    }
        //    else
        //        ucPanel_fan.instance.BringToFront();
        //}

        private void Se_Fan_MouseDown(object sender, MouseEventArgs e)
        {
            Se_Water.Image = Resources.pump_bar;
            Se_Humi.Image = Resources.humin_bar;
            //Se_Fan.Image = Resources.fan_bar;
            Se_Temp.Image = Resources.heater_bar;
        }

        private void Se_Humi_MouseDown(object sender, MouseEventArgs e)
        {
            Se_Water.Image = Resources.pump_bar;
            Se_Humi.Image = Resources.humin_bar;
            //Se_Fan.Image = Resources.fan_bar;
            Se_Temp.Image = Resources.heater_bar;
        }

        private void Se_Humi_MouseUp(object sender, MouseEventArgs e)
        {
            Se_Humi.Image = Resources.humin;
            if (!pl_UIback.Controls.Contains(ucPanel_Humi.instance))
            {
                pl_UIback.Controls.Add(ucPanel_Humi.instance);
                ucPanel_Humi.instance.Dock = DockStyle.Fill;
                ucPanel_Humi.instance.BringToFront();
            }
            else
                ucPanel_Humi.instance.BringToFront();
        }

        private void Se_Temp_MouseDown(object sender, MouseEventArgs e)
        {
            Se_Water.Image = Resources.pump_bar;
            Se_Humi.Image = Resources.humin_bar;
            //Se_Fan.Image = Resources.fan_bar;
            Se_Temp.Image = Resources.heater_bar;
        }

        private void Se_Temp_MouseUp(object sender, MouseEventArgs e)
        {
            Se_Temp.Image = Resources.heater;
            if (!pl_UIback.Controls.Contains(ucPanel_temp.instance))
            {
                pl_UIback.Controls.Add(ucPanel_temp.instance);
                ucPanel_temp.instance.Dock = DockStyle.Fill;
                ucPanel_temp.instance.BringToFront();
            }
            else
                ucPanel_temp.instance.BringToFront();
        }

        private void setting_Load(object sender, EventArgs e)
        {
            //DB.Instance.query_execute("select * from setting", "select");
            if (!pl_UIback.Controls.Contains(ucPanel_temp.instance))
            {
                pl_UIback.Controls.Add(ucPanel_temp.instance);
                ucPanel_temp.instance.Dock = DockStyle.Fill;
                ucPanel_temp.instance.BringToFront();
            }
            else
                ucPanel_temp.instance.BringToFront();
        }
    }
}
