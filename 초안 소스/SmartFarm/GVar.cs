using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFarm
{
    public class Machine
    {
        public static bool Pump; //펌프
        public static bool CoolingHeating; //냉난방
        public static bool Light; //형광등
        public static bool Fan; //Fan
        public Machine()
        {
            Pump = false;
            CoolingHeating = false;
            Light = false;
            Fan = false;
        }
    }
    class GVar
    {
        public static string DefPath;
        public static bool RunStart; //운전시작/종료

        public static byte AutoMan; //0:수동 1:반자동 2:자동
        public static int StartHH; // 반수동 가동시간 시  (시분초는 시분초만큼 가동하고 시분초만큼 정지해라는말이다)
        public static int StartMM; // 반수동 가동시간 분
        public static int StartSS; // 반수동 가동시간 초
        public static uint StartHMSFull; // 반수동 가동시간 전체시간 초

        public static int EndHH; // Man시 정지시간 시
        public static int EndMM; // Man시 정지시간 분
        public static int EndSS; // Man시 정지시간 초
        public static uint EndHMSFull; // 반수동 정지시간 전체시간 초

        public static float SetTempNowRead; //현재 온도
        public static int SetTempLow; //설정된 온도
        public static int SetTempHigh; //설정된 온도
        public static bool SetTempTop; // 온도 높은쪽에 도달했다
        public static bool SetTempButton; // 온도 낮은쪽에 도달했다
        public static bool SetTempRuning; // 온도 맞추기 작동중

        public static float SetHumNowRead; //현재 습도
        public static int SetHumLow; //설정된 습도
        public static int SetHumHigh; //설정된 습도
        //public static bool SetHumTop; //설정된 습도
        public static bool SetHumButton; // 습도가 최하점에 도달했다
        public static bool SetHumRuning; // 습도 맞추기 작동중

        public static int TimeSecondCnt; // 반자동, 자동에서 경과 시간을 카운터한다 초시간 세기
        public static bool LightTf; // 형광등 True :켜짐 False:꺼짐
        public static bool FanTf; // Fan True :켜짐 False:꺼짐
        public static bool SetOk; // 반자동/자동 선택시 설정이 전부 다되었을때 True
        

        public GVar()
        {
            DefPath = "";
            RunStart = false;
            AutoMan = 0;
            StartHH = 0;
            StartMM = 0;
            StartSS = 0;
            EndHH = 0;
            EndMM = 0;
            EndSS = 0;
            SetTempLow = 0;
            SetTempHigh = 0;
            SetHumLow = 0;
            SetHumHigh = 0;
            TimeSecondCnt = 0;
            LightTf = false;
            FanTf = false;
        }

    }
}
