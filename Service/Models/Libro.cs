using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Service.Models
{
    public class Libro
    {
        public int Id { get; set; }
        [Required]
        public string Titulo { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public int EditorialId { get; set; } = 1;
        public Editorial? Editorial { get; set; }
        [Required]
        public int Paginas { get; set; } = 0;
        public int AnioPublicacion { get; set; } = 0;
        public string Portada { get; set; } = string.Empty;
        [Required]  
        [Column(TypeName = "text")]
        public string Sinopsis { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;

        virtual public ICollection<LibroAutor> LibroAutores { get; set; } = new List<LibroAutor>();
        virtual public ICollection<LibroGenero> LibroGeneros { get; set; } = new List<LibroGenero>();
        public override string ToString()
        {
            return Titulo;
        }
    }
}
