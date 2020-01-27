using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using login;

namespace WConsultas.identity
{
    public interface IdentityChecker
    {
        bool checkUser(login.User usuarioConectado);
        void getPermisos(login.User usuarioConectado);
  
    }
}
