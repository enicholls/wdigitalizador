using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using log4net;

namespace CatalogoDBLib.dbmanager
{
    public class OleEntityManager
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(OleEntityManager));
    

        static OleEntityManager miEntityManager = null;

        private OleEntityManager(){
        
        
        
        }

        private static String sConnStr;

        public String SConnStr
        {
            get { return sConnStr; }
            set { sConnStr = value; }
        }

        static public OleEntityManager getInstance(){
        
        
            if (miEntityManager == null){

                miEntityManager = new OleEntityManager();
                init(sConnStr);

            }


            return miEntityManager;
        
        }


        public  int save(Entidad o) {


            OleDbCommand cmd;
            string sql = null;

            sql = o.getInsert();

            try
            {
                cmd = new OleDbCommand(sql, conn);
                o.setInsertCommand(cmd);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                log.Error(ex.StackTrace);
            }
 
            


            return 0;


        }

        public int getLastIdentity()
        {
            OleDbCommand cmd;
            string sql = null;
            int ret = -1;
            sql = "Select @@IDENTITY";

            try
            {
                cmd = new OleDbCommand(sql, conn);
                ret = Convert.ToInt32(cmd.ExecuteScalar()); ;
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                log.Error(ex.StackTrace);
            }




            return ret;


        }



        static OleDbConnection conn;
 
        public static void init(String connStr){

            conn = new OleDbConnection(connStr);
                try{
                    conn.Open();
                }
                catch (Exception ex)
                {
                 
                    log.Error(ex.Message);
                    log.Error(ex.StackTrace);
                }
        }

        public static void close()
        {

            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {

                log.Error(ex.Message);
                log.Error(ex.StackTrace);
            }
        }


        internal IList<Entidad> getList(Entidad o)
        {
            OleDbCommand cmd;
            string sql = null;
            List<Entidad> lstEntidades = new List<Entidad>();

            sql = o.getSelectAll();

            try
            {
                cmd = new OleDbCommand(sql, conn);
                o.setSelectCommand(cmd);
                OleDbDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Type t = o.GetType();
                    Object neo = t.GetConstructor(new Type[] { }).Invoke(new object[] { });

                    o.fill(neo, reader);

                    lstEntidades.Add((Entidad)neo);

                }
                reader.Close();
                cmd.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                log.Error(ex.StackTrace);
            }


            return lstEntidades;
        }
    }
}
