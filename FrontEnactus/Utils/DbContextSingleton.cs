using FrontEnactus.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnactus.Utils
{
    public class DbContextSingleton
    {
        //Variable estatica para la unica instancia
        private static enactus_dbEntities _instance;

        // Objeto para no crear instancias simultaneamente
        private static readonly object _lock = new object();

        // Constructor privado para evitar instancias directas
        private DbContextSingleton() { }

        public static enactus_dbEntities Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new enactus_dbEntities();
                    }
                    return _instance;
                }
            }
        }
    }
}
