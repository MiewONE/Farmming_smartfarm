using smartfarm.pl_data;
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
    public partial class data : Form
    {
        private static data Instance;
        public static data instance
        {
            get
            {
                if (Instance == null) Instance = new data();
                return Instance;
            }
        }
        public data()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (ucl_temp.instance.IsDisposed)
            {
                //ucPanel_Water.instance.Show();
                ucl_temp.instance.CreateControl();
            }
            else
            {
                //Se_Water.Image = Resources.pump; //이미지 변경
                if (!pl_graph.Controls.Contains(ucl_temp.instance))
                {
                    pl_graph.Controls.Add(ucl_temp.instance);
                    ucl_temp.instance.Dock = DockStyle.Fill;
                    ucl_temp.instance.BringToFront();
                }
                else
                    ucl_temp.instance.BringToFront();
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Resources.닫기;
            this.Close();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox3.Image = Resources.닫기Push;
        }

        private void data_Load(object sender, EventArgs e)
        {
            if (ucl_temp.instance.IsDisposed)
            {
                //ucPanel_Water.instance.Show();
                ucl_temp.instance.CreateControl();
            }
            else
            {
                //Se_Water.Image = Resources.pump; //이미지 변경
                if (!pl_graph.Controls.Contains(ucl_temp.instance))
                {
                    pl_graph.Controls.Add(ucl_temp.instance);
                    ucl_temp.instance.Dock = DockStyle.Fill;
                    ucl_temp.instance.BringToFront();
                }
                else
                    ucl_temp.instance.BringToFront();
            }
        }
    }
}
