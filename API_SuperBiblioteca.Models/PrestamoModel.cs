using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_SuperBiblioteca.Models
{
    public class PrestamoModel
    {
        public int PrestamoId { get; set; }
        public DateTime FechaPrestamo { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public EjemplarModel Ejemplar { get; set; }
        public UsuarioModel Usuario { get; set; }
        public MultaModel Multa { get; set; }
    }
}
