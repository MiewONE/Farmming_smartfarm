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

        }
    }
}
