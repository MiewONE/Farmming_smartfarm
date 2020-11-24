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
using System.IO;

namespace smartfarm.pl_data
{
    public partial class ucl_temp : UserControl
    {
        Series temperature;
        Series humidity;
        List<SeriesChartType> scType_temp = new List<SeriesChartType>();
        List<SeriesChartType> scType_humi = new List<SeriesChartType>();
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
            //ChartArea plot = chart1.ChartAreas[0];
            //DateTime[] dateTime = new DateTime[2];

            //String[] tfmt = new String[2];
            //tfmt[0] = datePickS.Value.ToString("yyyy-MM-dd") + TimePickS.Value.ToString(" HH:mm:ss");
            //tfmt[1] = datePickE.Value.ToString("yyyy-MM-dd") + datePickE.Value.ToString(" HH:mm:ss");

            //dateTime[0] = DateTime.Parse(tfmt[0]);
            //dateTime[1] = DateTime.Parse(tfmt[1]);

            //plot.AxisX.Minimum = dateTime[0].ToOADate();
            //plot.AxisX.Maximum = dateTime[1].ToOADate();

            ////plot.AxisY.Minimum = 0;
            ////plot.AxisY.Maximum = 100;
        }

        private void btnZOOM_Click(object sender, EventArgs e)
        {
            //ChartArea plots = chart1.ChartAreas[0];

            //plots.AxisX.ScaleView.ZoomReset();

            //DateTime[] dateTime = new DateTime[2];

            //String[] tFmt = new String[2];
            //tFmt[0] = datePickSZ.Value.ToString("yyyy-MM-dd") + TimePickSZ.Value.ToString(" HH:mm:ss");
            //tFmt[1] = datePickEZ.Value.ToString("yyyy-MM-dd") + TimePickEZ.Value.ToString(" HH:mm:ss");

            //dateTime[0] = DateTime.Parse(tFmt[0]);
            //dateTime[1] = DateTime.Parse(tFmt[1]);

            //plots.AxisX.ScaleView.Zoom(dateTime[0].ToOADate(), dateTime[1].ToOADate());
            //RedrawxLabel(dateTime[0], dateTime[1]);
        }


        private void ucl_temp_Load(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            temperature = chart1.Series.Add("온도");
            humidity = chart1.Series.Add("습도");

            temperature.ChartType = SeriesChartType.Spline;
            humidity.ChartType = SeriesChartType.Spline;
            comboBox1.Text = temperature.ChartType.ToString();
            comboBox2.Text = humidity.ChartType.ToString();
            List<values> data= DB.Instance.query_execute("select * from save_state;");
            foreach(var datas in data)
            {
                temperature.Points.AddXY(datas.Date, datas.Tempberature);
                humidity.Points.AddXY(datas.Date, datas.Humidity);
            }
            foreach(SeriesChartType tt in Enum.GetValues(typeof(SeriesChartType)))
            {
                if(tt==SeriesChartType.Bar||
                    tt== SeriesChartType.Pie ||
                    tt == SeriesChartType.Doughnut ||
                    tt == SeriesChartType.RangeBar ||
                    tt == SeriesChartType.Radar ||
                    tt == SeriesChartType.Polar ||
                    tt == SeriesChartType.ErrorBar ||
                    tt == SeriesChartType.Renko ||
                    tt == SeriesChartType.Kagi ||
                    tt == SeriesChartType.Pyramid ||
                    tt == SeriesChartType.Funnel ||
                    tt == SeriesChartType.PointAndFigure ||
                    tt == SeriesChartType.StackedBar100 ||
                    tt == SeriesChartType.StackedBar||
                    tt == SeriesChartType.ThreeLineBreak)
                {
                    continue;
                }
                comboBox1.Items.Add(tt);
                comboBox2.Items.Add(tt);
                scType_temp.Add(tt);
                scType_humi.Add(tt);
            }

            timer1.Start();//데이터 실시간으로 추가 기능
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            temperature.Points.Clear();
            humidity.Points.Clear();
            List<values> data = DB.Instance.query_execute("select * from save_state;");
            foreach (var datas in data)
            {
                
                temperature.Points.AddXY(datas.Date, datas.Tempberature);
                humidity.Points.AddXY(datas.Date, datas.Humidity);
            }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            temperature.Enabled = !temperature.Enabled;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            humidity.Enabled = !humidity.Enabled;                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex>=0) temperature.ChartType = scType_temp[comboBox1.SelectedIndex];
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex >= 0) humidity.ChartType = scType_humi[comboBox2.SelectedIndex];
        }

        private void button4_Click_1(object sender, EventArgs e)
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

            //plot.AxisY.Minimum = 0;
            //plot.AxisY.Maximum = 100;
        }
    }
}
