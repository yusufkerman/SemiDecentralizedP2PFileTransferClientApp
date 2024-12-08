using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTransferAppClient.Utilities
{
    public abstract class Singleton<T> where T : new()
    {
        //Eğer ilk defa erişim olacaksa T tipinde yeni bir nesne oluşuturulur,
        //zaten oluştuysa mevcut instance döner.
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new T();
                }
                return _instance;
            }
        }
    }
}
