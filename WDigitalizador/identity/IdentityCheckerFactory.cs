using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WConsultas.identity
{
    public class IdentityCheckerFactory
    {

        public static IdentityChecker create(String tipo) {

            return new FileSystemEntityChecker();

        }

  }

}
