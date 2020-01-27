using CatalogoDBLib.dbmanager;
using CatalogoDBLib.db;
using System.Collections.Generic;
using System;
using WConsultas.identity;
namespace login
{
	/// <summary>
	/// Información básica del usuario. Objeto base entregado por cualquier 
	/// Assembly de verificación si es válido.
	/// (Ver <i>Biokey.BioCheck.Login.NativeLogin</i> para mas detalles).
	/// </summary>
	public class User
	{
		/// <summary>
		/// Constructor base.
		/// </summary>
		public User() { }
		
		/// <summary>
		/// Constructor con todos los datos básicos.
		/// </summary>
		/// <param name="userid">User ID del Usuario</param>
		/// <param name="clave">Clave del Usuario</param>
		/// <param name="tipoid">Tipo de id del usuario (ej.: RUT)</param>
		/// <param name="nroid">Nro de id del usuario (ej.: Nro de RUT)</param>
		/// <param name="nombre">Nombre del usuario</param>
		/// <param name="apellidoPaterno">Apellido del usuario</param>
		/// <param name="perfil">Perfil del Usuario</param>
        /// 
		public  User(string userid,string clave,string tipoid,
            string nroid, string nombre, string apellidoPaterno, string apellidoMaterno,
			int perfil, int iddepto)
		{
			_userid = userid; 
			_clave = clave;
			_tipoid = tipoid;
			_nroid = nroid;
			_nombre = nombre;
			_apellidoPaterno = apellidoPaterno;
			_perfil = perfil;
            _iddepto = iddepto;
		}
		
		private string _userid;
		private string _clave;
		private string _tipoid;
		private string _nroid;
		private string _nombre;
        private string _apellidoPaterno;
        private string _apellidoMaterno;

        public string ApellidoMaterno
        {
            get { return _apellidoMaterno; }
            set { _apellidoMaterno = value; }
        }
        private int _perfil;
        private int _iddepto;

        public int Iddepto
        {
            get { return _iddepto; }
            set { _iddepto = value; }
        }

        private string[] _permisos;

        public string[] Permisos
        {
            get { return _permisos; }
            set { _permisos = value; }
        }


        private int[] _subdeptos;

        public int[] Subdeptos
        {
            get { return _subdeptos; }
            set { _subdeptos = value; }
        }
        
        /// <summary>
		/// User ID del Usuario
		/// </summary>
		public string userid
		{
			get { return _userid; }
			set { _userid = value; }
		}

		/// <summary>
		/// Clave del usuario
		/// </summary>
		public string clave
		{
			get { return _clave; }
			set { _clave = value; }
		}

		/// <summary>
		/// Tipo de id del usuario (ej.: RUT)
		/// </summary>
		public string tipoid
		{
			get { return _tipoid; }
			set { _tipoid = value; }
		}

		/// <summary>
		/// Número de id del usuario (Ej.: número de RUT).
		/// </summary>
		public string nroid
		{
			get { return _nroid; }
			set { _nroid = value; }
		}


        private string _fullname;

        public string fullname
        {
            get { return (_nombre == null ? _userid : _nombre) + " " + (_apellidoPaterno == null ? " " : _apellidoPaterno) + " " + (_apellidoMaterno == null ? " " : _apellidoMaterno); }
        }


		/// <summary>
		/// Nombre del usuario
		/// </summary>
		public string nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

		/// <summary>
		/// Apellido del usuario
		/// </summary>
		public string ApellidoPaterno
		{
			get { return _apellidoPaterno; }
			set { _apellidoPaterno = value; }
		}

		/// <summary>
		/// Perfil del usuaio entre dos opciones básicas:
		/// <list type="number">
		///		<item>0 = Adminitrador : Tiene acceso a la zona de configuración</item>
		///		<item>1 = Operador : NO Tiene acceso a la zona de configuración</item>
		/// </list>
		/// </summary>
		public int perfil
		{
			get { return _perfil; }
			set { _perfil = value; }
		}





        internal bool CheckPermiso(CatalogoDBLib.DocumentoClsNivel unDocumento)
        {


            bool isAdmin = true;

            foreach (enumPermisos.permiso MyEnum in Enum.GetValues(typeof(enumPermisos.permiso)))
            {

                isAdmin = isAdmin && (this.Permisos[(int)MyEnum] ==  "1" );



            }

            if (isAdmin) return true;


            bool sonTodosCeros = true;
            if (unDocumento.Ldn_id_uopadre != this.Iddepto)
            {
                sonTodosCeros = false;
            }
            else
            {

                if (this.Subdeptos == null) return true;


                foreach (int idSubDepto in this.Subdeptos)
                {

                    if (idSubDepto != 0)
                    {
                        sonTodosCeros = false;
                    }

                    if (idSubDepto == unDocumento.Ldn_id_uo) return true;
                }

            }
            return sonTodosCeros;
        }


        internal bool CheckPermiso(CatalogoDBLib.DocumentoClsNivel unDocumento, List<Entidad> lstDeptos)
   {


       bool isAdmin = true;

       foreach (enumPermisos.permiso MyEnum in Enum.GetValues(typeof(enumPermisos.permiso)))
       {

           isAdmin = isAdmin && (this.Permisos[(int)MyEnum] == "1");

       }

       if (isAdmin) return true;

            
            bool sonTodosCeros = true;


            if (unDocumento.Ldn_id_uopadre != this.Iddepto)
            {
                sonTodosCeros = false;
            }
            else
            {

                if (this.Subdeptos == null) return true;


                foreach (int idSubDepto in this.Subdeptos)
                {

                    if (idSubDepto != 0)
                    {
                        sonTodosCeros = false;
                    }

                    if (idSubDepto == unDocumento.Ldn_id_uo) return true;
                }

            }
            return sonTodosCeros;
        }
    }



}
