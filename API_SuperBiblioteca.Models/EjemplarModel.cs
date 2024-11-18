using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_SuperBiblioteca.Models
{
    public class EjemplarModel
    {
        public int EjemplarId { get; set; }
        public string Ubicacion { get; set; }
        public bool Disponibilidad { get; set; }
        public LibroModel Libro { get; set; }
        public int? PrestamoId { get; set; }
    }
}
