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
    public class TipoDocumentoNivel : Entidad
    {

        String sqlUpdate = "";
        String sqlInsert = " insert into LibTipoDocNivel(id_tipodoc,id_uo,nombre) values (@id_tipodoc,@id_uo,@nombre) ";
        String sqlSelectHijosTDxId = " SELECT id,id_tipodoc,id_uo, nombre FROM LibTipoDocNivel where id_uo = @id_uo ";

        public String SqlSelectHijosTDxId
        {
            get { return sqlSelectHijosTDxId; }
            set { sqlSelectHijosTDxId = value; }
        }
        
        public void setUpdate() {}
        public void setInsert() { }

        public void setInsertCommand(SqlCommand sqlCom)
        {

            SqlParameter sqlParam = new SqlParameter();

            sqlParam.ParameterName = "@id_tipodoc";
            sqlParam.Value = this.Id_tipodoc;
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

            sqlParam.ParameterName = "@id_tipodoc";
            sqlParam.Value = this.Id_tipodoc;
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

            sqlParam.ParameterName = "@id_tipodoc";
            sqlParam.Value = this.Id_tipodoc;
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

        
        public void setInsertCommand(OleDbCommand sqlCom)
        {

            OleDbParameter sqlParam = new OleDbParameter();

            sqlParam.ParameterName = "@id_tipodoc";
            sqlParam.Value = this.Id_tipodoc;
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

        private Int32 id_tipodoc;

        public Int32 Id_tipodoc
        {
            get { return id_tipodoc; }
            set { id_tipodoc = value; }
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        public static int TIPO_DESCONOCIDO = 0;

        private string sqlSelect;
        private string sqlSelectAll;



        public void fill(Object o, SqlDataReader sqlReader)
        {


        }
        public void fill(Object o, OleDbDataReader sqlReader)
        {


        }

        public void fill(Object o, NpgsqlDataReader sqlReader)
        {

            TipoDocumentoNivel tuo = (TipoDocumentoNivel)o;

            //id,id_tipodoc,id_uo, nombre 
            tuo.Id          = sqlReader.GetInt32(0);
            tuo.Id_tipodoc  = sqlReader.GetInt32(1);
            tuo.Id_uo       = sqlReader.GetInt32(2);
            tuo.Nombre      = sqlReader.GetString(3);

        }


        public void setSelectCommand(NpgsqlCommand sqlCom) { }

        public void setSelectCommand(SqlCommand sqlCom) { }
        public void setSelectCommand(OleDbCommand sqlCom) { }

        public String getSelect() { return sqlSelect; }
        public String getSelectAll() { return sqlSelectAll; }
        public String getSelectxNivel() { return String.Empty; }
        public String getSelectHijosxId() { return String.Empty; }
        public String getSelectHijosTDxId() { return SqlSelectHijosTDxId; }


        public void setSelectHijosxIdCommand(NpgsqlCommand sqlCom)
        {

        }

        public void setSelectxNivelCommand(NpgsqlCommand sqlCom)
        {

        }

        public void setSelectHijosTDxIdCommand(NpgsqlCommand cmd)
        {

            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_uo";

            if (this.Id != null) sqlParam.Value = this.Id_uo;
            cmd.Parameters.Add(sqlParam);

        }

    
    }
}
