using System;
using System.Collections.Generic;
using System.Text;
using CatalogoDBLib.dbmanager;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.OleDb;
using Npgsql;
using NpgsqlTypes;

namespace CatalogoDBLib.db
{
    public class ValorDominio:Entidad  
    {



        public String getValue() {return Valor;}
        Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        String valor;

        public String Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        Int32 id_dominio;

        public Int32 Id_dominio
        {
            get { return id_dominio; }
            set { id_dominio = value; }
        }

        String sqlUpdate = " update LibValor set id_dominio=@id_dominio ,valor = @valor where id = @id ";
        String sqlInsert = " insert into LibValor (id_dominio,valor) values (@id_dominio,@valor) ";
        String sqlSelect = " select id,id_dominio,valor from  LibValor where id = @id or @id=-1";
        String sqlSelectAll = " select id,id_dominio,valor from  LibValor where id_dominio = @id_dominio";

        public void setUpdate() { }
        public void setInsert() { }

        public void fill(Object o, SqlDataReader sqlReader) {

            ValorDominio vd = (ValorDominio)o;

            vd.Id = sqlReader.GetInt32(0);
            vd.Id_dominio = sqlReader.GetInt32(1);
            vd.Valor = sqlReader.GetString(2);

        
        }

        public void fill(Object o, NpgsqlDataReader sqlReader)
        {

            ValorDominio vd = (ValorDominio)o;

            vd.Id = sqlReader.GetInt32(0);
            vd.Id_dominio = sqlReader.GetInt32(1);
            vd.Valor = sqlReader.GetString(2);


        }


        public void fill(Object o, OleDbDataReader sqlReader)
        {

            ValorDominio vd = (ValorDominio)o;

            vd.Id = sqlReader.GetInt32(0);
            vd.Id_dominio = sqlReader.GetInt32(1);
            vd.Valor = sqlReader.GetString(2);

        }



        public void setInsertCommand(SqlCommand sqlCom)
        {

            SqlParameter sqlParam = new SqlParameter();

            sqlParam.ParameterName = "@id_dominio";
            sqlParam.Value = this.Id_dominio == null ? SqlInt32.Null : this.Id_dominio;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new SqlParameter();

            sqlParam.ParameterName = "@valor";
            sqlParam.Value = this.Valor == null ? SqlString.Null : this.Valor;
            sqlCom.Parameters.Add(sqlParam);
        }

        public void setInsertCommand(OleDbCommand sqlCom)
        {

            OleDbParameter sqlParam = new OleDbParameter();

            sqlParam.ParameterName = "@id_dominio";
            sqlParam.Value = this.Id_dominio == null ? SqlInt32.Null : this.Id_dominio;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new OleDbParameter();

            sqlParam.ParameterName = "@valor";
            sqlParam.Value = this.Valor == null ? SqlString.Null : this.Valor;
            sqlCom.Parameters.Add(sqlParam);
        }

        public void setInsertCommand(NpgsqlCommand sqlCom)
        {

            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_dominio";
            if (this.Id_dominio != null) sqlParam.Value = this.Id_dominio;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@valor";
            if (this.Valor != null) sqlParam.Value =  this.Valor;
            sqlCom.Parameters.Add(sqlParam);
        }

        public void setUpdateCommand(NpgsqlCommand sqlCom)
        {

            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_dominio";
            if (this.Id_dominio != null) sqlParam.Value = this.Id_dominio;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@valor";
            if (this.Valor != null) sqlParam.Value = this.Valor;
            sqlCom.Parameters.Add(sqlParam);
            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id";
            sqlParam.Value = this.Id;
            sqlCom.Parameters.Add(sqlParam);
        }


        public void setSelectCommand(NpgsqlCommand sqlCom)
        {

            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_dominio";

            if (this.Id_dominio != null) sqlParam.Value = this.Id_dominio;
            sqlCom.Parameters.Add(sqlParam);

        }




        public void setSelectCommand(SqlCommand sqlCom)
        {

            SqlParameter sqlParam = new SqlParameter();

            sqlParam.ParameterName = "@id_dominio";
            sqlParam.Value = this.Id_dominio == null ? SqlInt32.Null : this.Id_dominio;
            sqlCom.Parameters.Add(sqlParam);

        }

        public void setSelectCommand(OleDbCommand sqlCom)
        {

            OleDbParameter sqlParam = new OleDbParameter();

            sqlParam.ParameterName = "@id_dominio";
            sqlParam.Value = this.Id_dominio == null ? SqlInt32.Null : this.Id_dominio;
            sqlCom.Parameters.Add(sqlParam);

        }

        public void setSelectHijosxIdCommand(NpgsqlCommand sqlCom)
        {

        }

        public void setSelectxNivelCommand(NpgsqlCommand sqlCom)
        {

        }

        public void setSelectHijosTDxIdCommand(NpgsqlCommand cmd)
        {

        }




        public String getUpdate() { return sqlUpdate; }
        public String getInsert() { return sqlInsert; }
        public String getSelect() { return sqlSelect; }
        public String getSelectAll() { return sqlSelectAll; }
        public String getSelectxNivel() { return String.Empty; }
        public String getSelectHijosxId() { return String.Empty; }
        public String getSelectHijosTDxId() { return String.Empty; }


    }
}
