using MSCHART_ZOOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MSCHART_ZOOM
{
    public partial class FormChartTest : Form
    {
        public FormChartTest()
        {
            InitializeComponent();           
        }
        #region Graph Control Test
        /// <summary>
        /// Chart를 컨트롤하기 Context 위한 메뉴
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CharMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Chart grph = (Chart)sender;
                if (grph.ContextMenu == null)
                {
                    MenuItem mnItm;
                    ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();
                    ChartArea plots = grph.ChartAreas[0];                  
                    contextMenu.MenuItems.Add(mnItm = new MenuItem("Zoom-X", OnChartContext));
                    mnItm.Checked = plots.CursorX.IsUserSelectionEnabled;
                    contextMenu.MenuItems.Add(mnItm = new MenuItem("Zoom-Y", OnChartContext));
                    grph.ContextMenu = contextMenu;
                }
            }

        }
        /// <summary>
        /// Context Menu Click Action on Chart
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnChartContext(object sender, EventArgs e)
        {
            ChartArea plots = chartGraph.ChartAreas[0];
            MenuItem mmenuItm = (MenuItem)sender;//메뉴Item text
            switch (mmenuItm.Text)
            {
                case "Zoom-X":
                    {
                        mmenuItm.Checked = !plots.CursorX.IsUserSelectionEnabled;
                        plots.CursorX.IsUserSelectionEnabled = mmenuItm.Checked;
                        plots.CursorX.Interval = trackCursor.Value/100.1;
                    }
                    break;
                case "Zoom-Y":
                    {
                        mmenuItm.Checked = !plots.CursorY.IsUserSelectionEnabled;
                        plots.CursorY.IsUserSelectionEnabled = mmenuItm.Checked;
                    }
                    break;
               
            }
        }
       
        /// <summary>
        /// 시험용 Data를 생성
        /// </summary>
        public void GraphGenerate(Chart grph)
        {
            String intFile = String.Format(@"{0}\{1}",System.Windows.Forms.Application.StartupPath,"Config.ini");           
            String xtxt = IniDll.Readini("Test", "DateTime", DateTime.Now.ToString(), intFile);            
            IniDll.Writeini("Test", "DatCount", numCount.Value.ToString(), intFile);
           
            String item, key;
            #region Default Column and series
            Series[] sers = new Series[2];
            ///////////////////////////////////////////////////
            listView.Clear();
            listView.Columns.Clear();
            listView.Columns.Add("Time", 180);
            listView.Columns.Add("sin", 100);
            listView.Columns.Add("cos", 100);

            ////////////////////////////////////
            grph.Series.Clear(); //default series를 청소한다.  
            sers[0] = grph.Series.Add("sin");
            sers[1] = grph.Series.Add("cos");

            //sers[0].XValueType = ChartValueType.DateTime;
            sers[0].ChartType = SeriesChartType.Line;
            sers[1].ChartType = SeriesChartType.Line;
            #endregion

            DateTime[] dtx;
            double[][] DyArr = new double[2][];
            #region Data Generate
            ////////////////////////////////////////////////////////
            // Make Data
            Random r = new Random();
            DateTime start = DateTime.Parse(xtxt);
            int cnt = (int)numericUpDown1.Value;
            dtx = new DateTime[cnt];
            DyArr[0] = new double[cnt];
            DyArr[1] = new double[cnt];
            for (int i = 0; i < cnt; i++)
            {
                dtx[i] = start.AddMinutes(5*i);
                DyArr[0][i] = Math.Sin(Math.PI * 0.1 * i)*r.Next(-1,100);
                DyArr[1][i] = Math.Cos(Math.PI * 0.1 * i) * r.Next(-10, 50);
            }
            #endregion
            #region Draw Chart 
            sers[0].Points.DataBindXY(dtx, DyArr[0]);
            sers[1].Points.DataBindXY(dtx, DyArr[1]);
            /*for (int i = 0; i < cnt; i++)
            {
                sers[0].Points.AddXY(dtx[i], DyArr[0][i]);
                sers[1].Points.AddXY(dtx[i], DyArr[1][i]);
            } */
            ///////////////////////////////////////
            datePickS.Value = dtx[0];
            datePickE.Value = dtx[cnt-1];
            TimePickerS.Value = dtx[0];
            TimePickE.Value = dtx[cnt - 1];
            ///////////////////////////////////////         
            #endregion
            #region List Draw         
            ListViewItem itm ;
            ListViewItem.ListViewSubItem sItm;          
            for (int i = 0; i < cnt; i++)
            {           
                itm= listView.Items.Add(dtx[i].ToString("yyyy-MM-dd  HH:mm:ss"));
                sItm = itm.SubItems.Add(String.Format("{0:f2}", DyArr[0][i]));
                sItm = itm.SubItems.Add(String.Format("{0:f2}", DyArr[1][i]));
            }           
            #endregion         
        }        
        #endregion

        private void Onload(object sender, EventArgs e)
        {     
            for(int i=0;i< 35; i++)
                combo_ChartType.Items.Add((SeriesChartType)i);

            combo_ChartType.SelectedItem = SeriesChartType.Line;
        }
        /// <summary>
        /// chrt Type change
        /// </summary>
        private void combo_ChartType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (Series sr in chartGraph.Series)
                    sr.ChartType = (SeriesChartType)combo_ChartType.SelectedItem;
            }
            catch (Exception Er)
            {
               MessageBox.Show(string.Format("{0}\r\n{1}", Er.Source, Er.Message));
            }
        }
        /// <summary>
        /// Chart Min Max
        /// </summary>
        private void CLickMINMAX(object sender, EventArgs e)
        {
            ChartArea plots = chartGraph.ChartAreas[0];
            DateTime[] dateTime = new DateTime[2];

            String[] tFmt = new String[2];
            tFmt[0] = datePickS.Value.ToString("yyyy-MM-dd") + TimePickerS.Value.ToString(" HH:mm:ss");
            tFmt[1] = datePickE.Value.ToString("yyyy-MM-dd") + datePickE.Value.ToString(" HH:mm:ss");

            dateTime[0] = DateTime.Parse(tFmt[0]);
            dateTime[1] = DateTime.Parse(tFmt[1]);

            plots.AxisX.Minimum = dateTime[0].ToOADate();
            plots.AxisX.Maximum = dateTime[1].ToOADate();
        }
        /// <summary>
        /// Zoom Range
        /// </summary>
        private void ZOOM(object sender, EventArgs e)
        {
            ChartArea plots = chartGraph.ChartAreas[0];

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
        /// <summary>
        /// Scale Change에 따라 X-Label을 변경
        /// </summary>
        private void RedrawxLabel(DateTime dtMin, DateTime dtMax)
        {
            ChartArea plots = chartGraph.ChartAreas[0];
            TimeSpan dtDiff = dtMax.Subtract(dtMin);
            if (dtDiff.TotalDays > 365)
            {
                plots.AxisX.LabelStyle.Format = "yyyy";
            }
            else  if (dtDiff.TotalDays > 30)
            {
                plots.AxisX.LabelStyle.Format = "yyyy-MM";
            }
            else if (dtDiff.TotalDays>2)
            {
                plots.AxisX.LabelStyle.Format = "yyyy-MM-dd";
            }
            else  if (dtDiff.TotalDays <1)
            {
                plots.AxisX.LabelStyle.Format = "yyyy-MM-dd  HH:mm:ss";
            }

        }
        /// <summary>
        /// Test Data 만들기
        /// </summary>

        private void OnDataGenerate(object sender, EventArgs e)
        {
            GraphGenerate(chartGraph);
        }

        private void TrackChange(object sender, EventArgs e)
        {
            ChartArea plots = chartGraph.ChartAreas[0];

            plots.AxisX.ScaleView.ZoomReset();

            DateTime[] dateTime = new DateTime[2];

            String[] tFmt = new String[2];
            tFmt[0] = datePickS.Value.ToString("yyyy-MM-dd") + TimePickerS.Value.ToString(" HH:mm:ss");
          
            dateTime[0] = DateTime.Parse(tFmt[0]);
            dateTime[1] = dateTime[0];
            dateTime[1] = dateTime[0].AddMinutes(trackBarXZOOM.Value);

            plots.AxisX.ScaleView.Zoom(dateTime[0].ToOADate(), dateTime[1].ToOADate());
            RedrawxLabel(dateTime[0], dateTime[1]);

        }
        /// <summary>
        /// 커스 폭을 조정할 수 있다
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void trackCursor_Scroll(object sender, EventArgs e)
        {
            ChartArea plots = chartGraph.ChartAreas[0];

            plots.CursorX.Interval = trackCursor.Value / 100.0;
            
        }

        private void xIntereval_ValueChanged(object sender, EventArgs e)
        {
            ChartArea plots = chartGraph.ChartAreas[0];
            plots.AxisX.Interval =(double) xIntereval.Value / 10.0 ;
        }

        private void xGridOffest_valuechanged(object sender, EventArgs e)
        {
            ChartArea plots = chartGraph.ChartAreas[0];
            plots.AxisX.IntervalOffset = (double)xgrid_offset.Value ;
        }

        private void xgridMinor_ValueChanged(object sender, EventArgs e)
        {
            ChartArea plots = chartGraph.ChartAreas[0];
            plots.AxisX.MinorGrid.Interval = (double)xgridMinor.Value ;
        }

        private void xGridMajor_ValueChanged(object sender, EventArgs e)
        {
            ChartArea plots = chartGraph.ChartAreas[0];
            plots.AxisX.MajorGrid.Interval = (double)xGridMajor.Value ;
        }
    }

}
