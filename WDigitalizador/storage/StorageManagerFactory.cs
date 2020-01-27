using System;
using System.Collections.Generic;
using System.Text;

namespace WCatalogador.storage
{
    class StorageManagerFactory
    {

        
       static public  IStorageManager getStorageManager(String ss) {

            return new FileSystemSM();



        }
    
    }
}
