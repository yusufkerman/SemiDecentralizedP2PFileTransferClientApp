using FileTransferAppClient.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileTransferAppClient.Utilities
{
    public abstract class Singleton<T> where T : IManager, new()
    {
        //Eğer ilk defa erişim olacaksa T tipinde yeni bir nesne oluşuturulur,
        //zaten oluştuysa mevcut instance döner.
        public static T Instance => 
            _instance == null ? new T() : _instance;

        private static T _instance;
    }
}
