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
namespace smartfarm
{
    public partial class setting : Form
    {
        private static setting Instance;
        public static setting instance
        {
            get
            {
                if(Instance == null)
                {
                    Instance = new setting();
                }
                return Instance;
            }
        }
        public setting()
        {
            InitializeComponent();
        }

        private void pb_temp_MouseUp(object sender, MouseEventArgs e)
        {
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
            if (!pl_UIback.Controls.Contains(ucPanel_Water.instance))
            {
                pl_UIback.Controls.Add(ucPanel_Water.instance);
                ucPanel_Water.instance.Dock = DockStyle.Fill;
                ucPanel_Water.instance.BringToFront();
            }
            else
                ucPanel_Water.instance.BringToFront();
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
    }
}
