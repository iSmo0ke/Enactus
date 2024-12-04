using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace FrontEnactus.Models
{
    public class InventarioContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public InventarioContext() : base("name=DB_Conexion") { }
        public DbSet<productos> Productos { get; set; }
        public DbSet<proveedores> Proveedores { get; set; }
        public DbSet<pedidos> Pedidos { get; set; }
        public DbSet<detalles_pedidos> DetallesPedidos { get; set; }
        public DbSet<categorias> Categorias { get; set; }


    }
}
