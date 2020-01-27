using System;
using System.Collections.Generic;
using System.Text;
using Npgsql;
using log4net;

namespace CatalogoDBLib.dbmanager
{
    public class PGEntityManager
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(PGEntityManager));

        public static String sConnStr;

        static PGEntityManager miEntityManager = null;

        private PGEntityManager()
        {
        
        
        
        }


        static public PGEntityManager getInstance()
        {
        
        
            if (miEntityManager == null){

                miEntityManager = new PGEntityManager();
                init(sConnStr);

            }


            return miEntityManager;
        
        }


        public  int save(Entidad o) {


            NpgsqlCommand cmd;
            string sql = null;

            sql = o.getInsert();

            try
            {
                cmd = new NpgsqlCommand(sql, conn);
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


        public int update(Entidad o)
        {


            NpgsqlCommand cmd;
            string sql = null;

            sql = o.getUpdate();

            try
            {
                cmd = new NpgsqlCommand(sql, conn);
                o.setUpdateCommand(cmd);
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
            NpgsqlCommand cmd;
            string sql = null;
            int ret = -1;
            sql = "Select @@IDENTITY";

            try
            {
                cmd = new NpgsqlCommand(sql, conn);
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



        static NpgsqlConnection conn;

        public static NpgsqlConnection Conn
        {
            get { return PGEntityManager.conn; }
            set { PGEntityManager.conn = value; }
        }
 


        public static void init(String connStr)
        {

            conn = new NpgsqlConnection(connStr);
            try
            {
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

        public Entidad getRecord(Entidad o)
        {
            NpgsqlCommand cmd;
            string sql = null;
            List<Entidad> lstEntidades = new List<Entidad>();

            sql = o.getSelect();

            try
            {
                cmd = new NpgsqlCommand(sql, conn);
                o.setSelectCommand(cmd);
                NpgsqlDataReader reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    Type t = o.GetType();
                    Object neo = t.GetConstructor(new Type[] { }).Invoke(new object[] { });

                    o.fill(neo, reader);


                }
                reader.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                log.Error(ex.Message);
                log.Error(ex.StackTrace);
            }


            return o;
        }






        public IList<Entidad> getList(Entidad o)
        {
            NpgsqlCommand cmd;
            string sql = null;
            List<Entidad> lstEntidades = new List<Entidad>();

            sql = o.getSelectAll();

            try
            {
                cmd = new NpgsqlCommand(sql, conn);
                o.setSelectCommand(cmd);
                NpgsqlDataReader reader = cmd.ExecuteReader();


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




        public IList<Entidad> getListHijosxId(Entidad o)
        {
            NpgsqlCommand cmd;
            string sql = null;
            List<Entidad> lstEntidades = new List<Entidad>();

            sql = o.getSelectHijosxId();

            try
            {
                cmd = new NpgsqlCommand(sql, conn);
                o.setSelectHijosxIdCommand(cmd);
                NpgsqlDataReader reader = cmd.ExecuteReader();


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

        public IList<Entidad> getListxNivel(Entidad o)
        {
            NpgsqlCommand cmd;
            string sql = null;
            List<Entidad> lstEntidades = new List<Entidad>();

            sql = o.getSelectxNivel();

            NpgsqlDataReader reader = null;
            try
            {
                cmd = new NpgsqlCommand(sql, conn);
                o.setSelectxNivelCommand(cmd);

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Type t = o.GetType();
                    Object neo = t.GetConstructor(new Type[] { }).Invoke(new object[] { });

                    o.fill(neo, reader);

                    lstEntidades.Add((Entidad)neo);

                }
                reader.Close();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                reader.Close();
                log.Error(ex.Message);
                log.Error(ex.StackTrace);
            }


            return lstEntidades;
        }

        public  IList<Entidad> getListHijosTDxId(Entidad o)
        {
            NpgsqlCommand cmd;
            string sql = null;
            List<Entidad> lstEntidades = new List<Entidad>();

            sql = o.getSelectHijosTDxId();

            try
            {
                cmd = new NpgsqlCommand(sql, conn);
                o.setSelectHijosTDxIdCommand(cmd);
                NpgsqlDataReader reader = cmd.ExecuteReader();


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

         public int getLastIdForDocument()
        {
            NpgsqlCommand cmd;
            string sql = null;
            int ret = -1;
            sql = "SELECT currval('\"LibDocumento_id_seq\"');";

            try
            {
                cmd = new NpgsqlCommand(sql, conn);
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
    }
}
