using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using smartfarms;
namespace smartfarm.pl_data
{
    public partial class ucl_etc : UserControl
    {
        private static ucl_etc Instance;
        public static ucl_etc instance
        {
            get
            {
                if (Instance == null) Instance = new ucl_etc();
                return Instance;
            }
        }
        public ucl_etc()
        {
            InitializeComponent();
        }

        private void ucl_etc_Load(object sender, EventArgs e)
        {
            DB.Instance.dbcon_Open();
            DataSet ds = DB.Instance.getData();
            dgv_data.DataSource = ds.Tables[0];
        }
    }
}
