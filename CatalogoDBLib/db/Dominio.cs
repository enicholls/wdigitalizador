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

    public class Dominio:Entidad
    {

        Int32 id;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }
        String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }


        String sqlUpdate = "";
        String sqlInsert = " insert into LibDominio(nombre,descripcion) values (@nombre,@descripcion) ";
        String sqlSelect = " select id,nombre,descripcion from  LibDominio where id = @id or @id=-1";
        String sqlSelectAll = " select id,id_dominio,valor from  LibValor where id_dominio = @id_dominio";

        public void setUpdate() { }
        public void setInsert() { }

        public void setInsertCommand(SqlCommand sqlCom)
        {

            SqlParameter sqlParam = new SqlParameter();

            sqlParam.ParameterName = "@nombre";
            sqlParam.Value = this.Nombre == null ? SqlString.Null : this.Nombre;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new SqlParameter();

            sqlParam.ParameterName = "@descripcion";
            sqlParam.Value = this.Descripcion == null ? SqlString.Null : this.Descripcion;
            sqlCom.Parameters.Add(sqlParam);
        }

        public void setInsertCommand(NpgsqlCommand sqlCom)
        {

            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@nombre";
            sqlParam.Value = this.Nombre == null ? SqlString.Null : this.Nombre;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@descripcion";
            sqlParam.Value = this.Descripcion == null ? SqlString.Null : this.Descripcion;
            sqlCom.Parameters.Add(sqlParam);
        }


        public void setUpdateCommand(NpgsqlCommand sqlCom)
        {

            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@nombre";
            sqlParam.Value = this.Nombre == null ? SqlString.Null : this.Nombre;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@descripcion";
            sqlParam.Value = this.Descripcion == null ? SqlString.Null : this.Descripcion;
            sqlCom.Parameters.Add(sqlParam);
        }


        public void setInsertCommand(OleDbCommand sqlCom)
        {

            OleDbParameter sqlParam = new OleDbParameter();

            sqlParam.ParameterName = "@nombre";
            sqlParam.Value = this.Nombre == null ? SqlString.Null : this.Nombre;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new OleDbParameter();

            sqlParam.ParameterName = "@descripcion";
            sqlParam.Value = this.Descripcion == null ? SqlString.Null : this.Descripcion;
            sqlCom.Parameters.Add(sqlParam);
        }

        public void setSelectCommand(SqlCommand sqlCom)
        {

        }

        public void setSelectCommand(OleDbCommand sqlCom)
        {

        }

        public void setSelectCommand(NpgsqlCommand sqlCom)
        {

        }

        public void fill(Object o, SqlDataReader sqlReader)
        {


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
