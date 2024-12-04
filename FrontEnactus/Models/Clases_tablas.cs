using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FrontEnactus.Models
{
    [Table("usuarios")]
    public class Usuario
    {
        [Key]
        [Column("Id")] // Mapea la propiedad a la columna específica
        public int Id { get; set; }

        [Column("nombre_usuario")]
        public string NombreUsuario { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("permisos")]
        public int Permisos { get; set; }
    }

    public class proveedores 
    {
        public int Id { get; set; }
        public string nombre { get; set; }
        public string contacto { get; set; }
        public string direccion { get; set; } 
    }

    public class productos 
    { 
       public int Id { get; set; }
       public string nombre_producto { get; set; }
        public string descripcion_producto { get; set; }
        public string id_rfid { get; set; }
        public DateTime fecha_caducidad { get; set; }
        public int cantidad { get; set; }
        public string ubicacion { get; set; }

    }

    public class pedidos
    {
        public int Id { get; set; }
        public int id_usuario { get; set; }
        public DateTime fecha_pedido { get; set; }
        public string estado { get; set; }
    }

    public class detalles_pedidos 
    {
        public int Id { get; set; }
        public int id_pedido { get; set; }
        public int id_producto { get; set; }
        public int cantidad { get; set; }
    }

    public class categorias
    {
        public string Id { get; set; }
        public string nombre_categoria { get; set; }
    }
    
}
