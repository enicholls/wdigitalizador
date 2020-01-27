using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
 
namespace WCatalogador.utils
{
    class StatusApp
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(StatusApp));


        public const String SINCONEXIONABD = "Sin conexión a Base de Datos";

        private static StatusApp miStausApp = null;

        private StatusApp()
        {
        
        
        
        }

        IList<String> statusHistory = new List<String>();

        String currentStatus;

        public String CurrentStatus
        {
            get { return currentStatus; }
            set { currentStatus = value; }
        }


        public void Add(String s)
        {

            currentStatus = s;
            statusHistory.Add(s);

        }

        static public StatusApp getInstance()
        {
        
        
            if (miStausApp == null){

                miStausApp = new StatusApp();

            }


            return miStausApp;
        
        }

    }
}
