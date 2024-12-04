using FrontEnactus.Models;
using FrontEnactus.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrontEnactus
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //using (enactus_dbEntities db = new enactus_dbEntities())
            //{
            //    var list = db.usuarios.ToList();

            //    foreach (var oGente in list)
            //    {
            //        MessageBox.Show(oGente.nombre_usuario);
            //    }
            //}

            var dbSingleton = DbContextSingleton.Instance;
            var listUrs = dbSingleton.usuarios.ToList();
            foreach (var oGente in listUrs)
            {
                MessageBox.Show(oGente.nombre_usuario);
            }

            Application.Run(new Home());


        }
    }
}
