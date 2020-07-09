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
    }
}
