using System;
using System.Drawing;
using System.Windows.Forms;
using smartfarm.Properties;
using Comfile.ComfilePi;
using System.Collections.Generic;

namespace smartfarm
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();

            pl_humi.Location = new Point(527, 120);
            pl_fan.Location = new Point(527, 320);
            pl_heater.Location = new Point(527, 220);
            pl_inhumi.Location = new Point(2, 314);
            pl_pump.Location = new Point(2, 120);
            pl_temp.Location = new Point(2, 220);
            pb_logo.Location = new Point(300, 230);
            pb_title.Location = new Point(191, 6);
            pb_mode.Location = new Point(300, 62);
            pb_auto.Location = new Point(417, 62);
            pb_setting.Location = new Point(756, 6);
            pb_help.Location = new Point(712, 10);
            pb_logo.Size = new Size(209, 40);
            pl_humi.Size = new Size(273, 100);
            pl_fan.Size = new Size(273, 100);
            pl_heater.Size = new Size(273, 100);
            pl_inhumi.Size = new Size(273, 100);
            pl_pump.Size = new Size(273, 100);
            pl_temp.Size = new Size(273, 100);


            this.Size = new Size(800, 480);
        }

        
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            //_buttons = new Dictionary<bool, PictureBox>();
            //_buttons.Add(GPIO.Output17.IsOn, pb_temp);
            //_buttons.Add(GPIO.Output18.IsOn, pb_humi);
            //_buttons.Add(GPIO.Output19.IsOn, pb_pump);
            //_buttons.Add(GPIO.Output20.IsOn, pb_fan);

            //foreach(var off in GPIO.Outputs)
            //{
            //    off.IsOn = false;
            //}
            //DB에 연결하여 지금 자동 상태인지, 수동상태인지 체크 후 표시 구현중에서는 variable값 참고하여하기
            if (variable.instance.Mode == true)//수동 false, 자동 true
            {
                pb_auto.Image = Resources.수동;
            }
            else
            {
                pb_auto.Image = Resources.자동;
                
            }
            if (variable.instance.temp  ) pb_temp.Image = Resources.btn_on; else pb_temp.Image = Resources.btn_off;
            if (variable.instance.humin ) pb_humi.Image = Resources.btn_on; else pb_humi.Image = Resources.btn_off;
            if (variable.instance.fan   ) pb_fan.Image = Resources.btn_on; else pb_fan.Image = Resources.btn_off;
            if (variable.instance.pump  ) pb_pump.Image = Resources.btn_on; else pb_pump.Image = Resources.btn_off;
            //DB.Instance.DBcon();
            //DB.Instance.DBorTable_Create();
            //DB.Instance.query_execute("select * from setting;", "select");
        }

        private void pb_setting_MouseDown(object sender, MouseEventArgs e)
        {
            pb_setting.Image = Resources.se_1;
        }

        private void pb_setting_MouseUp(object sender, MouseEventArgs e)
        {
            pb_setting.Image = Resources.se_1_2;
            setting.instance.Show();
        }

        private void pb_chageMode_click_MouseDown(object sender, MouseEventArgs e)
        {
            pb_chageMode_click.Image = Resources.Circulation_BT_2;
        }

        private void pb_chageMode_click_MouseUp(object sender, MouseEventArgs e)
        {
            pb_chageMode_click.Image = Resources.Circulation_BT;
            //pb_auto.Image = Resources.
            if(variable.instance.Mode == true)//수동 false, 자동 true
            {
                pb_auto.Image = Resources.수동;
            }
            else
            {
                pb_auto.Image = Resources.자동;
            }
            variable.instance.Mode = !variable.instance.Mode;
        }

        private void Event_mouseDown()
        {

        }

        private void pb_humi_MouseDown(object sender, MouseEventArgs e)
        {
            if(variable.instance.humin)
            {
                pb_humi.Image = Resources.btn_on_mouseDown;
            }
            else
            {
                pb_humi.Image = Resources.btn_off_mouseDown;
            }
        }

        private void pb_humi_MouseUp(object sender, MouseEventArgs e)
        {
            if (variable.instance.humin)
            {
                pb_humi.Image = Resources.btn_off;
                //GPIO.Output17.IsOn = false;
            }
            else
            {
                pb_humi.Image = Resources.btn_on;
                //GPIO.Output17.IsOn = true;
            }
            variable.instance.humin = !variable.instance.humin;
            
        }

        private void pb_temp_MouseDown(object sender, MouseEventArgs e)
        {
            if (variable.instance.temp)
            {
                pb_temp.Image = Resources.btn_on_mouseDown;
            }
            else
            {
                pb_temp.Image = Resources.btn_off_mouseDown;
            }
        }

        private void pb_temp_MouseUp(object sender, MouseEventArgs e)
        {
            if (variable.instance.temp)
            {
                pb_temp.Image = Resources.btn_off;
            }
            else
            {
                pb_temp.Image = Resources.btn_on;
            }
            variable.instance.temp = !variable.instance.temp;
        }

        private void pb_fan_MouseDown(object sender, MouseEventArgs e)
        {
            if (variable.instance.fan)
            {
                pb_fan.Image = Resources.btn_on_mouseDown;
            }
            else
            {
                pb_fan.Image = Resources.btn_off_mouseDown;
            }
        }

        private void pb_fan_MouseUp(object sender, MouseEventArgs e)
        {
            if (variable.instance.fan)
            {
                pb_fan.Image = Resources.btn_off;
            }
            else
            {
                pb_fan.Image = Resources.btn_on;
            }
            variable.instance.fan = !variable.instance.fan;
        }

        private void pb_pump_MouseDown(object sender, MouseEventArgs e)
        {
            if (variable.instance.pump)
            {
                pb_pump.Image = Resources.btn_on_mouseDown;
            }
            else
            {
                pb_pump.Image = Resources.btn_off_mouseDown;
            }
        }

        private void pb_pump_MouseUp(object sender, MouseEventArgs e)
        {
            if (variable.instance.pump)
            {
                pb_pump.Image = Resources.btn_off;
            }
            else
            {
                pb_pump.Image = Resources.btn_on;
            }
            variable.instance.pump = !variable.instance.pump;
        }

        private void pb_logo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                pl_humi.Location+""+
                pl_fan.Location + "" +
                pl_heater.Location + "" +
                pl_inhumi.Location + "" +
                pl_pump.Location + "" +
                pl_temp.Location + "" +
                pb_logo.Location + "" +
                pb_title.Location + "" +
                pb_mode.Location + "" +
                pb_auto.Location + "" +
                pb_setting.Location + "" +
                pb_help.Location);
        }

        private void pb_auto_Click(object sender, EventArgs e)
        {

        }
    }
}
