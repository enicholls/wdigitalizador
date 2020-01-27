using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace WConsultas.identity
{
    public class enumPermisos
    {
        public enum permiso { consultar = 0, catalogar, escanear, editar, configurar};

        public static String getNombre(permiso p) {


            switch (p) {
            
                case enumPermisos.permiso.consultar:

                    return "Consultar";

                case enumPermisos.permiso.catalogar:

                    return "Catalogar";
                case enumPermisos.permiso.escanear:

                    return "Escanear";
                case enumPermisos.permiso.editar:

                    return "Editar";
                case enumPermisos.permiso.configurar:

                    return "Configurar";
            
            }

            return "Error";
        
        
        }
    }
}
