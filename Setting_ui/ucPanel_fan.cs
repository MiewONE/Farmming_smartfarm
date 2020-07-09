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
    public partial class ucPanel_fan : UserControl
    {
        private static ucPanel_fan Instance;
        public static ucPanel_fan instance
        {
            get
            {
                if(Instance == null)
                {
                    Instance = new ucPanel_fan();
                }
                return Instance;
            }
        }
        public ucPanel_fan()
        {
            InitializeComponent();
        }
    }
}
