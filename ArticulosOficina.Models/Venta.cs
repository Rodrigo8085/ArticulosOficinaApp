using System.ComponentModel.DataAnnotations;

namespace ArticulosOficina.Models
{
    public class Venta
    {
        [Key]
        public int IdVenta { get; set; }

        public required int Cantidad { get; set; }

        public required DateTime Fecha { get; set; }


    }
}
