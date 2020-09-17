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
            variable.instance.auto_TempLOW = Convert.ToInt32(LowTemperature.Text);
        }

        private void HighTemperature_TextChanged(object sender, EventArgs e)
        {
            variable.instance.auto_TempHIGH = Convert.ToInt32(HighTemperature.Text);
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
    }
}
