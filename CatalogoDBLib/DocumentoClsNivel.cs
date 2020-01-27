using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CatalogoDBLib.db;

namespace CatalogoDBLib
{
    public class DocumentoClsNivel
    {

        Documento miDocumento;

        public Documento MiDocumento
        {
            get { return miDocumento; }
            set { miDocumento = value; }
        }
        int ldc_id;

        public int Ldc_id
        {
            get { return ldc_id; }
            set { ldc_id = value; }
        }

        int ldn_id_uopadre;

        public int Ldn_id_uopadre
        {
            get { return ldn_id_uopadre; }
            set { ldn_id_uopadre = value; }
        }

        int ldn_id_uo;

        public int Ldn_id_uo
        {
            get { return ldn_id_uo; }
            set { ldn_id_uo = value; }
        }

        String stoId;

        public String StoId
        {
            get { return stoId; }
            set { stoId = value; }
        }
    }
}
