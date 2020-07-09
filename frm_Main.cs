using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smartfarm.Properties;
namespace smartfarm
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();

            pl_humi.Location = new Point(527, 114);
            pl_fan.Location = new Point(527, 314);
            pl_heater.Location = new Point(527, 214);
            pl_inhumi.Location = new Point(2, 314);
            pl_pump.Location = new Point(2, 114);
            pl_temp.Location = new Point(2, 214);
            pb_logo.Location = new Point(300, 230);
            pb_title.Location = new Point(191, 0);
            pb_mode.Location = new Point(300, 56);
            pb_auto.Location = new Point(417, 56);
            pb_usercontrol.Location = new Point(417, 56);

            this.Size = new Size(800, 480);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pb_test.Image = Resources.se_1;
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
    }
}
