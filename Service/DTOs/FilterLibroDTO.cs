using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.DTOs
{
    public class FilterLibroDTO
    {
        //Buscar texto en titulo, autor, editorial o genero. 
        public string SearchText { get; set; } = "";
        public bool ForTitulo { get; set; } = false;
        public bool ForAutor { get; set; } = false;
        public bool ForEditorial { get; set; } = false;
        public bool ForGenero { get; set; } = false;
    }
}
