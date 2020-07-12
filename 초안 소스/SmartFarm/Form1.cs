using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Comfile.ComfilePi;
namespace SFarm
{
    public partial class Form1 : Form
    {
        bool RunTf1 = false, RunTf2 = false;  // 온도
        bool RunHum = false; // 습도
        public Form1()
        {
            InitializeComponent();
            GVar.DefPath = Directory.GetCurrentDirectory();

            FileInfo fileInfo = new FileInfo("/home/pi/Test.txt");
            //FileInfo fileInfo = new FileInfo(GVar.DefPath+@"\Test.txt");
            if (fileInfo.Exists) //파일이 있다
            {
                TxtRead();
            }
            GVar.StartHMSFull = TimeToSec(GVar.StartHH, GVar.StartMM, GVar.StartSS);
            GVar.EndHMSFull = TimeToSec(GVar.EndHH, GVar.EndMM, GVar.EndSS);
            label1.BackColor = Color.Transparent;
            label1.Parent = pictureBox1;
            //label1.BringToFront();
            label6.BackColor = Color.Transparent;
            label6.Parent = pictureBox1;

        }
        public void TxtRead()
        {
            string[] txt = new string[11];
            txt = File.ReadAllLines("/home/pi/Test.txt");
            //txt = File.ReadAllLines(GVar.DefPath+@"\Test.txt");
            GVar.DefPath = txt[0];
            GVar.StartHH = Convert.ToInt16(txt[1]);
            GVar.StartMM = Convert.ToInt16(txt[2]);
            GVar.StartSS = Convert.ToInt16(txt[3]);
            GVar.EndHH = Convert.ToInt16(txt[4]);
            GVar.EndMM = Convert.ToInt16(txt[5]);
            GVar.EndSS = Convert.ToInt16(txt[6]);
            GVar.SetTempLow = Convert.ToInt16(txt[7]);
            GVar.SetTempHigh = Convert.ToInt16(txt[8]);
            GVar.SetHumLow = Convert.ToInt16(txt[9]);
            GVar.SetHumHigh = Convert.ToInt16(txt[10]);

        }
        private void PumLampOnOff(bool Tf)
        {
            if (Tf)
            {
                picOn1.Visible = true;
                picOff1.Visible =false;
            }
            else
            {
                picOn1.Visible = false;
                picOff1.Visible = true;
            }
        }
        private void ColLampOnOff(bool Tf)
        {
            if (Tf)
            {
                picOn2.Visible = true;
                picOff2.Visible = false;
            }
            else
            {
                picOn2.Visible = false;
                picOff2.Visible = true;
            }
        }

        private void MachinePumRunStop(bool Tf) //펌프(습도) 끄기 켜기
        {
            GPIO.Output17.IsOn = Tf;
            

        }
        private void MachineColRunStop(bool Tf) //냉난방 끄기 켜기
        {
            GPIO.Output18.IsOn = Tf;
            
        }

        private void MachineLightRunStop(bool Tf) //형광등 끄기 켜기
        {
            GPIO.Output19.IsOn = Tf;
            
        }
        private void MachineFanRunStop(bool Tf) //냉난방 끄기 켜기
        {
            GPIO.Output20.IsOn = Tf;
           
        }

