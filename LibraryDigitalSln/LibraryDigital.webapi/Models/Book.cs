using System.ComponentModel.DataAnnotations;

namespace LibraryDigital.webapi.Models
{
    public class Book
    {
        [Key]
        public int IdBook { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublications { get; set; }
        public string CoverImage { get; set; }
        public int Rating { get; set; }
        public string Review { get; set; }
        public int IdUser { get; set; } // clave foranea del usuario.
    }
}
