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
    }
}