        private void imgBtnAutoManOn_MouseUp(object sender, MouseEventArgs e)
        {
            imgBtnAutoManOn.Visible = true;
            timer1.Enabled = false;
            Machine.Pump = false;
            Machine.CoolingHeating = false;

            MachinePumRunStop(false); // 펌프을 끈다.
            PumLampOnOff(false);

            MachineColRunStop(false); // 냉난방을 끈다.
            ColLampOnOff(false);
            GVar.TimeSecondCnt = 0; // 다시 처음부터 구동하기 위해서 시간 카운터를 초기화한다.
            GVar.AutoMan++;
            tmrAutoMode.Enabled = false;  // 자동모드 끄기
            if (GVar.AutoMan > 2) GVar.AutoMan = 0;
            if (GVar.AutoMan == 0) txtAutoMan.Text = "수동";
            if (GVar.AutoMan == 1) txtAutoMan.Text = "반자동";
            if (GVar.AutoMan == 2) txtAutoMan.Text = "자동";
            RunStart();
            
        }
        private void RunStart()
        {
            if (GVar.AutoMan == 0) RunStart1Set();
            if (GVar.AutoMan == 1) RunStart2Set();
            if (GVar.AutoMan == 2) RunStart3Set();
        }
        private void RunStart1Set() // 수동
        {
            imgBtnStartOn.Visible = false;
            imgBtnEndOn.Visible = false;
            imgBtnRun1.Visible = true;
            imgBtnStop1.Visible = true;
            imgBtnRun2.Visible = true;
            imgBtnStop2.Visible = true;
        }
        private void RunStart2Set() //반자동
        {
            imgBtnStartOn.Visible = true;
            imgBtnRun1.Visible = false;
            imgBtnStop1.Visible = false;
            imgBtnRun2.Visible = false;
            imgBtnStop2.Visible = false;
            label2.Text = "00:00:00";
            label5.Text = "00:00:00";


        }
        private void RunStart3Set() // 자동
        {
            imgBtnStartOn.Visible = false;
            imgBtnEndOn.Visible = false;
            imgBtnRun1.Visible = false;
            imgBtnStop1.Visible = false;
            imgBtnRun2.Visible = false;
            imgBtnStop2.Visible = false;
            tmrAutoMode.Enabled = true;  // 자동모드 동작함
            GVar.SetTempRuning = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            GVar.TimeSecondCnt++;
            
            // if (GVar.AutoMan == 0) RunStart1();  // 수동에셔는 필요없음.
            if (GVar.AutoMan == 1) RunStart2();
            
            
        }
        private void RunStart2()  // 반자동
        {
            // 반자동에서 시간보고 On.Off 시킴
            string h ="", m="", s="";
            SecToTimeCnt(ref h, ref m, ref s);
            if (h.Length == 1) h = "0" + h;
            if (m.Length == 1) m = "0" + m;
            if (s.Length == 1) s = "0" + s;

            if (Machine.Pump)
            {
                label2.Text =string.Format( h + ":" + m + ":" + s);
                if (GVar.StartHMSFull<=GVar.TimeSecondCnt)  // 가동시간이 완료되면
                {
                    GVar.TimeSecondCnt = 0; // 정지시간을 다시 카운터하기 위해서
                    MachinePumRunStop(false); //펌프를 끈다
                    PumLampOnOff(false);
                    MachineColRunStop(false); //냉난방을 끈다
                    ColLampOnOff(false);
                    Machine.Pump = false;
                }
            }
            else
            {
                label5.Text = h + ":" + m + ":" + s;
                if (GVar.EndHMSFull <= GVar.TimeSecondCnt)  // 정지시간이 완료되면
                {
                    GVar.TimeSecondCnt = 0; // 가동시간을 다시 카운터하기 위해서
                    MachinePumRunStop(true); //펌프 켠다
                    PumLampOnOff(true);
                    MachineColRunStop(true); //냉난방  켠다
                    ColLampOnOff(true);

                    Machine.Pump = true;
                }
            }
        }
        private void tmrAutoMode_Tick(object sender, EventArgs e)
        {  //자동모드
            if (GVar.AutoMan == 2) RunStart3();
        }
        private void RunStart3()  //자동
        {
            
            //// 테스트를 위해 아래 2개의 라인을 임시로 넣고 테스트 완료후 삭제한다.
            //GVar.SetTempNowRead = vScrollBar1.Value;  //온도 임시 읽었다고 가설정함
            //GVar.SetHumNowRead = vScrollBar2.Value; //습도 임시 읽었다고 가설정함
            //// 여기까지 반듯이 삭세할것


            
            if(GVar.SetTempNowRead < GVar.SetTempLow-3) // 현재 온도가 설정온도 최하 온도 이하인가
            {
                
                if (GVar.SetTempRuning==false) // 온도 조정중이 아니면
                {
                   
                    GVar.SetTempRuning = true;
                    //GVar.SetTempButton = true;
                    //GVar.SetTempTop = false;
                    RunTf1 = true;
                    MachineColRunStop(true);
                }
            }
            if (GVar.SetTempNowRead > GVar.SetTempHigh+3) // 현재 온도가 설정온도 최고 온도 이상 올라갔다
            {
               
                if (GVar.SetTempRuning==false) // 온도 조정중이 아니면
                {
                   
                    GVar.SetTempRuning = true;
                    //GVar.SetTempButton = false;
                    //GVar.SetTempButton = true;
                    RunTf2 = true;
                    MachineColRunStop(true);
                }
            }
            if(RunTf1)
            {
                if (GVar.SetTempNowRead >= GVar.SetTempHigh-3)  // 최하 온도에서 가동해서 최고 온도에 도달하면 끄준다
                {
                    MachineColRunStop(false);
                    GVar.SetTempRuning = false;
                    RunTf1 = false;
                }
            }
            if (RunTf2)
            {
                if (GVar.SetTempNowRead <= GVar.SetTempLow)  // 최상 온도에서 가동해서 최하 온도에 도달하면 끄준다
                {
                    MachineColRunStop(false);
                    GVar.SetTempRuning = false;
                    RunTf2 = false;
                }
            }
            if(GVar.SetHumNowRead<GVar.SetHumLow)  //습도가 설정된 최하 습도 이하인가
            {
                MachinePumRunStop(true);
            }
            if (GVar.SetHumNowRead >= GVar.SetHumHigh)  //습도가 설정된 최고에 도달했는가
            {
                MachinePumRunStop(false);
            }

        }
        private uint TimeToSec(int HH, int MM, int SS)
        {
            //시분초를 초로 환산한다.
            uint Thap;
            Thap = (uint)(HH * 3600 + MM * 60 + SS);
            return Thap;
        }
        private void SecToTimeCnt(ref string HH, ref string MM, ref string SS)
        {  // 경과한 초를 시분초로 환산한다.
            int h, m, s;

            h = (int)GVar.TimeSecondCnt / 3600;
            m = (GVar.TimeSecondCnt - (h * 3600)) / 60;
            s = (GVar.TimeSecondCnt - (h * 3600) - (m * 60));
            HH = h.ToString();
            MM = m.ToString();
            SS = s.ToString();

        }
        private void imgBtnStartOn_Click(object sender, EventArgs e)
        {
            GVar.StartHMSFull = TimeToSec(GVar.StartHH, GVar.StartMM, GVar.StartSS);
            GVar.EndHMSFull = TimeToSec(GVar.EndHH, GVar.EndMM, GVar.EndSS);
            imgBtnStartOn.Visible = false;
            imgBtnEndOn.Visible = true;
            GVar.RunStart = true;
            timer1.Enabled = false;
            GVar.TimeSecondCnt = 0;
            MachinePumRunStop(true); // LED 펌프 켠다.
            PumLampOnOff(true);
            MachineColRunStop(true); // LED 냉난방 켠다.
            ColLampOnOff(true);
            Machine.Pump = true;
            timer1.Enabled = true;
            
            //txtRunTimeCnt.Text = "01:02:45" + "\r\n" + "00:00:50";
        }

