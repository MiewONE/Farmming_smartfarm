using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace smartfarm.Setting_ui
{

    public partial class ucPanel_Water : UserControl
    {
        TextBox tbx;
        private static ucPanel_Water Instance;
        public static ucPanel_Water instance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new ucPanel_Water();
                }
                return Instance;
            }
        }
        public ucPanel_Water()
        {
            InitializeComponent();
        }

        private void StartHH_Click(object sender, EventArgs e)
        {
            setting_tbx(StartHH, 0, 100);
        }
        #region SelectBox
        private void setting_tbx(TextBox tb, int _para_Low, int _para_High)
        {
            tbx = tb;
            Selectbox.Items.Clear();
            for (int i = _para_Low; i <= _para_High; i++)
            {
                Selectbox.Items.Add(i);
            }
            Selectbox.Dock = DockStyle.Fill;
            Selectbox.Visible = true;
        }

        private void Selectbox_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbx != null)
                {
                    tbx.Text = this.Selectbox.SelectedItem.ToString();
                    tbx = null;
                }
                Selectbox.Visible = false;
            }
            catch
            {
                MessageBox.Show("숫자를 눌러주시기 바랍니다", "확인");
            }
        }
        #endregion

        private void StartMM_Click(object sender, EventArgs e)
        {
            setting_tbx(StartMM, 0, 100);
        }

        private void StartSS_Click(object sender, EventArgs e)
        {
            setting_tbx(StartSS, 0, 100);
        }

        //private void StopHH_Click(object sender, EventArgs e)
        //{
        //    setting_tbx(StopHH, 0, 100);
        //}

        //private void StopMM_Click(object sender, EventArgs e)
        //{
        //    setting_tbx(StopMM, 0, 100);
        //}

        //private void StopSS_Click(object sender, EventArgs e)
        //{
        //    setting_tbx(StopSS, 0, 100);
        //}

        private void StartHH_TextChanged(object sender, EventArgs e)
        {
            // -- 공급 주기 시간
            //variable.instance.pump = Convert.ToInt32(HighHumidity.Text);
        }

        private void StartMM_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartSS_TextChanged(object sender, EventArgs e)
        {

        }

        private void StopHH_TextChanged(object sender, EventArgs e)
        {

        }

        private void StopMM_TextChanged(object sender, EventArgs e)
        {

        }

        private void StopSS_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
