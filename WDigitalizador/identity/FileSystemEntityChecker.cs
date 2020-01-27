using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Collections;
using login;

namespace WConsultas.identity
{
    public class FileSystemEntityChecker:IdentityChecker
    {
    
        static User[] _directorioUsuarios = LoadUsersFile();

        public static User[] getDirectorio(){

            return _directorioUsuarios;

        }
            


        public void getPermisos(login.User usuarioConectado) 
        {
                //usuarioConectado.Permisos = null;
                //try
                //{
                //    XmlSerializer serializer = new XmlSerializer(typeof(String[]));
                //    TextReader reader = new StreamReader(usuarioConectado.userid +"permisos.users.xml");
                //    usuarioConectado.Permisos = (string[])serializer.Deserialize(reader); 
                //    reader.Close();
                //}
                //catch (Exception ex)
                //{
                //    //                log.Error("Error leyendo IDSoft.config", ex);
                //    return;
                //}

        }


        public bool SavePermisos(login.User usuarioConectado)
        {
            bool bRes = false;

            try
            {

                XmlSerializer mySerializer = new XmlSerializer(typeof(string[]));
                StreamWriter myWriter = new StreamWriter(usuarioConectado.userid + "permisos.users.xml");
                mySerializer.Serialize(myWriter, usuarioConectado.Permisos);
                myWriter.Close();
                bRes = true;

            }
            catch (Exception ex)
            {
                //                log.Error("Error al Serializar archivo de configuracion", ex);
                bRes = false;
            }
            return bRes;
        }


        public bool checkUser(login.User usuarioConectado){
        {
            String sPwd;

            foreach (User u in _directorioUsuarios) {

                if (u.userid.CompareTo(usuarioConectado.userid) == 0) {

                    if (u.clave.CompareTo(usuarioConectado.clave) == 0)
                    {
                        usuarioConectado.ApellidoPaterno = u.ApellidoPaterno;
                        usuarioConectado.nombre = u.nombre;
                        usuarioConectado.nroid = u.nroid;
                        usuarioConectado.perfil = u.perfil;
                        usuarioConectado.Permisos = u.Permisos;
                        usuarioConectado.tipoid = u.tipoid;
                        usuarioConectado.Iddepto = u.Iddepto;
                        usuarioConectado.Subdeptos = u.Subdeptos;

                        return true;
                    }
                    else {

                        return false;
                    }
                        
                }
                
            }
        }        

        return false;
    }



        public static User[] LoadUsersFile()
        {
            User[] cf = null;
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(User[]));
                TextReader reader = new StreamReader("IDSoft.users.xml");
                cf = (User[])serializer.Deserialize(reader);
                reader.Close();
            }
            catch (Exception ex)
            {
                //                log.Error("Error leyendo IDSoft.config", ex);
                return new User[1];
            }

            if (cf == null) cf = new User[1];

            return cf;
        }

        public static bool SaveUsersFile(User[] _arrayUsers)
        {
            bool bRes = false;

            try
            {
 
                XmlSerializer mySerializer = new XmlSerializer(typeof(User[]));
                StreamWriter myWriter = new StreamWriter("IDSoft.users.xml");
                mySerializer.Serialize(myWriter, _arrayUsers);
                myWriter.Close();
                bRes = true;
            
            }
            catch (Exception ex)
            {
//                log.Error("Error al Serializar archivo de configuracion", ex);
                bRes = false;
            }
            return bRes;
        }


    }
}