        private void imgBtnEndOn_Click(object sender, EventArgs e)
        {
            imgBtnStartOn.Visible = true;
            imgBtnEndOn.Visible = false;
            GVar.RunStart = false;
            timer1.Enabled = false;
            MachinePumRunStop(false);  // 펌프, 냉난방 끈다.
            PumLampOnOff(false);
            MachineColRunStop(false);  // 펌프, 냉난방 끈다.
            ColLampOnOff(false);
            Machine.Pump = false;
            timer1.Enabled = false;
            
        }

        private void imgBtnCfgOn_MouseDown(object sender, MouseEventArgs e)
        {
            imgBtnCfgOn.Visible = false;

        }
        private void imgBtnCfgOn_MouseUp(object sender, MouseEventArgs e)
        {
            imgBtnCfgOn.Visible = true;
            Form2 form2 = new Form2();
            form2.Show();

            // 가동시간과 정지시간이 변경 될 수 있어 무조건 다시 계산한다.
            GVar.StartHMSFull = TimeToSec(GVar.StartHH, GVar.StartMM, GVar.StartSS);
            GVar.EndHMSFull = TimeToSec(GVar.EndHH, GVar.EndMM, GVar.EndSS);
        }

        

        private void imgBtnAutoManOn_MouseDown(object sender, MouseEventArgs e)
        {
            imgBtnAutoManOn.Visible = false;
            txtAutoMan.Text = "";
        }



        private void imgBtnRun1_MouseUp(object sender, MouseEventArgs e)
        {
            imgBtnRun1.Visible = false;
            imgBtnStop1.Visible = true;
            MachinePumRunStop(true); //펌프 켠다
            PumLampOnOff(true);

        }

        private void imgBtnStop1_MouseUp(object sender, MouseEventArgs e)
        {
            imgBtnRun1.Visible = true;
            imgBtnStop1.Visible = false;
            MachinePumRunStop(false); //펌프 끈다
            PumLampOnOff(false);
        }
        private void imgBtnRun2_MouseUp(object sender, MouseEventArgs e)
        {
            imgBtnRun2.Visible = false;
            imgBtnStop2.Visible = true;
            MachineColRunStop(true); //냉난방 켠다
            ColLampOnOff(true);
        }

        private void imgBtnStop2_MouseUp(object sender, MouseEventArgs e)
        {
            imgBtnRun2.Visible = true;
            imgBtnStop2.Visible = false;
            MachineColRunStop(false); //냉난방 끈다
            ColLampOnOff(false);
        }


        private void Btn_On_OnMode1_Click(object sender, EventArgs e)
        {
            Btn_On_OnMode1.Visible = false;
            Btn_Off_OnMode1.Visible = true;
            GVar.LightTf = false;
            MachineLightRunStop(false);

        }

        private void Btn_Off_OnMode1_Click(object sender, EventArgs e)
        {
            Btn_On_OnMode1.Visible = true;
            Btn_Off_OnMode1.Visible = false;
            GVar.LightTf = true;
            MachineLightRunStop(true);
        }
        private void Btn_On_OnMode2_Click(object sender, EventArgs e)
        {
            Btn_On_OnMode2.Visible = false;
            Btn_Off_OnMode2.Visible = true;
            GVar.FanTf = false;
            MachineFanRunStop(false);
        }

