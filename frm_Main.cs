using System;
using System.Drawing;
using System.Windows.Forms;
using smartfarm.Properties;
using Comfile.ComfilePi;
using System.Collections.Generic;
using System.ComponentModel;
using System.Timers;
using System.IO;
using System.IO.Ports;
using System.Diagnostics;
using smartfarms;
using System.Threading;

namespace smartfarm
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();

            pl_humi.Location = new Point(527, 120);
            pl_fan.Location = new Point(527, 320);
            pl_heater.Location = new Point(527, 220);
            pl_inhumi.Location = new Point(2, 314);
            pl_pump.Location = new Point(2, 120);
            pl_temp.Location = new Point(2, 220);
            pb_logo.Location = new Point(300, 230);
            pb_title.Location = new Point(191, 6);
            pb_mode.Location = new Point(300, 62);
            pb_auto.Location = new Point(417, 62);
            pb_setting.Location = new Point(756, 6);
            
            pb_logo.Size = new Size(209, 40);
            pl_humi.Size = new Size(273, 100);
            pl_fan.Size = new Size(273, 100);
            pl_heater.Size = new Size(273, 100);
            pl_inhumi.Size = new Size(273, 100);
            pl_pump.Size = new Size(273, 100);
            pl_temp.Size = new Size(273, 100);


            this.Size = new Size(800, 480);

            tbar_humi.Minimum = 0;
            tbar_humi.Maximum = 100;
            tbar_temp.Minimum = 0;
            tbar_temp.Maximum = 100;
            //worker 백그라운드
            //worker = new BackgroundWorker();
            //worker.WorkerReportsProgress = true;
            //worker.WorkerSupportsCancellation = true;
            //worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            //worker.ProgressChanged += new ProgressChangedEventHandler(worker_ProgressChanged);
            //worker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);

            //timer
            //var TmpTimer = new System.Timers.Timer();
            //TmpTimer.Interval = 1000 * 20;
            //TmpTimer.Elapsed += new ElapsedEventHandler(TmpTimer_Elapsed);
            //TmpTimer.Start();
            timer1.Start();
            timer_pump.Interval = (int)variable.instance.Pump_period<1000*60?1000*60*60*24: (int)variable.instance.Pump_period;
            tm_stopwatch.Start();
        }

        #region 백그라운드 
        //void worker_DoWork(object sender, DoWorkEventArgs e)
        //{
            
        //}

        //// Progress 리포트 - UI Thread
        //void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        //{
            
        //}

        //// 작업 완료 - UI Thread
        //void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        //{
        //    // 에러가 있는지 체크
        //    if (e.Error != null)
        //    {
        //        //lblMsg.Text = e.Error.Message;
        //        //MessageBox.Show(e.Error.Message, "Error");
        //        return;
        //    }

        //    //lblMsg.Text = "성공적으로 완료되었습니다";
        //}

        void TmpTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            //variable.instance.temp_value = GPIO.ADC1.Read();
            ////MessageBox.Show("온습도"+GPIO.ADC1.Read().ToString());
            //lb_temp.Text = variable.instance.temp_value.ToString();
        }
        #endregion
        private static DateTime Delay(int MS)
        {
            DateTime ThisMoment = DateTime.Now;
            TimeSpan duration = new TimeSpan(0, 0, 0, 0, MS);
            DateTime AfterWards = ThisMoment.Add(duration);

            while (AfterWards >= ThisMoment)
            {
                System.Windows.Forms.Application.DoEvents();
                ThisMoment = DateTime.Now;
            }

            return DateTime.Now;
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            DB.Instance.DBcon();
            DB.Instance.DBorTable_Create();
            DB.Instance.query_execute("select * from setting;", "select");
            //_buttons = new Dictionary<bool, PictureBox>();
            //_buttons.Add(//GPIO.Output17.IsOn, pb_temp);
            //_buttons.Add(//GPIO.Output18.IsOn, pb_humi);
            //_buttons.Add(//GPIO.Output19.IsOn, pb_pump);
            //_buttons.Add(//GPIO.Output20.IsOn, pb_fan);

            //foreach (var off in GPIO.Outputs)
            //{
            //    off.IsOn = false;
            //}
            //DB에 연결하여 지금 자동 상태인지, 수동상태인지 체크 후 표시 구현중에서는 variable값 참고하여하기
            if (variable.instance.Mode == true)//수동 false, 자동 true
            {
                pb_auto.Image = Resources.자동;
                pictureBox1.Image = Resources.수동Off_자동On;
                panel4.Visible = false;
                panel5.Visible = false;
                
            }
            else
            {
                pb_auto.Image = Resources.수동;
                pictureBox1.Image = Resources.수동On_자동Off;
                panel4.Visible = true;
                panel5.Visible = true;

            }
            if (variable.instance.temp  ) pb_temp.Image = Resources.btn_on; else pb_temp.Image = Resources.btn_off;
            if (variable.instance.humin ) pb_humi.Image = Resources.btn_on; else pb_humi.Image = Resources.btn_off;
            if (variable.instance.fan   ) pb_fan.Image = Resources.btn_on; else pb_fan.Image = Resources.btn_off;
            //if (variable.instance.pump  ) pb_pump.Image = Resources.btn_on; else pb_pump.Image = Resources.btn_off;

            //worker.RunWorkerAsync();
            
        }
         
        private void pb_setting_MouseDown(object sender, MouseEventArgs e)
        {
            pb_setting.Image = Resources.se_1;
        }

        private void pb_setting_MouseUp(object sender, MouseEventArgs e)
        {
            pb_setting.Image = Resources.se_1_2;
            //setting st = new setting();
            //st.Show();
            temp_time.Stop();
            humi_time.Stop();
            setting.instance.ShowDialog();
        }

        private void Event_mouseDown()
        {

        }

        private void pb_humi_MouseDown(object sender, MouseEventArgs e)
        {
            if(variable.instance.humin)
            {
                pb_humi.Image = Resources.btn_on_mouseDown;
            }
            else
            {
                pb_humi.Image = Resources.btn_off_mouseDown;
            }
        }

        private void pb_humi_MouseUp(object sender, MouseEventArgs e)
        {
            if (variable.instance.humin)
            {
                pb_humi.Image = Resources.btn_off;
                GPIO.Output20.IsOn = false;
                //MessageBox.Show("20번 핀 작동");
            }
            else
            {
                pb_humi.Image = Resources.btn_on;
                GPIO.Output20.IsOn = true;
                humi_time.Interval = (int)(
                    (variable.instance.humi_runTimeHH * 60 * 60) + 
                    (variable.instance.humi_runTimeMM * 60) + 
                    (variable.instance.humi_runTimeSS)
                    )<3600?3600: 
                    (int)(
                    (variable.instance.humi_runTimeHH * 60 * 60) + 
                    (variable.instance.humi_runTimeMM * 60) +
                    (variable.instance.humi_runTimeSS)
                    );
                humi_time.Start();
                
                //MessageBox.Show("20번 핀 작동");
                
            }
            variable.instance.humin = !variable.instance.humin;
            
        }

        private void pb_temp_MouseDown(object sender, MouseEventArgs e)
        {
            if (variable.instance.temp)
            {
                pb_temp.Image = Resources.btn_on_mouseDown;
            }
            else
            {
                pb_temp.Image = Resources.btn_off_mouseDown;
            }
        }

        private void pb_temp_MouseUp(object sender, MouseEventArgs e)
        {
            if (variable.instance.temp)
            {
                pb_temp.Image = Resources.btn_off;
                GPIO.Output19.IsOn = false;
                //MessageBox.Show("19번 핀 작동");
            }
            else
            {
                pb_temp.Image = Resources.btn_on;
                GPIO.Output19.IsOn = true;
                temp_time.Interval = (int)(
                    (variable.instance.temp_runTimeHH * 60 * 60) + 
                    (variable.instance.temp_runTimeMM * 60) + 
                    (variable.instance.temp_runTimeSS)
                    )<3600?
                    3600:
                    (int)(
                    (variable.instance.temp_runTimeHH * 60 * 60) +
                    (variable.instance.temp_runTimeMM * 60) +
                    (variable.instance.temp_runTimeSS)
                    );
                temp_time.Start();
                //MessageBox.Show("19번 핀 작동");
            }
            variable.instance.temp = !variable.instance.temp;
        }

        private void pb_fan_MouseDown(object sender, MouseEventArgs e)
        {
            if (variable.instance.fan)
            {
                pb_fan.Image = Resources.btn_on_mouseDown;
                
            }
            else
            {
                pb_fan.Image = Resources.btn_off_mouseDown;
                
            }
            
        }

        private void pb_fan_MouseUp(object sender, MouseEventArgs e)
        {
            if (variable.instance.fan)
            {
                pb_fan.Image = Resources.btn_off;
                GPIO.Output21.IsOn = false;
                //MessageBox.Show("21번 핀 작동");
            }
            else
            {
                pb_fan.Image = Resources.btn_on;
                GPIO.Output21.IsOn = true;
                //MessageBox.Show("21번 핀 작동");
            }
            variable.instance.fan = !variable.instance.fan;
        }

        private void pb_pump_MouseDown(object sender, MouseEventArgs e)
        {
            //if (variable.instance.pump)
            //{
            //    pb_pump.Image = Resources.btn_on_mouseDown;
            //}
            //else
            //{
            //    pb_pump.Image = Resources.btn_off_mouseDown;
            //}
        }

        private void pb_pump_MouseUp(object sender, MouseEventArgs e)
        {
            //if (variable.instance.pump)
            //{
            //    pb_pump.Image = Resources.btn_off;
            //    GPIO.Output22.IsOn = false;
            //}
            //else
            //{
            //    pb_pump.Image = Resources.btn_on;
            //    GPIO.Output22.IsOn = true;
            //}
            //variable.instance.pump = !variable.instance.pump;
        }

        private void pb_logo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pb_auto_Click(object sender, EventArgs e)
        {
            if (variable.instance.Mode == true)//수동 false, 자동 true
            {
                //pb_auto.Image = Resources.수동;
                panel4.Visible = true;
                panel5.Visible = true;

                timer_pump.Stop();
                tm_input.Stop();


            }
            else
            {
                //pb_auto.Image = Resources.자동;
                panel4.Visible = false;
                panel5.Visible = false;

                timer_pump.Interval = (int)variable.instance.Pump_period<1?1000 : (int)variable.instance.Pump_period;
                timer_pump.Start();
                tm_input.Start();


            }
            //variable.instance.Mode = !variable.instance.Mode;
            GPIO.Output19.IsOn = false;
            GPIO.Output20.IsOn = false;
            GPIO.Output21.IsOn = false;
            GPIO.Output22.IsOn = false;
            //MessageBox.Show("19번 핀 작동");
            //MessageBox.Show("20번 핀 작동");
            //MessageBox.Show("21번 핀 작동");
            //MessageBox.Show("22번 핀 작동");
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            //pb_chageMode_click.Image = Resources.Circulation_BT_2;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            //pb_chageMode_click.Image = Resources.Circulation_BT;
            //pb_auto.Image = Resources.
            if (variable.instance.Mode == true)//수동 false, 자동 true
            {
                pictureBox1.Image = Resources.수동On_자동Off;
            }
            else
            {
                pictureBox1.Image = Resources.수동Off_자동On;
            }
            variable.instance.Mode = !variable.instance.Mode;
        }

        private void timer1_Tick(object sender, EventArgs e)//온도 읽어오는 기능
        {
            //입력 데이터 디비에 넣고 디스플레이 출력
            //short tm = 0;
            //float tmF = 0;
            //tm = GPIO.ADC1.Read();
            ////tmF = (float)tm;

            ////tmF = (tmF / 26666 * 100) - 20;

            //variable.instance.temp_value = tm;
            ////variable.instance.temp_value = GPIO.ADC1.Read();
            //////MessageBox.Show("온습도" + GPIO.ADC1.Read().ToString());
            using (StreamReader file = File.OpenText("../tmpHumi.txt"))
            {
                string s = file.ReadToEnd();
                if(s.Length >1 )
                {
                    string[] sp = s.Split(',');
                    variable.instance.temp_value = float.Parse(sp[0]);
                    variable.instance.humi_value = float.Parse(sp[1]);
                }
                
            }
            lb_temp.Text = variable.instance.temp_value.ToString() + "℃";
            lb_humi.Text = variable.instance.humi_value.ToString() + "%";
            if (variable.instance.temp_value != 0 && variable.instance.humi_value != 0)
            {
                DB.Instance.query_execute($"insert into save_state values(" +
                $"{variable.instance.temp_value}," +
                $"{variable.instance.humi_value}," +
                $"{variable.instance.fan}," +
                $"{variable.instance.pump},now());");
            }

        }

        private void pb_graph_Click(object sender, EventArgs e)
        {
            data.instance.ShowDialog();
        }

        private void tbar_temp_ValueChanged(object sender, EventArgs e)
        {
            variable.instance.temp_value = tbar_temp.Value;
            lb_temp.Text = tbar_temp.Value.ToString();
        }

        private void tbar_humi_ValueChanged(object sender, EventArgs e)
        {
            variable.instance.humi_value = tbar_humi.Value;
            lb_humi.Text = tbar_humi.Value.ToString();
        }

        private void tm_input_Tick(object sender, EventArgs e)
        {
            //19 난방기
            //20 가습기
            //21 팬
            //22 펌프
            if (variable.instance.Mode)//true Auto , false manual
            {
                if (variable.instance.temp_value < variable.instance.auto_TempLOW) // 현재 온도가 설정한 최하온도보다 낮으면 
                {
                    
                    variable.instance.temp = true;
                    pb_temper.Image = Resources.히터_ON;
                    GPIO.Output19.IsOn = true; // 난방기 작동
                    //MessageBox.Show("19번 핀 작동");
                }else if(variable.instance.temp_value > variable.instance.auto_TempLOW)
                {
                    variable.instance.temp = false;
                    pb_temper.Image = Resources.히터_OFF;
                    GPIO.Output19.IsOn = false; // 난방기 작동
                    //MessageBox.Show("19번 핀 작동");
                }
                if (variable.instance.temp_value > variable.instance.auto_TempHIGH) // 높으면
                {
                    variable.instance.temp = false;
                    GPIO.Output19.IsOn = false; // 난방기 오프
                    //MessageBox.Show("19번 핀 작동");
                    pb_temper.Image = Resources.히터_OFF;
                    variable.instance.fan = true;
                    GPIO.Output21.IsOn = true; // 팬 작동
                    //MessageBox.Show("21번 핀 작동");
                    pb_pan.Image = Resources.pan_on;
                }
                else
                {
                    variable.instance.temp = true;
                    GPIO.Output19.IsOn = true; // 난방기 오프
                    //MessageBox.Show("19번 핀 작동");
                    pb_temper.Image = Resources.히터_ON;
                    variable.instance.fan = false;
                    GPIO.Output21.IsOn = false; // 팬 작동
                    //MessageBox.Show("21번 핀 작동");
                    pb_pan.Image = Resources.pan_off;
                }
                if (variable.instance.humi_value < variable.instance.auto_HumLOW) // 현재 습도가 설정한 최하습도보다 낮으면
                {
                    variable.instance.humin= true;
                    GPIO.Output20.IsOn = true; // 가습기 작동
                    //MessageBox.Show("20번 핀 작동");
                }
                else
                {
                    variable.instance.humin = false;
                    GPIO.Output20.IsOn = false; // 가습기 작동
                    //MessageBox.Show("20번 핀 작동");
                }
                if (variable.instance.humi_value > variable.instance.auto_HumHIGH) // 높으면
                {
                    variable.instance.humin = false;
                    variable.instance.fan = true;
                    GPIO.Output20.IsOn = false; // 가습기 오프
                    //MessageBox.Show("20번 핀 작동");
                    GPIO.Output21.IsOn = true; // 팬작동
                    //MessageBox.Show("21번 핀 작동");
                }
                else
                {
                    variable.instance.humin = true;
                    variable.instance.fan = false;
                    GPIO.Output20.IsOn = true; // 가습기 오프
                    //MessageBox.Show("20번 핀 작동");
                    GPIO.Output21.IsOn = false; // 팬작동
                    //MessageBox.Show("21번 핀 작동");
                }
                //else
                //{
                //    variable.instance.temp = false;
                //    variable.instance.humin = false;
                //    variable.instance.fan = false;
                //    pb_temper.Image = Resources.히터_OFF;
                //    GPIO.Output20.IsOn = false;
                //    GPIO.Output21.IsOn = false;
                //    GPIO.Output19.IsOn = false;
                //    GPIO.Output22.IsOn = false;
                //}
            }
                
            
        }


        private void timer_pump_Tick(object sender, EventArgs e)
        {
            GPIO.Output22.IsOn = true;
            //MessageBox.Show("22번 핀 작동");
            Thread.Sleep(1000 * 3);
            GPIO.Output22.IsOn = false;
            //MessageBox.Show("22번 핀 작동");
        }

        private void tm_stopwatch_Tick(object sender, EventArgs e)
        {

            //if (variable.instance.temp)
            //{
            //    tbar_temp.Value++;
                
            //}
            //if (variable.instance.humin)
            //{
            //    tbar_humi.Value++;
                
            //}
            ////if(variable.instance.fan)
            ////{
            ////    tbar_temp.Value--;
            ////    tbar_humi.Value--;
            ////}

            //lb_humi_tm.Text = sp.Elapsed.ToString();
            //lb_temp_tm.Text = sp2.Elapsed.ToString();
            //lb_fan_tm.Text = sp3.Elapsed.ToString();

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var tt = GPIO.ADC1.Read();
            ////MessageBox.Show(tt.ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //GPIO.Output19.IsOn = true; // 난방기 작동
            GPIO.Output22.IsOn = true;
            //MessageBox.Show("22번 핀 작동");
            Thread.Sleep(1000 * 3);
            GPIO.Output22.IsOn = false;
            //MessageBox.Show("22번 핀 작동");
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            lb_tbar_humi.Visible = !lb_tbar_humi.Visible;
            lb_tbar_temp.Visible = !lb_tbar_temp.Visible;
            tbar_humi.Visible = !tbar_humi.Visible;
            tbar_temp.Visible = !tbar_temp.Visible;
        }

        private void temp_time_Tick(object sender, EventArgs e)
        {
            if(GPIO.Output19.IsOn)
            {
                variable.instance.temp = false;
                temp_time.Interval = (int)((variable.instance.temp_stoptimeHH * 60 * 60) + (variable.instance.temp_stoptimeHH * 60) + (variable.instance.temp_stoptimeSS));
            }
            else
            {
                variable.instance.temp = true;
                temp_time.Interval = (int)((variable.instance.temp_runTimeHH * 60 * 60) + (variable.instance.temp_runTimeMM * 60) + (variable.instance.temp_runTimeSS));
            }
            GPIO.Output19.IsOn = !GPIO.Output19.IsOn;
        }

        private void humi_time_Tick(object sender, EventArgs e)
        {
            if (GPIO.Output20.IsOn)
            {
                variable.instance.humin = false;
                humi_time.Interval = (int)((variable.instance.humi_stoptimeHH * 60 * 60) + (variable.instance.humi_stoptimeHH * 60) + (variable.instance.humi_stoptimeSS));
            }
            else
            {
                variable.instance.humin = true;
                humi_time.Interval = (int)((variable.instance.humi_runTimeHH * 60 * 60) + (variable.instance.humi_runTimeMM * 60) + (variable.instance.humi_runTimeSS));
            }
            GPIO.Output20.IsOn = !GPIO.Output20.IsOn;
        }
    }
}
