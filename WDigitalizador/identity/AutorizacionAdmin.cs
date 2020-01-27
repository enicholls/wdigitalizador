using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WConsultas.identity
{
    public class AutorizacionAdmin
    {

        public static bool check(enumPermisos.permiso permiso, login.User user)
        {
            Boolean res = true;

            if (user.Permisos == null) return false;
            if (user.Permisos.Length <= (int)permiso) return false;



            res = user.Permisos[(int)permiso] == "1";

            return res;

        }
    }
}