        private void Btn_Off_OnMode2_Click(object sender, EventArgs e)
        {
            Btn_On_OnMode2.Visible = true;
            Btn_Off_OnMode2.Visible = false;
            GVar.FanTf = true;
            MachineFanRunStop(true);
        }

        private void TxtEdit()
        {
            string[] txt = new string[11];
            txt[0] = GVar.DefPath;
            txt[1] = GVar.StartHH.ToString();
            txt[2] = GVar.StartMM.ToString();
            txt[3] = GVar.StartSS.ToString();
            txt[4] = GVar.EndHH.ToString();
            txt[5] = GVar.EndMM.ToString();
            txt[6] = GVar.EndSS.ToString();
            txt[7] = GVar.SetTempLow.ToString();
            txt[8] = GVar.SetTempHigh.ToString();
            txt[9] = GVar.SetHumLow.ToString();
            txt[10] = GVar.SetHumHigh.ToString();

            int count;
            count = txt.Length;
            StreamWriter sw = new StreamWriter(GVar.DefPath + @"\Test.txt", false);  //true:추가 false:덮으쓰기
            //for (int i = 0; i < count; i++)
            //{
            //    sw.WriteLine(txt[i]);
            //}
            //sw.WriteLine(txtRevisionNext.Text);
            for (int i = 0; i < count; i++)
            {
                sw.WriteLine(txt[i]);
            }
            sw.Close();

        }


        private void CtlLocate()
        {
            imgBtnStartOn.Location = new Point(19, 198);
            imgBtnEndOn.Location = new Point(19, 273);
            Btn_On_OnMode1.Location = new Point(360, 201);
            Btn_On_OnMode2.Location = new Point(438, 202);
            Btn_Off_OnMode1.Location = new Point(358, 274);
            Btn_Off_OnMode2.Location = new Point(436, 274);

            imgBtnRun1.Location = new Point(167, 379);
            imgBtnRun2.Location = new Point(253, 379);
            imgBtnStop1.Location = new Point(167, 379);
            imgBtnStop2.Location = new Point(253, 379);
            imgBtnAutoManOn.Location = new Point(547, 382);
            imgBtnAutoManOff.Location = new Point(547, 382);
            imgBtnCfgOn.Location = new Point(665, 382);
            imgBtnCfgOff.Location = new Point(665, 382);
            label2.Location = new Point(540, 196);
            label2.Size = new Size(147, 53);
            label5.Location = new Point(540, 291);
            label5.Size = new Size(147, 53);

            label1.Location = new Point(606, 30);
            label1.Size = new Size(159, 29);
            label6.Location = new Point(606, 60);
            label6.Size = new Size(159, 29);

            label4.Location = new Point(698, 196);
            label4.Size = new Size(83,53);
            label3.Location = new Point(698, 291);
            label3.Size = new Size(83, 53);
            txtAutoMan.Location = new Point(157, 102);
            txtAutoMan.Size = new Size(150, 42);

            picOn1.Location = new Point(175, 201);
            picOff1.Location = new Point(175, 275);
            picOn2.Location = new Point(258, 200);
            picOff2.Location = new Point(258, 274);

            picOn1.Size = new Size(58, 54);
            picOn2.Size = new Size(58, 54);

            picOff1.Size = new Size(58, 54);
            picOff2.Size = new Size(58, 54);
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Size = new Size(800, 480);
            this.Size = new Size(800, 480);
            label7.Location = new Point(772, 21);
            label7.Size = new Size(11, 73);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            CtlLocate();
            timer3_Tick(sender, e);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            // 온습도를 500ms 마다 갱신한다.
            
            short tm1=0, tm2=0;
            float s1,s2,t1,t2;
            //tm1 = GPIO.ADC1.Read();
            //tm2 = GPIO.ADC2.Read();
            t1 = (float)tm1;
            t2 = (float)tm2;

            s1 = (t1 / 26666 * 100) - 20;
            s2= t2/ 26666 * 100;

            //
            GVar.SetTempNowRead = s1;
            GVar.SetHumNowRead = s2;
            label4.Text = s1.ToString();
            label3.Text = s2.ToString();



        }

        private void timer3_Tick(object sender, EventArgs e)
        {
             // 날짜와 시간을 갱신한다.
            label1.Text= String.Format(@"{0:yyyy.MM.dd}", DateTime.Now);
            label6.Text= String.Format(@"{0:tt hh:mm:ss}", DateTime.Now); // 오전 01:47:33
        }

        private void label7_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a=9;
            a = ab(a);
        }
        int ab(int a)
        {
            return a + 1;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MachinePumRunStop(false);
            MachineColRunStop(false);
        }

        
    }
}
