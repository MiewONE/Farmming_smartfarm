using System;
using System.Collections.Generic;
using System.Data;
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
        //static public MySqldbconnection dbcon = null;
        //static public MySqlCommand cmd = null;
        string db_ip = "localhost", db_id = "root", db_pwd = "123", db_port = "3306";
        IDbConnection dbcon;
        IDbCommand cmd;
        // mysql 비밀번호
        // 집 tlqkfdk156
        // 노트북 123

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
            string dbconString = string.Format($"Server=localhost;Database=farmming;User ID=root;Password=123;Pooling=false;");


            dbcon = new MySqlConnection(dbconString);
            dbcon.Open();
            cmd = dbcon.CreateCommand();
        }
        public List<values> query_execute(string _para_query)
        {
            List<values> datas = new List<values>();
            if (dbcon.State == System.Data.ConnectionState.Closed) dbcon.Open();
            //cmd = new MySqlCommand(_para_query, dbcon);
            cmd.CommandText = _para_query;
            IDataReader rd = cmd.ExecuteReader();
            
            while(rd.Read())
            {
                datas.Add(new values(Convert.ToInt32(rd["temperature"]), Convert.ToInt32(rd["humidity"]), Convert.ToBoolean(rd["Fan"]), Convert.ToBoolean(rd["Pump"]), rd["dates"].ToString()));
            }
            //cmd.ExecuteNonQuery();
            rd.Close();
            dbcon.Close();

            return datas;
        }
        private void dbcon_Open()
        {
            if (dbcon != null && dbcon.State == System.Data.ConnectionState.Closed)
            {
                dbcon.Open();
            }
        }
        public void query_execute(string _para_query, string mode)
        {
            dbcon_Open();
            switch (mode)
            {
                case "select":
                    //cmd = new MySqlCommand(_para_query, dbcon);
                    cmd.CommandText = _para_query;
                    IDataReader rd = cmd.ExecuteReader();
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
                    //cmd = new MySqlCommand(_para_query, dbcon);
                    cmd.CommandText = _para_query;
                    cmd.ExecuteNonQuery();
                    break;
                default:
                    break;
            }
            dbcon.Close();
        }
        public void DBorTable_Create()
        {
            //server=localhost;user=root;port=3306;password=mysql

            try
            {
                if(dbcon.State == System.Data.ConnectionState.Closed) dbcon.Open();
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
                    "time_inputdata int," +
                    "PumP_period int);");
                #region 디비주석
                //query = "create database if not exists `smartfarm`;";
                //cmd = new MySqlCommand(query, dbcon);
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
                if (dbcon != null && dbcon.State == System.Data.ConnectionState.Closed)
                {
                    System.Windows.Forms.MessageBox.Show("데이터베이스 연결에 실패하였습니다."+ e.StackTrace);
                    //System.Windows.Forms.MessageBox.Show(e.StackTrace);
                }
                
                dbcon.Close();
            }
        }
    }
    class values
    {
        private int temperature;
        private int huminity;
        private bool fan;
        private bool pump;
        private String date;

        public values(int temp,int humi,bool fan,bool pump,string date)
        {
            this.temperature = temp;
            this.huminity = humi;
            this.fan = fan;
            this.pump = pump;
            this.date = date;
        }
        public int Tempberature{get{return temperature;}}
        public int Humidity { get { return huminity; } }
        public bool Fan{ get { return fan; } }
        public bool Pump { get { return pump; } }
        public String Date { get { return date; } }
    }
}
