using System.ComponentModel.DataAnnotations;

namespace ArticulosOficina.Models
{
    public class Tienda
    {
        [Key]
        public int IdTienda{ get; set; }

        public required string Sucursal { get; set; }

        public required string Direccion { get; set; }
    }
}
