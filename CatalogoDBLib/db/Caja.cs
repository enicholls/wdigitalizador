using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CatalogoDBLib.dbmanager;
using log4net;
using Npgsql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace CatalogoDBLib.db
{
    public class Caja : Entidad
    {



        private static readonly ILog log = LogManager.GetLogger(typeof(Caja));

        String sqlUpdate = " update LibCaja set nro=@nro,descripcion=@descripcion,folio_inicial=@folio_inicial,folio_final=@folio_final, estado=@estado,vigencia=@vigencia,id_uo=@id_uo,id_uo_padre=@id_uo_padre,id_tipodoc=@id_tipodoc  where id=@id ";
        String sqlInsert = " insert into LibCaja (nro,descripcion,folio_inicial,folio_final, estado,vigencia,id_uo,id_tipodoc,id_uo_padre) values (@nro,@descripcion,@folio_inicial,@folio_final,@estado,@vigencia,@id_uo,@id_tipodoc,@id_uo_padre) ";
        static String sqlListSelected = "select ld.id,ld.id_tipo,ld.nro,fecha,ld.codigobarra,ld.stoid, ldc.valor,ldn.nombre,ldc.id,ldn.id_uo,luo.idpadre,ld.estado,ld.desechado " +
                                "from ((LibDocumento ld left join LibDocClase ldc on (ld.id = ldc.id_doc)) left join \"LibDocNivel\" ldn on ( ld.id = ldn.id_doc))  join \"LibUnidadOrganizacional\" luo on (ldn.id_uo = luo.id) " +
                                "where " +
                                "(ld.id_tipo = @id_tipo or @id_tipo = -1 ) " +
                                " and (ld.nro = @nro or @nro='-1') " +
                                " and (ld.estado = @estado or @estado='-1') " +
                                " and (ld.desechado = @desechado or @desechado='-1') " +
                                " and (ldc.valor like @valor or @valor='-1') " +
                                " and (ldn.id_uo = @id_uo or @id_uo=-1) " +
                                " and (luo.idpadre = @id_padre or @id_padre=-1) ";

        //                              "(fecha betweeen @dtIni and @dtFin)";

        String sqlSelectAll = " select id,nro,descripcion,folio_inicial,folio_final, estado,vigencia,id_uo,id_tipodoc,id_uo_padre from  LibCaja where vigencia = 1 ";

        String sqlSelectCajas = " select id,nro,descripcion,folio_inicial,folio_final, estado,vigencia,id_uo,id_tipodoc,id_uo_padre from  LibCaja lc  " + 
                                " where lc.vigencia = 1 " +
                                " and (lc.id_uo = @id_uo or @id_uo = -1 ) " +
                                " and (lc.id_uo_padre = @id_uo_padre or @id_uo_padre='-1') " +
                                " and (ld.id_tipodoc = @id_tipodoc or @id_tipodoc='-1') " ;

        public void setUpdate() { }
        public void setInsert() { }

        private int idTipoDoc;

        public int IdTipoDoc
        {
            get { return idTipoDoc; }
            set { idTipoDoc = value; }
        }


        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        private String nro;

        public String Nro
        {
            get { return nro; }
            set { nro = value; }
        }
        private String descripcion;

        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        private String folio_inicial;

        public String Folio_inicial
        {
            get { return folio_inicial; }
            set { folio_inicial = value; }
        }
        private String folio_final;

        public String Folio_final
        {
            get { return folio_final; }
            set { folio_final = value; }
        }
        private short estado;

        public short Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private short vigencia;

        public short Vigencia
        {
            get { return vigencia; }
            set { vigencia = value; }
        }
        
        private int id_uo;

        public int Id_uo
        {
            get { return id_uo; }
            set { id_uo = value; }
        }

        private int id_uo_padre;

        public int Id_uo_padre
        {
            get { return id_uo_padre; }
            set { id_uo_padre = value; }
        }

        public void fill(Object o, SqlDataReader sqlReader)
        {



        }

        public void fill(Object o, NpgsqlDataReader sqlReader)
        {

            Caja caja = (Caja)o;

            //id,nro,descripcion,folio_inicial,folio_final, estado,vigencia,id_uo,id_tipodoc
            caja.Id = sqlReader.GetInt32(0);
            caja.Id_uo = sqlReader.GetInt32(7);
            caja.Id_uo_padre = sqlReader.GetInt32(9);
            caja.IdTipoDoc = sqlReader.GetInt32(8);
            caja.Nro = sqlReader.GetString(1);
            caja.Vigencia = sqlReader.GetInt16(6);
            caja.Folio_inicial = sqlReader.GetString(3);
            caja.Folio_final = sqlReader.GetString(4);
            caja.Estado = sqlReader.GetInt16(5);
            caja.Descripcion = sqlReader.GetString(2);
            
            //caja.Nombre = sqlReader.GetString(1);
            //caja.Nivel = sqlReader.GetInt16(2);
            //caja.IdPadre = sqlReader.GetInt32(3);
            //caja.Status = sqlReader.GetInt16(4);



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

            sqlParam.ParameterName = "@descripcion";
            sqlParam.Value = this.Descripcion;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@estado";
            if (this.Estado != null) sqlParam.Value = this.Estado;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@folio_final";
            if (this.Folio_final != null) sqlParam.Value = this.Folio_final;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@folio_inicial";
            if (this.Folio_inicial != null) sqlParam.Value = this.Folio_inicial;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_uo";
            if (this.Id_uo != null) sqlParam.Value = this.Id_uo;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_uo_padre";
            if (this.Id_uo_padre != null) sqlParam.Value = this.Id_uo_padre;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@nro";
            if (this.Nro != null) sqlParam.Value = this.Nro;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@vigencia";
            if (this.Vigencia != null) sqlParam.Value = this.Vigencia;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_tipodoc";
            if (this.IdTipoDoc != null) sqlParam.Value = this.IdTipoDoc;
            sqlCom.Parameters.Add(sqlParam);
        }

        public void setUpdateCommand(NpgsqlCommand sqlCom)
        {
            NpgsqlParameter sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@descripcion";
            sqlParam.Value = this.Descripcion;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@estado";
            if (this.Estado != null) sqlParam.Value = this.Estado;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@folio_final";
            if (this.Folio_final != null) sqlParam.Value = this.Folio_final;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@folio_inicial";
            if (this.Folio_inicial != null) sqlParam.Value = this.Folio_inicial;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_uo";
            if (this.Id_uo != null) sqlParam.Value = this.Id_uo;
            sqlCom.Parameters.Add(sqlParam);


            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_uo_padre";
            if (this.Id_uo_padre != null) sqlParam.Value = this.Id_uo_padre;
            sqlCom.Parameters.Add(sqlParam);
            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@nro";
            if (this.Nro != null) sqlParam.Value = this.Nro;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@vigencia";
            if (this.Vigencia != null) sqlParam.Value = this.Vigencia;
            sqlCom.Parameters.Add(sqlParam);

            sqlParam = new NpgsqlParameter();

            sqlParam.ParameterName = "@id_tipodoc";
            if (this.IdTipoDoc != null) sqlParam.Value = this.IdTipoDoc;
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


        }

        public void setSelectxNivelCommand(NpgsqlCommand sqlCom)
        {

        }


        public void setSelectHijosTDxIdCommand(NpgsqlCommand cmd)
        {

        }



        public String getUpdate() { return sqlUpdate; }
        public String getInsert() { return sqlInsert; }
        public String getSelect() { return String.Empty; }
        public String getSelectAll() { return sqlSelectAll; }
        public String getSelectxNivel() { return String.Empty; }
        public String getSelectHijosxId() { return String.Empty; }
        public String getSelectHijosTDxId() { return String.Empty; }




    }
}
