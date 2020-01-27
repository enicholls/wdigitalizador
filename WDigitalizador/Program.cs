using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using log4net;
using log4net.Config;
using CatalogoDBLib.dbmanager;

using WCatalogador.utils;
using login;
using WConsultas.identity;
using Vintasoft.Twain;

namespace WConsultas
{
    static class Program
    {
        static internal Config g_Config;
        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static public User usuarioConectado = new User();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            g_Config = Config.LoadConfigFile();
            XmlConfigurator.Configure(new System.IO.FileInfo("log4net.config.xml"));

            log.Info("Inicio aplicacion");

            TwainGlobalSettings tgs = new TwainGlobalSettings();
            tgs.Register("Eric Nicholls",
                         "ericnichollsv@gmail.com",
                         "ZKAtxlkR8q4Hl71yPLw4UsNkJET8vQzAqSWVAK++xinFMmpG7Z4jruL0YV0/sixaKC7Xdd8n5wYrjm4o5UbbcIXRs0gD1jbyKQIZNQPIshEtxhxTiN0ZFLj9lQ3hjssAN6RZ5CXYi67gcENpbehw7h57+3ee+6VuBCd3iQX2FxUM");


            //if (Program.g_User == null || Program.g_Clave == null)
            //{
            //    MessageBox.Show("Debe ingresar un usuario y clave válidos...",
            //                    "Atención...", MessageBoxButtons.OK);
            //    Application.Exit();
            //    return;
            //}


            // Ojo hay que mejorar esto
            PGEntityManager.sConnStr = Program.g_Config._BaseDeDatosCon;

            if (ConfigChecker.check() != true) {

                MessageBox.Show("Problemas en la configuración. Revise el log.", "Error", MessageBoxButtons.OK);
                return;
            }


            PGEntityManager em = PGEntityManager.getInstance();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoginForm frmL = new LoginForm(usuarioConectado);
            frmL.ShowDialog();

            if (frmL.DialogResult == DialogResult.OK)
            {
                IdentityChecker IChkr = IdentityCheckerFactory.create("");

                Boolean bres = IChkr.checkUser(usuarioConectado);

                if (bres == false)
                {
                    MessageBox.Show("Combinación usuario password inválida.", "Error", MessageBoxButtons.OK);
                    return;
                }
                IChkr.getPermisos(usuarioConectado);

                Application.Run(new QueryForm());

            }

            log.Info("Fin aplicacion");

            PGEntityManager.close();
        }
    }
}
