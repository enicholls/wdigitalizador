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
    public class DocumentoClase : Entidad
    {

        String sqlUpdate = " update LibDocClase set id_dominio=@id_dominio,valor=@valor where id_doc=@id_doc";
//        String sqlUpdate = " update \"LibDocClase\" set id_doc=@id_doc,id_dominio=@id_dominio,valor=@id_dominio where id=@id";
        String sqlInsert = " insert into LibDocClase(id_doc,id_dominio,valor) values (@id_doc,@id_dominio,@valor) ";
        String sqlSelect = " select valor,id,id_doc,id_dominio from  LibDocClase where id_doc = @id_doc ";
        
        private string sqlSelectAll;
        
        public void setUpdate() {}
        public void setInsert() { }

        public void setInsertCommand(SqlCommand sqlCom)
        {

            SqlParameter sqlParam = new SqlParameter();

            sqlParam.ParameterName = "@id_doc";
            sqlParam.Value = this.Id_doc;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new SqlParameter();

            sqlParam.ParameterName = "@id_dominio";
            sqlParam.Value = this.Id_dominio;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new SqlParameter();

            sqlParam.ParameterName = "@valor";
            sqlParam.Value = this.Valor == null ? SqlString.Null : this.Valor;
            sqlCom.Parameters.Add(sqlParam);

        }


        public void setInsertCommand(NpgsqlCommand sqlCom)
        {

            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_doc";
            sqlParam.Value = this.Id_doc;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_dominio";
            sqlParam.Value = this.Id_dominio;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@valor";
            if (this.Valor != null) sqlParam.Value = this.Valor;
            sqlCom.Parameters.Add(sqlParam);

        }

        public void setUpdateCommand(NpgsqlCommand sqlCom)
        {

            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_doc";
            sqlParam.Value = this.Id_doc;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_dominio";
            sqlParam.Value = this.Id_dominio;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@valor";
            if (this.Valor != null) sqlParam.Value = this.Valor;
            sqlCom.Parameters.Add(sqlParam);

        }

        
        public void setInsertCommand(OleDbCommand sqlCom)
        {

            OleDbParameter sqlParam = new OleDbParameter();

            sqlParam.ParameterName = "@id_doc";
            sqlParam.Value = this.Id_doc;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new OleDbParameter();

            sqlParam.ParameterName = "@id_dominio";
            sqlParam.Value = this.Id_dominio;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new OleDbParameter();

            sqlParam.ParameterName = "@valor";
            sqlParam.Value = this.Valor == null ? SqlString.Null : this.Valor;
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

        private Int32 id_dominio;

        public Int32 Id_dominio
        {
            get { return id_dominio; }
            set { id_dominio = value; }
        }

        private Int32 id_doc;

        public Int32 Id_doc
        {
            get { return id_doc; }
            set { id_doc = value; }
        }

        private String valor;

        public String Valor
        {
            get { return valor; }
            set { valor = value; }
        }


        public static int TIPO_DESCONOCIDO = 0;




        public void fill(Object o, SqlDataReader sqlReader)
        {


        }
        public void fill(Object o, OleDbDataReader sqlReader)
        {


        }

        public void fill(Object o, NpgsqlDataReader sqlReader)
        {



            this.Valor = sqlReader.GetString(0);
            this.Id = sqlReader.GetInt32(1);
            this.Id_doc       = sqlReader.GetInt32(2);
            this.Id_dominio   = sqlReader.GetInt32(3);

        }


        public void setSelectCommand(NpgsqlCommand sqlCom)
        {

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
