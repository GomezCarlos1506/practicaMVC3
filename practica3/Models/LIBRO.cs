using System.ComponentModel.DataAnnotations;

namespace practica3.Models
{
    public class LIBRO
    {
        [Key]

        public int IDLibro { get; set; }
        public string  ISBN { get; set; }
        public string TITULO  { get; set; }
        public string AUTOR { get; set; }
        public int IDEditorial { get; set; }
        public int Año { get; set; }
        public Decimal PRECIO {  get; set; }
        public string COMENTARIOS { get; set; }
        public string FOTO { get; set; }

    }
}
