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
        // Instancia privada estática
        private static enactus_dbEntities _instance;

        // Objeto para manejo de concurrencia en aplicaciones multihilo
        private static readonly object _lock = new object();

        // Constructor privado para evitar instancias directas
        private DbContextSingleton() { }

        // Propiedad para obtener la única instancia
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
