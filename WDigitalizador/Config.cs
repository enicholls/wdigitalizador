using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using System.Xml.Serialization;
using System.IO;

namespace WConsultas
{
	/// <summary>
	/// Clase para manejar parámetros de funcionamiento. Es serializable, para 
	/// faclitar las actualizaciones y lectura.
	/// </summary>
	[Serializable]
    public class Config
    {
		/// <summary>
		/// Variable estática para enviar información al log de ejecución. 
		/// Ver para detalles log4net.
		/// </summary>
		private static readonly ILog log = 
			LogManager.GetLogger(typeof(Config));
    	
		/// <summary>
		/// Constructor de la clase.
		/// </summary>
        public Config() { }

		/// <summary>
		/// Path temporal para escaneo en PC local
		/// </summary>
		public string _PathTmpLocal = @"c:\tmp\TmpLocal";
        
        /// <summary>
        /// Path para envio en server central
        /// </summary>
        public string _PathTmpStorage = @"c:\tmp\Storage";

        /// <summary>
        /// Conexión a Base de Datos
        /// </summary>
//        public string _BaseDeDatosCon = @"Data Source=ERIC-PCASUS\sqlexpress;Initial Catalog=Libros;Integrated Security=True;Pooling=False";
//        public string _BaseDeDatosCon = @"Provider=PostgreSQL;Data Source=localhost;location=catalogo;User id=postgres;password=abc123;";
        public string _BaseDeDatosCon = @"Server=localhost;port=5432;Database=catalogo_dig;User id=eric;password=eric1961;";


        /// <summary>
        /// Id del Dominio que corresponde a Tipo Documento
        /// </summary>
        public int _DomTipoDoc = 2;

        /// <summary>
        /// Id del Dominio que corresponde a Referencia
        /// </summary>
        public int _DomReferencia = 0;

        /// <summary>
        /// Flag para indicar si la página del código se guarda
        /// </summary>
        public Boolean _saveCode = false;


        /// <summary>
        /// Path temporal para escaneo en PC local
        /// </summary>
        public string _PathArcClasificar = @"c:\tmp\TmpLocal\reconocidos";
        /// <summary>
        /// Path temporal para escaneo en PC local
        /// </summary>
        public string _PathToSend = @"c:\tmp\ToSend";
        /// <summary>
        /// Path temporal para escaneo en PC local
        /// </summary>
        public string _PathSended = @"c:\tmp\Sended";
        /// <summary>
        /// Path para envio en server central
        /// </summary>
        public string _PathToSendNetwork = @"z:\temp\ToSend";

        /// <summary>
        /// Nombre scanner a utilizar
        /// </summary>
        public string _Escaner = "Canon MX310 ser";
        /// <summary>
        ///   # [Color | Grises (Escala) | BW (Blanco y Negro)]
        /// </summary>
        public string _PixelType = "Grises";
        /// <summary>
        /// Formato de las horas en BCHK, para evitar errores en consultas.
        /// </summary>
        public int _DPI = 300;

        /// <summary>
        /// Formato de documento final [TIF | PDF].
        /// </summary>
        public string _FinalType = "PDF";

        /// <summary>
        /// Contraste - Default=Valor medio
        /// </summary>
        public int _Contraste = 5;

        /// <summary>
        /// Brillo - Default=Valor medio
        /// </summary>
        public int _Brillo = 5;

        /// <summary>
        /// Contraste Detect Blank Page - Default=Valor medio
        /// </summary>
        public int _ContrasteDBP = 5;


        /// <summary>
        /// PageSize - Default=Carta
        /// </summary>
        public string _PageSize = "Carta";

   



		/// <summary>
		/// Método para informnar todos los parámetros configurados.
		/// </summary>
		/// <returns>String conteniendo los parámetros configurados.</returns>
		public override string ToString()
		{
			XmlSerializer ser = new XmlSerializer(typeof(Config));
			using (StringWriter wrt = new StringWriter())
			{
				ser.Serialize (wrt, this);
				wrt.Close ();
				return wrt.ToString ();
			}
		}
    	
		
		/// <summary>
		/// Método para serializar os parámetros configurados, en un archivo XML
		/// llamado <i>Digitalizador.config.xml</i>. Deja constancia en el log
		/// de operaciones global en cas de producirse errores.
		/// </summary>
		/// <param name="obj">Objeto del tipo Config, con los valores actuales 
		/// configurados</param>
		/// <returns>Reorna true si grabó bien el archivo XML llamado 
        /// <i>Digitalizador.xml</i> en el mismo directorio del ejecutable
        /// <i>Digitalizador.exe</i>. Falso en caso contrario.</returns>
		public static bool SaveConfigFile(Config obj) 
		{
			bool bRes = false;

			try 
			{
				XmlSerializer serializer = new XmlSerializer(typeof(Config));
                TextWriter writer = new StreamWriter("IDSoft.config.xml");
				serializer.Serialize(writer, obj);
				writer.Close();
				bRes = true;
			} 
			catch (Exception ex) 
			{
				log.Error("Error al Serializar archivo de configuracion",ex);
				bRes = false;
			}
			return bRes;		
		}

		
		/// <summary>
		/// Método para la lectura y serializacióin de los parámetros configurados 
        /// en el archivo <i>Digitalizador.config.xml</i>, ubicado en el mismo 
        /// directorio del ejecutable <i>Digitalizador.exe</i>. Deja constancia en el log
		/// de operaciones global en cas de producirse errores.
		/// </summary>
        /// <returns>Objeto del tipo Digitalizador.Config con los parámetros 
		/// leídos o un objeto con los parámetors fijos por default en caso de error
		/// </returns>
		public static Config LoadConfigFile() 
		{
			Config cf = null;
			try 
			{
				XmlSerializer serializer = new XmlSerializer(typeof(Config));
				TextReader reader = new StreamReader("IDSoft.config.xml");
				cf = (Config)serializer.Deserialize(reader);
				reader.Close();
			} 
			catch (Exception ex) 
			{
                log.Error("Error leyendo IDSoft.config", ex);
				return new Config();
			}

			if (cf == null) cf = new Config();

			return cf;
		}





    }
}
