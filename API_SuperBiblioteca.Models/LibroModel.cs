using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_SuperBiblioteca.Models
{
    public class LibroModel
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public string NombreTipo { get; set; }
        public string NombreGenero { get; set; }
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int AnoPublicacion { get; set; }
        public string ISBN { get; set; }
        public string Imagen { get; set; }
        public List<EjemplarModel> Ejemplares { get; set; }
    }
}
