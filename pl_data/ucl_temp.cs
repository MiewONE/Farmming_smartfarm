using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using smartfarms;

namespace smartfarm.pl_data
{
    public partial class ucl_temp : UserControl
    {
        private static ucl_temp Instance;
        public static ucl_temp instance
        {
            get
            {
                if (Instance == null) Instance = new ucl_temp();
                return Instance;
            }
        }
        public ucl_temp()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChartArea plot = chart1.ChartAreas[0];
            DateTime[] dateTime = new DateTime[2];

            String[] tfmt = new String[2];
            tfmt[0] = datePickS.Value.ToString("yyyy-MM-dd") + TimePickS.Value.ToString(" HH:mm:ss");
            tfmt[1] = datePickE.Value.ToString("yyyy-MM-dd") + datePickE.Value.ToString(" HH:mm:ss");

            dateTime[0] = DateTime.Parse(tfmt[0]);
            dateTime[1] = DateTime.Parse(tfmt[1]);

            plot.AxisX.Minimum = dateTime[0].ToOADate();
            plot.AxisX.Maximum = dateTime[1].ToOADate();

            plot.AxisY.Minimum = 0;
            plot.AxisY.Maximum = 100;
        }

        private void btnZOOM_Click(object sender, EventArgs e)
        {
            ChartArea plots = chart1.ChartAreas[0];

            plots.AxisX.ScaleView.ZoomReset();

            DateTime[] dateTime = new DateTime[2];

            String[] tFmt = new String[2];
            tFmt[0] = datePickSZ.Value.ToString("yyyy-MM-dd") + TimePickSZ.Value.ToString(" HH:mm:ss");
            tFmt[1] = datePickEZ.Value.ToString("yyyy-MM-dd") + TimePickEZ.Value.ToString(" HH:mm:ss");

            dateTime[0] = DateTime.Parse(tFmt[0]);
            dateTime[1] = DateTime.Parse(tFmt[1]);

            plots.AxisX.ScaleView.Zoom(dateTime[0].ToOADate(), dateTime[1].ToOADate());
            RedrawxLabel(dateTime[0], dateTime[1]);
        }
        private void RedrawxLabel(DateTime dtMin, DateTime dtMax)
        {
            ChartArea plots = chart1.ChartAreas[0];
            TimeSpan dtDiff = dtMax.Subtract(dtMin);
            if (dtDiff.TotalDays > 365)
            {
                plots.AxisX.LabelStyle.Format = "yyyy";
            }
            else if (dtDiff.TotalDays > 30)
            {
                plots.AxisX.LabelStyle.Format = "yyyy-MM";
            }
            else if (dtDiff.TotalDays > 2)
            {
                plots.AxisX.LabelStyle.Format = "yyyy-MM-dd";
            }
            else if (dtDiff.TotalDays < 1)
            {
                plots.AxisX.LabelStyle.Format = "yyyy-MM-dd  HH:mm:ss";
            }

        }

        private void ucl_temp_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            Series temperature = chart1.Series.Add("온도");
            Series humidity = chart1.Series.Add("습도");

            temperature.ChartType = SeriesChartType.Line;
            humidity.ChartType = SeriesChartType.Line;

            MySqlDataReader rd= DB.Instance.query_execute("select * from save_state;");

            //for(double k=0;k<2*Math.PI;k+=0.1)
            //{
            //    temperature.Points.AddXY(k, Math.Sin(k));
            //    humidity.Points.AddXY(k+0.5, Math.Sin(k));
            //}
        }
    }
}
