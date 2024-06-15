using System.ComponentModel.DataAnnotations;

namespace practica3.Models
{
    public class EDITORIAL
    {
        [Key]
        public int IDEditorial { get; set; }
        public string Editorial { get; set; }
        public string  Nombre_del_contacto  { get; set; }
        public string Direccion { get; set; }
        public string Ciudad  { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public string Comentario{ get; set; }
        


    }
}
