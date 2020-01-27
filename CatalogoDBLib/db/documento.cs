using System;
using System.Collections.Generic;
using System.Text;
using CatalogoDBLib.dbmanager;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.OleDb;
using Npgsql;
using log4net;

namespace CatalogoDBLib.db
{
    public class Documento : Entidad
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(Documento));

        String sqlUpdate = " update LibDocumento set id_tipo=@id_tipo,nro=@nro,fecha=@fecha,codigobarra=@codigobarra,stoid=@stoid, estado=@estado,desechado=@desechado where id=@id ";
        String sqlInsert = " insert into LibDocumento(id_tipo,nro,fecha,codigobarra,stoid,estado,desechado) values (@id_tipo,@nro,@fecha,@codigobarra,@stoid,@estado,@desechado) ";
        static String sqlListSelected = "select ld.id,ld.id_tipo,ld.nro,ld.fecha,ld.codigobarra,ld.stoid, ldc.valor,ldn.nombre,ldc.id,ldn.id_uo,luo.idpadre,ld.estado,ld.desechado " +
                                "from ((LibDocumento ld left join LibDocClase ldc on (ld.id = ldc.id_doc)) left join LibDocNivel ldn on ( ld.id = ldn.id_doc))  left join LibUnidadOrganizacional luo on (ldn.id_uo = luo.id) "+
                                "where "+
                                "(ld.id_tipo = @id_tipo or @id_tipo = -1 ) "+
                                " and (ld.nro like @nro or @nro='') " +
                                " and (ld.estado = @estado or @estado=-1) " +
                                " and (ld.desechado = @desechado or @desechado=-1) " +
                                " and (upper(ldc.valor) like @valor or @valor='') " +
                                " and (ldn.id_uo = @id_uo or @id_uo=-1) " +
                                " and (luo.idpadre = @id_padre or @id_padre=-1) " +
                                " and (fecha between @dtIni and @dtFin) " +
                                " order by ld.codigobarra ";
        

        public void setUpdate() {}
        public void setInsert() { }
        
        public void setInsertCommand(SqlCommand sqlCom) {
        
            SqlParameter sqlParam = new SqlParameter();

            sqlParam.ParameterName = "@id_tipo";
            sqlParam.Value = this.Id_tipo;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new SqlParameter();

            sqlParam.ParameterName = "@nro";
            sqlParam.Value = this.Nro == null ? SqlString.Null : this.Nro;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new SqlParameter();

            sqlParam.ParameterName = "@fecha";
            sqlParam.Value = SqlDateTime.Null;
            sqlParam.Value = this.Fecha == new DateTime()? SqlDateTime.Null : this.Fecha;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new SqlParameter();
            sqlParam.ParameterName = "@codigobarra";
            sqlParam.Value = this.Codigobarra == null ? SqlString.Null : this.Codigobarra;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new SqlParameter();

            sqlParam.ParameterName = "@stoid";
            sqlParam.Value = this.Stoid == null ? SqlString.Null : this.Stoid;
            sqlCom.Parameters.Add(sqlParam);



        
        }

        public void setInsertCommand(OleDbCommand sqlCom)
        {

            OleDbParameter sqlParam = new OleDbParameter();

            sqlParam.ParameterName = "@id_tipo";
            sqlParam.Value = this.Id_tipo;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new OleDbParameter();

            sqlParam.ParameterName = "@nro";
            sqlParam.Value = this.Nro == null ? SqlString.Null : this.Nro;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new OleDbParameter();

            sqlParam.ParameterName = "@fecha";
            sqlParam.Value = SqlDateTime.Null;
            sqlParam.Value = this.Fecha == new DateTime() ? SqlDateTime.Null : this.Fecha;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new OleDbParameter();
            sqlParam.ParameterName = "@codigobarra";
            sqlParam.Value = this.Codigobarra == null ? SqlString.Null : this.Codigobarra;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new OleDbParameter();

            sqlParam.ParameterName = "@stoid";
            sqlParam.Value = this.Stoid == null ? SqlString.Null : this.Stoid;
            sqlCom.Parameters.Add(sqlParam);




        }

        public void setInsertCommand(NpgsqlCommand sqlCom)
        {

            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_tipo";
            sqlParam.Value = this.Id_tipo;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@nro";
            if (this.Nro != null) sqlParam.Value = this.Nro;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@fecha";

            if (this.Fecha != null) sqlParam.Value = this.Fecha;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();
            sqlParam.ParameterName = "@codigobarra";
            if (this.Codigobarra != null) sqlParam.Value = this.Codigobarra;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@stoid";
            if (this.Stoid != null) sqlParam.Value = this.Stoid;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@estado";
            if (this.Estado != null) sqlParam.Value = this.Estado;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@desechado";
            if (this.Desechado != null) sqlParam.Value = this.Desechado;
            sqlCom.Parameters.Add(sqlParam);



        }
        public void setUpdateCommand(NpgsqlCommand sqlCom)
        {

            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_tipo";
            sqlParam.Value = this.Id_tipo;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@nro";
            if (this.Nro != null) sqlParam.Value = this.Nro;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@fecha";

            if (this.Fecha != null) sqlParam.Value = this.Fecha;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();
            sqlParam.ParameterName = "@codigobarra";
            if (this.Codigobarra != null) sqlParam.Value = this.Codigobarra;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@stoid";
            if (this.Stoid != null) sqlParam.Value = this.Stoid;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@estado";
            if (this.Estado != null) sqlParam.Value = this.Estado;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@desechado";
            if (this.Desechado != null) sqlParam.Value = this.Desechado;
            sqlCom.Parameters.Add(sqlParam);
            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id";
            sqlParam.Value = this.Id;
            sqlCom.Parameters.Add(sqlParam);



        }


        static public void setListSelectCommand(NpgsqlCommand sqlCom, int tipoDoc, string nroDoc, DateTime dtIni, DateTime dtFin, int idUoPadre, int idUoHijo, string referencia)
        {

            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_uo";
            sqlParam.Value = idUoHijo;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_tipo";
            sqlParam.Value = tipoDoc;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@nro";
            sqlParam.Value = nroDoc;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@valor";
            sqlParam.Value = referencia;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();
            sqlParam.ParameterName = "@id_padre";
            sqlParam.Value = idUoPadre;
            sqlCom.Parameters.Add(sqlParam);



        }



        static public void setListSelectCommand(NpgsqlCommand sqlCom, int tipoDoc, string nroDoc, DateTime dtIni, DateTime dtFin, int idUoPadre, int idUoHijo, string referencia, short estado, short desechado)
        {

            NpgsqlParameter sqlParam = new NpgsqlParameter();
            dtFin.ToString("yyyyMMdd");
            sqlParam.ParameterName = "@id_uo";
            sqlParam.Value = idUoHijo;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_tipo";
            sqlParam.Value = tipoDoc;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@nro";
            sqlParam.Value = nroDoc;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@valor";
            sqlParam.Value = referencia;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();
            
            sqlParam.ParameterName = "@id_padre";
            sqlParam.Value = idUoPadre;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@estado";
            sqlParam.Value = estado;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@desechado";
            sqlParam.Value = desechado;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@dtIni";
            sqlParam.Value = dtIni;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@dtFin";
            sqlParam.Value = dtFin;
            sqlCom.Parameters.Add(sqlParam);
        }

        public String getUpdate() { return sqlUpdate; }
        public String getInsert() { return sqlInsert; }


        private String stoid;

        public String Stoid
        {
            get { return stoid; }
            set { stoid = value; }
        }


        private Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }
        private Int32 id_tipo;

        public Int32 Id_tipo
        {
            get { return id_tipo; }
            set { id_tipo = value; }
        }
        private String nro;

        public String Nro
        {
            get { return nro; }
            set { nro = value; }
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        private String codigobarra;

        public static int TIPO_DESCONOCIDO = 0;
        private string sqlSelect;
        private string sqlSelectAll;


        public String Codigobarra
        {
            get { return codigobarra; }
            set { codigobarra = value; }
        }


        private Int32 _desechado;

        public Int32 Desechado
        {
            get { return _desechado; }
            set { _desechado = value; }
        }
        private Int32 _estado;

        public Int32 Estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        public void fill(Object o, SqlDataReader sqlReader)
        {


        }

        public void fill(Object o, OleDbDataReader sqlReader)
        {


        }

        public void fill(Object o, NpgsqlDataReader sqlReader)
        {





        }


        public void fill(Documento doc, NpgsqlDataReader sqlReader)
        {

            //ld.id,ld.id_tipo,ld.nro,fecha,ld.codigobarra,ld.stoid, ldc.valor,ldn.nombre,ldc.id,ldn.id_uo 
            doc.Codigobarra = sqlReader.GetString(4);
            doc.Fecha = sqlReader.GetDateTime(3);
            doc.Id = sqlReader.GetInt32(0);
            doc.Id_tipo = sqlReader.GetInt32(1);
            doc.Nro = sqlReader.GetString(2);
            doc.Stoid = sqlReader.GetString(5);
            doc.Desechado = sqlReader.GetInt16(6);
            doc.Estado = sqlReader.GetInt16(7);



        }
 

        public void fill(Documento doc, NpgsqlDataReader sqlReader, DocumentoClsNivel dcn)
        {

            //ld.id,ld.id_tipo,ld.nro,fecha,ld.codigobarra,ld.stoid, ldc.valor,ldn.nombre,ldc.id,ldn.id_uo 
            doc.Codigobarra = sqlReader.IsDBNull(4) ? "": sqlReader.GetString(4);
            doc.Fecha = sqlReader.GetDateTime(3);
            doc.Id = sqlReader.GetInt32(0);
            doc.Id_tipo = sqlReader.GetInt32(1);
            doc.Nro = sqlReader.GetString(2);
            doc.Stoid = sqlReader.IsDBNull(5) ? "" : sqlReader.GetString(5);
            doc.Estado = sqlReader.IsDBNull(11) ? (short)0 : sqlReader.GetInt16(11);
            doc.Desechado = sqlReader.IsDBNull(12) ? (short)0 : sqlReader.GetInt16(12);

            dcn.MiDocumento = doc;
            dcn.Ldc_id = sqlReader.IsDBNull(8) ? -1 : sqlReader.GetInt32(8);
            dcn.Ldn_id_uo = sqlReader.IsDBNull(9) ? -1 : sqlReader.GetInt32(9);
            dcn.Ldn_id_uopadre = sqlReader.IsDBNull(10) ? -1 : sqlReader.GetInt32(10);
            dcn.StoId = doc.Stoid;



        }
 
        public void setSelectCommand(SqlCommand sqlCom) { }
        public void setSelectCommand(OleDbCommand sqlCom) { }
        public void setSelectCommand(NpgsqlCommand sqlCom) { }

        public String getSelect() { return sqlSelect; }
        public String getSelectAll() { return sqlSelectAll; }
        public String getSelectxNivel() { return String.Empty; }
        public String getSelectHijosxId() { return String.Empty; }
        public String getSelectHijosTDxId() { return String.Empty; }



        public void setSelectHijosxIdCommand(NpgsqlCommand sqlCom)
        {

        }

        public void setSelectxNivelCommand(NpgsqlCommand sqlCom)
        {

        }

        public void setSelectHijosTDxIdCommand(NpgsqlCommand cmd)
        {

        }



        internal static int getlastId()
        {
            throw new NotImplementedException();
        }

        //public static IList<Documento> getListSelected(int tipoDoc, int idDominio, string valor)
        //{

            
        //}


        public static DocumentoClase getValueorClassification() {

            DocumentoClase dc = new DocumentoClase();

            return dc;
        
        }

        public static DocumentoUnidad getUnidad() {

            DocumentoUnidad du = new DocumentoUnidad();

            return du;
        
        
        
        }


        //public static IList<Documento> getListSelected(int tipoDoc, string nroDoc, DateTime dtIni, DateTime dtFin, int idUoPadre, int idUoHijo, string referencia)
        //{

        //    NpgsqlCommand cmd;
        //    string sql = Documento.sqlListSelected;
        //    List<Documento> lstEntidades = new List<Documento>();


        //    try
        //    {
        //        cmd = new NpgsqlCommand(sql, PGEntityManager.Conn);
        //        Documento.setListSelectCommand(cmd, tipoDoc, nroDoc, dtIni, dtFin, idUoPadre, idUoHijo, referencia);

        //        NpgsqlDataReader reader = cmd.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            Documento neo = new Documento();
        //            DocumentoClsNivel dcn = new DocumentoClsNivel();
        //            neo.fill(neo, reader, dcn);

        //            lstEntidades.Add(neo);

        //        }
        //        reader.Close();
        //        cmd.Dispose();
        //    }
        //    catch (Exception ex)
        //    {

        //        log.Error(ex.Message);
        //        log.Error(ex.StackTrace);
        //    }


        //    return lstEntidades;
        //}

        public static IList<DocumentoClsNivel> getListSelected(int tipoDoc, string nroDoc, DateTime dtIni, DateTime dtFin, int idUoPadre, int idUoHijo, string referencia, short desechado, short estado)
        {

            NpgsqlCommand cmd;
            string sql = Documento.sqlListSelected;
            List<DocumentoClsNivel> lstEntidades = new List<DocumentoClsNivel>();


            try
            {
                cmd = new NpgsqlCommand(sql, PGEntityManager.Conn);
                Documento.setListSelectCommand(cmd, tipoDoc, nroDoc, dtIni, dtFin, idUoPadre, idUoHijo, referencia,estado,desechado);

                NpgsqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Documento neo = new Documento();
                    DocumentoClsNivel dcn = new DocumentoClsNivel();
                    neo.fill(neo, reader, dcn);

                    lstEntidades.Add(dcn);

                }
                reader.Close();
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
