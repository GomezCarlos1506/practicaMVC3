using System.ComponentModel.DataAnnotations;

namespace practica3.Models
{
    public class SUCURSAL
    {
        [Key]
        public int IDSucursal { get; set; }
        public string Sucursal { get; set; }
        public string Nombre_del_encargado { get; set; }
        public string Direccion { get; set; }
        public string Ciudad{ get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public string comentario { get; set; }
    }
}
