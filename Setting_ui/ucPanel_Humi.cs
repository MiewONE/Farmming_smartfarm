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
    public partial class ucPanel_Humi : UserControl
    {
        TextBox tbx;
        private static ucPanel_Humi Instance;
        public static ucPanel_Humi instance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new ucPanel_Humi();
                }
                return Instance;
            }
        }
        public ucPanel_Humi()
        {
            InitializeComponent();
        }

        private void ucPanel_Humi_Load(object sender, EventArgs e)
        {
            Selectbox.Visible = false;
            StartHH.Text = variable.instance.humi_runTimeHH.ToString();
            StartMM.Text = variable.instance.humi_runTimeMM.ToString();
            StartSS.Text = variable.instance.humi_runTimeSS.ToString();

            StopHH.Text = variable.instance.humi_stoptimeHH.ToString();
            StopMM.Text = variable.instance.humi_stoptimeMM.ToString();
            StopSS.Text = variable.instance.humi_stoptimeSS.ToString();

            LowHumidity.Text = variable.instance.auto_HumLOW.ToString();
            HighHumidity.Text = variable.instance.auto_HumHIGH.ToString();
        }

        private void StartHH_TextChanged(object sender, EventArgs e)
        {
            //DB.Instance.query_execute($"update setting set humi_runTimeHH = {StartHH.Text};");
            setting.instance.humiStartHH = Convert.ToInt32(StartHH.Text);
        }

        private void StartMM_TextChanged(object sender, EventArgs e)
        {
            setting.instance.humiStartMM = Convert.ToInt32(StartMM.Text);
        }

        private void StartSS_TextChanged(object sender, EventArgs e)
        {
           setting.instance.humiStartSS  = Convert.ToInt32(StartSS.Text);
        }

        private void StopHH_TextChanged(object sender, EventArgs e)
        {
            setting.instance.humiStopHH = Convert.ToInt32(StopHH.Text);
        }

        private void StopMM_TextChanged(object sender, EventArgs e)
        {
            setting.instance.humiStopMM= Convert.ToInt32(StopMM.Text);
        }

        private void StopSS_TextChanged(object sender, EventArgs e)
        {
            setting.instance.humiStopSs = Convert.ToInt32(StopSS.Text);
        }

        private void LowHumidity_TextChanged(object sender, EventArgs e)
        {
            setting.instance.lowHumi = Convert.ToInt32(LowHumidity.Text);
        }

        private void HighHumidity_TextChanged(object sender, EventArgs e)
        {
            setting.instance.highHumi = Convert.ToInt32(HighHumidity.Text);
        }

        private void StartHH_Click(object sender, EventArgs e)
        {
            setting_tbx(StartHH,0, 24);
            
        }
        private void StartMM_Click(object sender, EventArgs e)
        {
            setting_tbx(StartMM, 0, 59);
        }

        private void StartSS_Click(object sender, EventArgs e)
        {
            setting_tbx(StartSS, 0, 59);
        }

        private void StopHH_Click(object sender, EventArgs e)
        {
            setting_tbx(StopHH, 0, 24);
        }

        private void StopMM_Click(object sender, EventArgs e)
        {
            setting_tbx(StopMM, 0, 59);
        }

        private void StopSS_Click(object sender, EventArgs e)
        {
            setting_tbx(StopSS, 0, 59);
        }

        private void LowHumidity_Click(object sender, EventArgs e)
        {
            setting_tbx(LowHumidity, 0, 100);
        }

        private void HighHumidity_Click(object sender, EventArgs e)
        {
            setting_tbx(HighHumidity, 0, 100);
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
    }
}
