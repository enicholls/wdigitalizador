using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Data.OleDb;
using Npgsql;

namespace CatalogoDBLib.dbmanager
{
    public interface Entidad
    {

        void setUpdate();
        void setInsert();
        String getUpdate();
        String getInsert();
        String getSelect();
        String getSelectAll();

        String getSelectxNivel();
        String getSelectHijosxId();
        String getSelectHijosTDxId();

        void setInsertCommand(SqlCommand sqlCom);
        void setInsertCommand(OleDbCommand sqlCom);
        void setInsertCommand(NpgsqlCommand sqlCom);
        void setUpdateCommand(NpgsqlCommand sqlCom);
        void setSelectCommand(SqlCommand sqlCom);
        void setSelectCommand(NpgsqlCommand sqlCom);
        void setSelectCommand(OleDbCommand sqlCom);
        void setSelectHijosxIdCommand(NpgsqlCommand sqlCom);
        void setSelectxNivelCommand(NpgsqlCommand sqlCom);
        void fill(Object o, SqlDataReader sqlReader);
        void fill(Object o, OleDbDataReader sqlReader);
        void fill(Object o, NpgsqlDataReader sqlReader);

        void setSelectHijosTDxIdCommand(NpgsqlCommand cmd);

        
    }
}
