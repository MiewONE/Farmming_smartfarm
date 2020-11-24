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
    
    public partial class ucPanel_temp : UserControl
    {

        TextBox tbx;
        private static ucPanel_temp Instance;
        public static ucPanel_temp instance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new ucPanel_temp();
                }
                return Instance;
            }
        }
        public ucPanel_temp()
        {
            InitializeComponent();
        }

        private void LowTemperature_TextChanged(object sender, EventArgs e)
        {
            setting.instance.lowTemp = Convert.ToInt32(LowTemperature.Text);
        }

        private void HighTemperature_TextChanged(object sender, EventArgs e)
        {
           setting.instance.hightemp  = Convert.ToInt32(HighTemperature.Text);
        }

        private void LowTemperature_Click(object sender, EventArgs e)
        {
            setting_tbx(LowTemperature, 0, 100);
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


        #endregion

        private void HighTemperature_Click(object sender, EventArgs e)
        {
            setting_tbx(HighTemperature, 0, 100);
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

        private void StartMM_Click(object sender, EventArgs e)
        {
            setting_tbx(StartMM, 0, 59);
        }

        private void StartMM_TextChanged(object sender, EventArgs e)
        {
           setting.instance.tempStartMM  = Convert.ToInt32(StartMM.Text);
        }

        private void StartHH_Click(object sender, EventArgs e)
        {
            setting_tbx(StartHH, 0, 23);
        }

        private void StartSS_Click(object sender, EventArgs e)
        {
            setting_tbx(StartSS, 0, 59);
        }

        private void StopHH_Click(object sender, EventArgs e)
        {
            setting_tbx(StopHH, 0, 59);
        }

        private void StopMM_Click(object sender, EventArgs e)
        {
            setting_tbx(StopMM, 0, 59);
        }

        private void StopSS_Click(object sender, EventArgs e)
        {
            setting_tbx(StopSS, 0, 59);
        }

        private void StopHH_TextChanged(object sender, EventArgs e)
        {
           setting.instance.tempStopHH = Convert.ToInt32(StopHH.Text);
        }

        private void StopMM_TextChanged(object sender, EventArgs e)
        {
            setting.instance.tempStopMM = Convert.ToInt32(StopMM.Text);
        }

        private void StopSS_TextChanged(object sender, EventArgs e)
        {
            setting.instance.tempStopSs = Convert.ToInt32(StopSS.Text);
        }

        private void StartHH_TextChanged(object sender, EventArgs e)
        {
            setting.instance.tempStartHH = Convert.ToInt32(StartHH.Text);
        }

        private void StartSS_TextChanged(object sender, EventArgs e)
        {
            setting.instance.tempStartSS = Convert.ToInt32(StartSS.Text);
        }

        private void ucPanel_temp_Load(object sender, EventArgs e)
        {
            StartHH.Text = variable.instance.temp_runTimeHH.ToString();
            StartMM.Text = variable.instance.temp_runTimeMM.ToString();
            StartSS.Text = variable.instance.temp_runTimeSS.ToString();
            StopHH.Text = variable.instance.temp_stoptimeHH.ToString();
            StopMM.Text = variable.instance.temp_stoptimeMM.ToString();
            StopSS.Text = variable.instance.temp_stoptimeSS.ToString();
            HighTemperature.Text = variable.instance.auto_TempHIGH.ToString();
            LowTemperature.Text = variable.instance.auto_TempLOW.ToString();
        }
    }
}
