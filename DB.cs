using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using smartfarm;

namespace smartfarms
{
    class DB
    {
        static public MySqlConnection con = null;
        static public MySqlCommand cmd = null;
        string db_ip = "localhost", db_id = "root", db_pwd = "123", db_port = "3306";

        private static DB instance;   
        public static DB Instance
        {
            get
            {
                if (instance == null) instance = new DB();
                return instance;
            }
        }
        public DB()
        {

        }
        //public DB(string _para_db_ip, string _para_db_id, string _para_db_pwd, string _para_db_port)
        //{
        //    this.db_ip = _para_db_ip;
        //    this.db_id = _para_db_id;
        //    this.db_pwd = _para_db_pwd;
        //    this.db_port = _para_db_port;
        //}
        public void DBcon()
        {
            string conString = string.Format($"SERVER={db_ip};user={db_id};password={db_pwd};port={db_port};");
            con = new MySqlConnection(conString);
            con.Open();
        }
        static public void query_execute(string _para_query)
        {
            if (con.State == System.Data.ConnectionState.Closed) con.Open();
            cmd = new MySqlCommand(_para_query, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        static private void Con_Open()
        {
            if (con != null && con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void query_execute(string _para_query, string mode)
        {
            Con_Open();
            switch (mode)
            {
                case "select":
                    cmd = new MySqlCommand(_para_query, con);
                    MySqlDataReader rd = cmd.ExecuteReader();
                    //System.Windows.Forms.MessageBox.Show(rd.Read().ToString());
                    if (rd.Read())
                    {
                        variable.instance.temp_runTimeHH =  (int?)rd["temp_runTimeHH"] ?? 0;
                        variable.instance.temp_runTimeMM =  (int?)rd["temp_runTimeMM"] ?? 0;
                        variable.instance.temp_runTimeSS =  (int?)rd["temp_runTimeSS"] ?? 0;
                        variable.instance.temp_stoptimeHH = (int?)rd["temp_stoptimeHH"] ?? 0;
                        variable.instance.temp_stoptimeMM = (int?)rd["temp_stoptimeMM"] ?? 0;
                        variable.instance.temp_stoptimeSS = (int?)rd["temp_stoptimeSS"] ?? 0;//temp
                        variable.instance.humi_runTimeHH =  (int?)rd["humi_runTimeHH"] ?? 0;
                        variable.instance.humi_runTimeMM =  (int?)rd["humi_runTimeMM"] ?? 0;
                        variable.instance.humi_runTimeSS =  (int?)rd["humi_runTimeSS"] ?? 0;
                        variable.instance.humi_stoptimeHH = (int?)rd["humi_stoptimeHH"] ?? 0;
                        variable.instance.humi_stoptimeMM = (int?)rd["humi_stoptimeMM"] ?? 0;
                        variable.instance.humi_stoptimeSS = (int?)rd["humi_stoptimeSS"] ?? 0;//humin
                        variable.instance.water_runTimeHH = (int?)rd["water_runTimeHH"] ?? 0;
                        variable.instance.water_runTimeMM = (int?)rd["water_runTimeMM"] ?? 0;
                        variable.instance.water_runTimeSS = (int?)rd["water_runTimeSS"] ?? 0;
                        variable.instance.water_stoptimeHH =(int?)rd["water_stoptimeHH"] ?? 0;
                        variable.instance.water_stoptimeMM =(int?)rd["water_stoptimeMM"] ?? 0;
                        variable.instance.water_stoptimeSS =(int?)rd["water_stoptimeSS"] ?? 0;//water
                        variable.instance.fan_runTimeHH =   (int?)rd["fan_runTimeHH"] ?? 0;
                        variable.instance.fan_runTimeMM =   (int?)rd["fan_runTimeMM"] ?? 0;
                        variable.instance.fan_runTimeSS =   (int?)rd["fan_runTimeSS"] ?? 0;
                        variable.instance.fan_stoptimeHH =  (int?)rd["fan_stoptimeHH"] ?? 0;
                        variable.instance.fan_stoptimeMM =  (int?)rd["fan_stoptimeMM"] ?? 0;
                        variable.instance.fan_stoptimeSS =  (int?)rd["fan_stoptimeSS"] ?? 0;//fan
                        variable.instance.auto_TempLOW = (int?)rd["auto_TempLOW"] ?? 0;
                        variable.instance.auto_TempHIGH = (int?)rd["auto_TempHIGH"] ?? 0;
                        variable.instance.auto_HumLOW = (int?)rd["auto_HumLOW"] ?? 0;
                        variable.instance.auto_HumHIGH = (int?)rd["auto_HumHIGH"] ?? 0;
                        variable.instance.save_period = (int?)rd["save_period"] ?? 0;
                        if (variable.instance.save_period == 0 || variable.instance.save_period == null)
                        {
                            variable.instance.save_period = 1000;
                        }
                        variable.instance.Pump_period = (int?)rd["PumP_period"] ?? 0;

                        variable.instance.avg_tmp = (int)((variable.instance.auto_TempHIGH + variable.instance.auto_TempLOW) / 2);
                        variable.instance.avg_hum = (int)((variable.instance.auto_HumHIGH + variable.instance.auto_HumLOW) / 2);
                    }
                    else
                    {
                        variable.instance.temp_runTimeHH = 00;
                        variable.instance.temp_runTimeMM = 00;
                        variable.instance.temp_runTimeSS = 00;
                        variable.instance.temp_stoptimeHH = 00;
                        variable.instance.temp_stoptimeMM = 00;
                        variable.instance.temp_stoptimeSS = 00;//temp
                        variable.instance.humi_runTimeHH = 00;
                        variable.instance.humi_runTimeMM = 00;
                        variable.instance.humi_runTimeSS = 00;
                        variable.instance.humi_stoptimeHH = 00;
                        variable.instance.humi_stoptimeMM = 00;
                        variable.instance.humi_stoptimeSS = 00;//humi
                        variable.instance.water_runTimeHH = 00;
                        variable.instance.water_runTimeMM = 00;
                        variable.instance.water_runTimeSS = 00;
                        variable.instance.water_stoptimeHH = 00;
                        variable.instance.water_stoptimeMM = 00;
                        variable.instance.water_stoptimeSS = 00;//water
                        variable.instance.fan_runTimeHH = 00;
                        variable.instance.fan_runTimeMM = 00;
                        variable.instance.fan_runTimeSS = 00;
                        variable.instance.fan_stoptimeHH = 00;
                        variable.instance.fan_stoptimeMM = 00;
                        variable.instance.fan_stoptimeSS = 00;//fan
                        variable.instance.auto_TempLOW = 00;
                        variable.instance.auto_TempHIGH = 00;
                        variable.instance.auto_HumLOW = 00;
                        variable.instance.auto_HumHIGH = 00;
                        variable.instance.save_period = 1000;
                        variable.instance.Pump_period = 00;
                    }
                    break;
                case "insert":
                    cmd = new MySqlCommand(_para_query, con);
                    cmd.ExecuteNonQuery();
                    break;
                default:
                    break;
            }
            con.Close();
        }
        public void DBorTable_Create()
        {
            //server=localhost;user=root;port=3306;password=mysql

            try
            {
                if(con.State == System.Data.ConnectionState.Closed) con.Open();
                query_execute("create database if not exists `farmming`;");
                query_execute("use farmming;");
                query_execute("create table if not exists save_state (" +
                    "temperature int," +
                    "humidity int," +
                    "Fan bool," +
                    "Pump bool," +
                    "dates varchar(20)" +
                    ");");
                query_execute("create table if not exists setting (" +
                    "temp_runtimeHH int," +
                    "temp_runtimeMM int," +
                    "temp_runtimeSS int," +
                    "temp_stoptimeHH int," +
                    "temp_stoptimeMM int," +
                    "temp_stoptimeSS int," +//temp
                    "humi_runtimeHH int," +
                    "humi_runtimeMM int," +
                    "humi_runtimeSS int," +
                    "humi_stoptimeHH int," +
                    "humi_stoptimeMM int," +
                    "humi_stoptimeSS int," +//humin
                    "water_runtimeHH int," +
                    "water_runtimeMM int," +
                    "water_runtimeSS int," +
                    "water_stoptimeHH int," +
                    "water_stoptimeMM int," +
                    "water_stoptimeSS int," +//water
                    "fan_runtimeHH int," +
                    "fan_runtimeMM int," +
                    "fan_runtimeSS int," +
                    "fan_stoptimeHH int," +
                    "fan_stoptimeMM int," +
                    "fan_stoptimeSS int," +//fan
                    "auto_TempLOW int," +
                    "auto_TempHIGH int," +
                    "auto_HumLOW int," +
                    "auto_HumHIGH int," +
                    "save_period int," +
                    "PumP_period int);");
                #region 디비주석
                //query = "create database if not exists `smartfarm`;";
                //cmd = new MySqlCommand(query, con);
                //cmd.ExecuteNonQuery();
                //query = "create table if not exists save_state (" +
                //    "temperature int," +
                //    "humidity int," +
                //    "Fan bool," +
                //    "Pump bool);";
                //cmd.ExecuteNonQuery();
                //query = "create table if not exists setting (" +
                //    "runtimeHH int," +
                //    "runtimeMM int," +
                //    "runtimeSS int," +
                //    "stoptimeHH int," +
                //    "stoptimeMM int," +
                //    "stoptimeSS int," +
                //    "auto_TempLOW int," +
                //    "auto_TempHIGH int," +
                //    "auto_HumLOW int," +
                //    "auto_HumHIGH int," +
                //    "save_period int," +
                //    "PumP_period int);";
                #endregion
            }
            catch (Exception e)
            {
                if (con != null && con.State == System.Data.ConnectionState.Closed)
                {
                    System.Windows.Forms.MessageBox.Show("데이터베이스 연결에 실패하였습니다."+ e.StackTrace);
                    //System.Windows.Forms.MessageBox.Show(e.StackTrace);
                }
                
                con.Close();
            }
        }
        static void save_state()
        {

        }
    }
}
