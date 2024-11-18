using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_SuperBiblioteca.Models
{
    public class UsuarioModel
    {
        public string Matricula { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public string NombreRol { get; set; }
        public List<PrestamoModel> Prestamo { get; set; }
    }
}
