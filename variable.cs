using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace smartfarm
{
    public class variable
    {
        private static variable Instance;
        public static variable instance
        {
            get
            {
                if (Instance == null)
                {
                    Instance = new variable();
                }
                return Instance;
            }
        }
        //temp
        public int? temp_value = 0;
        public int? temp_runTimeHH = 0;
        public int? temp_runTimeMM = 0;
        public int? temp_runTimeSS = 0;
        public int? temp_stoptimeHH = 0;
        public int? temp_stoptimeMM = 0;
        public int? temp_stoptimeSS = 0;
        public int? auto_TempLOW = 0;
        public int? auto_TempHIGH = 0;
        //humi
        public int? humi_value = 0;
        public int? humi_runTimeHH = 0;
        public int? humi_runTimeMM = 0;
        public int? humi_runTimeSS = 0;
        public int? humi_stoptimeHH = 0;
        public int? humi_stoptimeMM = 0;
        public int? humi_stoptimeSS = 0;
        public int? auto_HumLOW = 0;
        public int? auto_HumHIGH = 0;
        //water
        public int? water_runTimeHH = 0;
        public int? water_runTimeMM = 0;
        public int? water_runTimeSS = 0;
        public int? water_stoptimeHH = 0;
        public int? water_stoptimeMM = 0;
        public int? water_stoptimeSS = 0;
        //fan
        public int? fan_runTimeHH = 0;
        public int? fan_runTimeMM = 0;
        public int? fan_runTimeSS = 0;
        public int? fan_stoptimeHH = 0;
        public int? fan_stoptimeMM = 0;
        public int? fan_stoptimeSS = 0;

        public int? save_period = 1000;
        public int? Pump_period = 0;

        //현재 자동,수동 구분
        public bool Mode = false; // 수동 false, 자동 true

        //운전 시작,정지 상황
        public bool temp = false; // OFF false , ON true
        public bool humin = false;
        public bool pump = false;
        public bool light = false;
        public bool fan = false;

        //설정에서 지정된 온도의 평균값
        public double avg_tmp = 0;
        public double avg_hum = 0;

         //public double avg_tmp = (int)((Instance.auto_TempHIGH + Instance.auto_TempLOW) / 2);
         //public double avg_hum = (int)((Instance.auto_HumHIGH + Instance.auto_HumLOW) / 2);
    }
}
