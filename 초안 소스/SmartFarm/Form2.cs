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
namespace SFarm
{
    public partial class Form2 : Form
    {
        int listInx = -1;
        public Form2()
        {
            InitializeComponent();
        }
        private void CtlLocate()
        {
            picSetForm.Location = new Point(552, 27);
            picCloseForm.Location = new Point(673, 27);
            picSetForm.Size = new Size(100, 65);
            picCloseForm.Size = new Size(100, 65);


        }
        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                Close();
            }
        }



        private void picSetForm_MouseDown(object sender, MouseEventArgs e)
        {
            picSetForm.Visible = false;
        }

        private void picSetForm_MouseUp(object sender, MouseEventArgs e)
        {
            picSetForm.Visible = true;

            GVar.StartHH = Convert.ToInt16(txtStartHH.Text);
            GVar.StartMM = Convert.ToInt16(txtStartMM.Text);
            GVar.StartSS = Convert.ToInt16(txtStartSS.Text);

            GVar.EndHH = Convert.ToInt16(txtEndHH.Text);
            GVar.EndMM = Convert.ToInt16(txtEndMM.Text);
            GVar.EndSS = Convert.ToInt16(txtEndSS.Text);
            GVar.SetTempLow = Convert.ToInt16(txtTemperature.Text);
            GVar.SetTempHigh = Convert.ToInt16(txtTemperature1.Text);

            GVar.SetHumLow = Convert.ToInt16(txtHumidity.Text);
            GVar.SetHumHigh = Convert.ToInt16(txtHumidity1.Text);

            if (GVar.StartSS + GVar.StartHH + GVar.StartMM == 0)
            {
                MessageBox.Show("가동시간이 '0' 이 될수 없습니다!", "확인");
                return;
            }
            if (GVar.EndSS + GVar.EndHH + GVar.EndMM == 0)
            {
                MessageBox.Show("정지시간이 '0' 이 될수 없습니다!", "확인");
                return;
            }

            if (GVar.SetTempLow >= GVar.SetTempHigh)
            {
                MessageBox.Show("앞에 온도가 뒤에 온도 보다 작거나 같을 수 없습니다", "온도 설정 확인");
                return;
            }

            if (GVar.SetTempLow < 5 || GVar.SetTempHigh > 38)
            {
                MessageBox.Show("온도 범위는 5도 ~ 38도입니다.", "온도 범위 확인");
                return;
            }
            if (GVar.SetHumLow >= GVar.SetHumHigh )
            {
                MessageBox.Show("앞에 습도가 뒤에 습도 보다 작거나 같을 수 없습니다", "습도 설정 확인");
                return;
            }
            if (GVar.SetHumLow < 50 || GVar.SetHumHigh > 88)
            {
                MessageBox.Show("습도 범위는 50% ~ 88%입니다.", "습도 범위 확인");
                return;
            }

            GVar.SetOk = true;
            GVar.StartHH = Convert.ToInt16(txtStartHH.Text);
            GVar.StartMM = Convert.ToInt16(txtStartMM.Text);
            GVar.StartSS = Convert.ToInt16(txtStartSS.Text);
            GVar.EndHH = Convert.ToInt16(txtEndHH.Text);
            GVar.EndMM = Convert.ToInt16(txtEndMM.Text);
            GVar.EndSS = Convert.ToInt16(txtEndSS.Text);
            GVar.SetTempLow = Convert.ToInt16(txtTemperature.Text);
            GVar.SetTempHigh = Convert.ToInt16(txtTemperature1.Text);
            GVar.SetHumLow = Convert.ToInt16(txtHumidity.Text);
            GVar.SetHumHigh = Convert.ToInt16(txtHumidity1.Text);
            TxtWrite();
            Close();
            
        }

        private void picCloseForm_MouseDown(object sender, MouseEventArgs e)
        {
            picCloseForm.Visible = false;
        }

        private void picCloseForm_MouseUp(object sender, MouseEventArgs e)
        {
            picCloseForm.Visible = true;
            Close();
        }

        private void txtStartHH_Enter(object sender, EventArgs e)
        {
            //txtStartHH.SelectAll();
            listInx = 1;
            listBox1.ColumnWidth = 100;
            ListNumAdd(0, 23);
            //listBox1.Location = new Point(63, 258);

            listBox1.Focus();
        }
        private void txtStartMM_Enter(object sender, EventArgs e)
        {
            listInx = 2;
            listBox1.ColumnWidth = 80;
            ListNumAdd(0, 59);
            //listBox1.Location = new Point(63, 258);
            listBox1.Focus();
        }
        private void txtStartSS_Enter(object sender, EventArgs e)
        {
            listInx = 3;
            listBox1.ColumnWidth = 80;
            ListNumAdd(0, 59);
            //listBox1.Location = new Point(63, 258);
            listBox1.Focus();
        }

        private void txtEndHH_Enter(object sender, EventArgs e)
        {
            listInx = 4;
            listBox1.ColumnWidth = 100;
            ListNumAdd(0, 23);
            //listBox1.Location = new Point(63, 258);
            listBox1.Focus();
        }
        private void txtEndMM_Enter(object sender, EventArgs e)
        {
            listInx = 5;
            listBox1.ColumnWidth = 80;
            ListNumAdd(0, 59);
            //listBox1.Location = new Point(63, 258);
            listBox1.Focus();
        }
        private void txtEndSS_Enter(object sender, EventArgs e)
        {
            listInx = 6;
            listBox1.ColumnWidth = 80;
            ListNumAdd(0, 59);
            //listBox1.Location = new Point(63, 258);
            listBox1.Focus();
        }
        private void ListNumAdd(int st,int ed)
        {
            listBox1.Visible = false;
            listBox1.Items.Clear();
            for(int i=st;i<=ed;i++)
            {
                listBox1.Items.Add(i.ToString());
            }
            listBox1.Visible = true;
        }
        private void txtTemperature_Enter(object sender, EventArgs e)
        {
            
            listInx = 7;
            listBox1.ColumnWidth = 80;
            ListNumAdd(5, 38);

            //listBox1.Location = new Point(66, 151);
            listBox1.Focus();
        }
        private void txtTemperature1_Enter(object sender, EventArgs e)
        {
            listInx = 8;
            listBox1.ColumnWidth = 80;
            ListNumAdd(5, 38);

            //listBox1.Location = new Point(66, 151);
            listBox1.Focus();
        }
        private void txtHumidity_Enter(object sender, EventArgs e)
        {
            listInx = 9;
            listBox1.ColumnWidth = 80;
            ListNumAdd(50, 88);
            //listBox1.Location = new Point(66, 151);
            listBox1.Focus();
        }
        private void txtHumidity1_Enter(object sender, EventArgs e)
        {
            listInx = 10;
            listBox1.ColumnWidth = 80;
            ListNumAdd(50, 88);
            //listBox1.Location = new Point(66, 151);
            listBox1.Focus();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {

            txtStartHH.Text = GVar.StartHH.ToString();
            txtStartMM.Text = GVar.StartMM.ToString();
            txtStartSS.Text = GVar.StartSS.ToString();
            txtEndHH.Text = GVar.EndHH.ToString();
            txtEndMM.Text = GVar.EndMM.ToString();
            txtEndSS.Text = GVar.EndSS.ToString();
            txtTemperature.Text = GVar.SetTempLow.ToString();
            txtTemperature1.Text = GVar.SetTempHigh.ToString();
            txtHumidity.Text = GVar.SetHumLow.ToString();
            txtHumidity1.Text = GVar.SetHumHigh.ToString();
        }
    

        private void listBox1_Leave(object sender, EventArgs e)
        {
            listBox1.Visible = false;
        }

        private void listBox1_Click(object sender, EventArgs e)
        {
            string st= listBox1.SelectedItem.ToString(); 
            switch(listInx)
            {
                case 1:
                    txtStartHH.Text = st;
                    break;
                case 2:
                    txtStartMM.Text = st;
                    break;
                case 3:
                    txtStartSS.Text = st;
                    break;
                case 4:
                    txtEndHH.Text = st;
                    break;
                case 5:
                    txtEndMM.Text = st;
                    break;
                case 6:
                    txtEndSS.Text = st;
                    break;
                case 7:
                    txtTemperature.Text = st;
                    break;
                case 8:
                    txtTemperature1.Text = st;
                    break;
                case 9:
                    txtHumidity.Text = st;
                    break;
                case 10:
                    txtHumidity1.Text = st;
                    break;

            }
            listBox1.Visible = false;
            this.button1.Focus();
        }
        public void TxtWrite()
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

            using (StreamWriter wr = new StreamWriter("/home/pi/Test.txt"))
            //using (StreamWriter wr = new StreamWriter(GVar.DefPath+@"\Test.txt"))
            {
                for (int i = 0; i < 11; i++)
                {
                    wr.WriteLine(txt[i]);
                }
                wr.Close();
            }
        }

        
    }
}
