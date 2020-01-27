using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CatalogoDBLib.dbmanager;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.OleDb;
using Npgsql;
using NpgsqlTypes;

namespace CatalogoDBLib.db
{
    public class UnidadOrganizacional:Entidad
    {
        
        Int32 id;

        Int32 status;

        public Int32 Status
        {
            get { return status; }
            set { status = value; }
        }

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        Int32 idPadre;

        public Int32 IdPadre
        {
            get { return idPadre; }
            set { idPadre = value; }
        }


        String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        Int32 nivel;

        public Int32 Nivel
        {
            get { return nivel; }
            set { nivel = value; }
        }

        String sqlUpdate         = " update LibUnidadOrganizacional  set idpadre=@idpadre,nivel=@nivel,nombre=@nombre,status=@status where id =@id";
        String sqlInsert = " insert into LibUnidadOrganizacional (idpadre,nivel,nombre,estado) values (@idpadre,@nivel,@nombre,@status) ";
        String sqlSelect = " SELECT id, nombre, nivel, idpadre,estado  FROM LibUnidadOrganizacional where id = @id or @id=-1";
        String sqlSelectHijosxId = " SELECT id, nombre, nivel, idpadre,estado  FROM LibUnidadOrganizacional where idpadre = @idpadre ";

        public String SqlSelectHijosxId
        {
            get { return sqlSelectHijosxId; }
            set { sqlSelectHijosxId = value; }
        }
        String sqlSelectxNivel = " SELECT id, nombre, nivel, idpadre,estado  FROM LibUnidadOrganizacional where nivel = @nivel ";

        public String SqlSelectxNivel
        {
            get { return sqlSelectxNivel; }
            set { sqlSelectxNivel = value; }
        }


        String sqlSelectAll = " select id,id_dominio,valor,estado from  LibValor where id_dominio = @id_dominio";


        public void setUpdate() { }
        public void setInsert() { }

        public void fill(Object o, SqlDataReader sqlReader)
        {



        }

        public void fill(Object o, NpgsqlDataReader sqlReader)
        {

            UnidadOrganizacional uo = (UnidadOrganizacional)o;

            //id, nombre, nivel, idpadre
            uo.Id       = sqlReader.GetInt32(0);
            uo.Nombre   = sqlReader.GetString(1);
            uo.Nivel    = sqlReader.GetInt32(2);
            uo.IdPadre  = sqlReader.GetInt32(3);
            uo.Status   = sqlReader.GetInt32(4);



        }


        public void fill(Object o, OleDbDataReader sqlReader)
        {


        }



        public void setInsertCommand(SqlCommand sqlCom)
        {

        }

        public void setInsertCommand(OleDbCommand sqlCom)
        {

        }

        public void setInsertCommand(NpgsqlCommand sqlCom)
        {
            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@idpadre";
            sqlParam.Value = this.IdPadre;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@nivel";
            if (this.Nivel != null) sqlParam.Value = this.nivel;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@nombre";
            if (this.Nombre != null) sqlParam.Value = this.Nombre;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@status";
            if (this.Nombre != null) sqlParam.Value = this.Status;
            sqlCom.Parameters.Add(sqlParam);

        }

        public void setUpdateCommand(NpgsqlCommand sqlCom)
        {
            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@idpadre";
            sqlParam.Value = this.IdPadre;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@nivel";
            if (this.Nivel != null) sqlParam.Value = this.nivel;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@nombre";
            if (this.Nombre != null) sqlParam.Value = this.Nombre;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id";
            if (this.Id != null) sqlParam.Value = this.Id;
            sqlCom.Parameters.Add(sqlParam);
        }

        public void setSelectCommand(OleDbCommand sqlCom)
        {


        }


        public void setSelectCommand(SqlCommand sqlCom)
        {


        }



        
        public void setSelectCommand(NpgsqlCommand sqlCom)
        {

            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id";

            if (this.Id != null) sqlParam.Value = this.Id;
            sqlCom.Parameters.Add(sqlParam);

        }


        public void setSelectHijosxIdCommand(NpgsqlCommand sqlCom)
        {

            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@idpadre";

            if (this.Id != null) sqlParam.Value = this.IdPadre;
            sqlCom.Parameters.Add(sqlParam);

        }

        public void setSelectxNivelCommand(NpgsqlCommand sqlCom)
        {

            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@nivel";

            if (this.Nivel != null) sqlParam.Value = this.Nivel;
            sqlCom.Parameters.Add(sqlParam);

        }


        public void setSelectHijosTDxIdCommand(NpgsqlCommand cmd)
        {

        }



        public String getUpdate() { return sqlUpdate; }
        public String getInsert() { return sqlInsert; }
        public String getSelect() { return sqlSelect; }
        public String getSelectAll() { return sqlSelectAll; }
        public String getSelectxNivel() { return sqlSelectxNivel; }
        public String getSelectHijosxId() { return SqlSelectHijosxId; }
        public String getSelectHijosTDxId() { return String.Empty; }



    }
}
