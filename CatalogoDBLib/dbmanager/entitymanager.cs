using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using log4net;

namespace CatalogoDBLib.dbmanager
{
    public class EntityManager
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(OleEntityManager));

        public static String sConnStr;

        //public String SConnStr
        //{
        //    get { return sConnStr; }
        //    set { sConnStr = value; }
        //}
        static EntityManager miEntityManager = null;

        private EntityManager(){
        
        
        
        }


        static public EntityManager getInstance(){
        
        
            if (miEntityManager == null){

                miEntityManager = new EntityManager();
                init(sConnStr);

            }


            return miEntityManager;
        
        }


        public  int save(Entidad o) {


            SqlCommand cmd;
            string sql = null;

            sql = o.getInsert();

            try
            {
                cmd = new SqlCommand(sql, conn);
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


            SqlCommand cmd;
            string sql = null;
            int ret = -1;
            sql = "Select @@IDENTITY";

            try
            {
                cmd = new SqlCommand(sql, conn);
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



        public static SqlConnection conn;
 
        public static void init(String connStr){

            conn = new SqlConnection(connStr);
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


        public IList<Entidad> getList(Entidad o)
        {
            SqlCommand cmd;
            string sql = null;
            List<Entidad> lstEntidades = new List<Entidad>();

            sql = o.getSelectAll();

            try
            {
                cmd = new SqlCommand(sql, conn);
                o.setSelectCommand(cmd);
                SqlDataReader reader = cmd.ExecuteReader();


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
