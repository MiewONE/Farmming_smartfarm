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
namespace smartfarm
{
    public partial class setting : Form
    {
        private static setting Instance;
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
            Se_Fan.Image = Resources.fan_bar;
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
            //db 신호
            
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox2.Image = Resources.apply_push;
        }

        private void Se_Fan_MouseUp(object sender, MouseEventArgs e)
        {
            Se_Fan.Image = Resources.fan;
            if (!pl_UIback.Controls.Contains(ucPanel_fan.instance))
            {
                pl_UIback.Controls.Add(ucPanel_fan.instance);
                ucPanel_fan.instance.Dock = DockStyle.Fill;
                ucPanel_fan.instance.BringToFront();
            }
            else
                ucPanel_fan.instance.BringToFront();
        }

        private void Se_Fan_MouseDown(object sender, MouseEventArgs e)
        {
            Se_Water.Image = Resources.pump_bar;
            Se_Humi.Image = Resources.humin_bar;
            Se_Fan.Image = Resources.fan_bar;
            Se_Temp.Image = Resources.heater_bar;
        }

        private void Se_Humi_MouseDown(object sender, MouseEventArgs e)
        {
            Se_Water.Image = Resources.pump_bar;
            Se_Humi.Image = Resources.humin_bar;
            Se_Fan.Image = Resources.fan_bar;
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
            Se_Fan.Image = Resources.fan_bar;
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
        }
    }
}
