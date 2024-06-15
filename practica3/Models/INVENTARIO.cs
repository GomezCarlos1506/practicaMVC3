using System.ComponentModel.DataAnnotations;

namespace practica3.Models
{
    public class INVENTARIO
    {
        [Key]
        public int IDinventario { get; set; }
        public int IDLibro { get; set; }
        public int IDSucursal { get; set; }
        public int Existencia { get; set; }

    }
}
