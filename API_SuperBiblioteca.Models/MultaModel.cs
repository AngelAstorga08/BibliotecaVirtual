using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_SuperBiblioteca.Models
{
    public class MultaModel
    {
        public int MultaId { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaMulta { get; set; }
        public PrestamoModel Prestamo { get; set; }
    }
}
