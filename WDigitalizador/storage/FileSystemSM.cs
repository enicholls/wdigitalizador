using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using WConsultas;

namespace WCatalogador.storage
{
    public class FileSystemSM : IStorageManager
    {
        public string save(string filepath)
        {
        
            string filename = Path.GetFileName(filepath);
            string sPath    =  Program.g_Config._PathTmpStorage + "\\" + filename;
 
            File.Move(filepath,sPath);

            return sPath;

        }

    }
}
