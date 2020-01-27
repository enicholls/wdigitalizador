using System;
using System.Collections.Generic;
using System.Text;
using CatalogoDBLib.dbmanager;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.OleDb;
using Npgsql;

namespace CatalogoDBLib.db
{
    public class DocumentoUnidad : Entidad
    {

        String sqlUpdate = " update LibDocNivel set id_uo=@id_uo,nombre=@nombre where id_doc=@id_doc ";
//        String sqlUpdate = " update \"LibDocNivel\" set id_doc=@id_doc,id_uo=@id_uo,nombre=@nombre where id = @id ";
        String sqlInsert = " insert into LibDocNivel(id_doc,id_uo,nombre) values (@id_doc,@id_uo,@nombre) ";
        String sqlSelect = " select id,id_doc,id_uo,nombre from LibDocNivel where id_doc = @id_doc ";


        
        public void setUpdate() {}
        public void setInsert() { }

        public void setInsertCommand(SqlCommand sqlCom)
        {

            SqlParameter sqlParam = new SqlParameter();

            sqlParam.ParameterName = "@id_doc";
            sqlParam.Value = this.Id_doc;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new SqlParameter();

            sqlParam.ParameterName = "@id_uo";
            sqlParam.Value = this.Id_uo;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new SqlParameter();

            sqlParam.ParameterName = "@nombre";
            sqlParam.Value = this.nombre == null ? SqlString.Null : this.nombre;
            sqlCom.Parameters.Add(sqlParam);

        }


        public void setInsertCommand(NpgsqlCommand sqlCom)
        {

            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_doc";
            sqlParam.Value = this.Id_doc;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_uo";
            sqlParam.Value = this.Id_uo;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@nombre";
            if (this.nombre != null) sqlParam.Value = this.Nombre;
            sqlCom.Parameters.Add(sqlParam);

        }

        public void setUpdateCommand(NpgsqlCommand sqlCom)
        {

            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_doc";
            sqlParam.Value = this.Id_doc;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_uo";
            sqlParam.Value = this.Id_uo;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@nombre";
            if (this.nombre != null) sqlParam.Value = this.Nombre;
            sqlCom.Parameters.Add(sqlParam);

            //sqlParam = new NpgsqlParameter();

            //sqlParam.ParameterName = "@id";
            //sqlParam.Value = this.Id;
            //sqlCom.Parameters.Add(sqlParam);
        }

        
        public void setInsertCommand(OleDbCommand sqlCom)
        {

            OleDbParameter sqlParam = new OleDbParameter();

            sqlParam.ParameterName = "@id_doc";
            sqlParam.Value = this.Id_doc;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new OleDbParameter();

            sqlParam.ParameterName = "@id_uo";
            sqlParam.Value = this.Id_uo;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new OleDbParameter();

            sqlParam.ParameterName = "@nombre";
            sqlParam.Value = this.nombre == null ? SqlString.Null : this.nombre;
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

        private Int32 id_uo;

        public Int32 Id_uo
        {
            get { return id_uo; }
            set { id_uo = value; }
        }

        private Int32 id_doc;

        public Int32 Id_doc
        {
            get { return id_doc; }
            set { id_doc = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public static int TIPO_DESCONOCIDO = 0;

        private string sqlSelectAll;



        public void fill(Object o, SqlDataReader sqlReader)
        {


        }
        public void fill(Object o, OleDbDataReader sqlReader)
        {


        }

        public void fill(Object o, NpgsqlDataReader sqlReader)
        {

            DocumentoUnidad du = (DocumentoUnidad)o;


            du.Id = sqlReader.GetInt32(0);
            du.Id_doc = sqlReader.GetInt32(1);
            du.Id_uo = sqlReader.GetInt32(2);
            du.Nombre = sqlReader.GetString(3);

        }


        public void setSelectCommand(NpgsqlCommand sqlCom) {

            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_doc";

            if (this.Id_doc != null) sqlParam.Value = this.Id_doc;
            sqlCom.Parameters.Add(sqlParam);
       
        
        }

        public void setSelectCommand(SqlCommand sqlCom) { }
        public void setSelectCommand(OleDbCommand sqlCom) { }

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

    
    }
}
