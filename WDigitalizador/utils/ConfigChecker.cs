using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using log4net;
using CatalogoDBLib.dbmanager;
using WConsultas;

namespace WCatalogador.utils
{
    public class ConfigChecker
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(ConfigChecker));

        public static Boolean check() {

            Boolean bres = true;

            bres = bres && checkDir();
            bres = bres && checkDB();



            return bres;

        }

        static Boolean checkDir()
        {


            Boolean bres = Directory.Exists(Program.g_Config._PathTmpLocal);

            if (bres == false) {

                log.Error("Directorio  inexistente: " + Program.g_Config._PathTmpLocal );
            }

            return bres;

        }

        static Boolean checkDB()
        {

            PGEntityManager em = PGEntityManager.getInstance();

            if (PGEntityManager.Conn == null)
            {

                log.Error("COnexion con problemas: " + Program.g_Config._BaseDeDatosCon);
                return false;
            }
            else
            {
                return true;
            }

        }
    
    }
}
