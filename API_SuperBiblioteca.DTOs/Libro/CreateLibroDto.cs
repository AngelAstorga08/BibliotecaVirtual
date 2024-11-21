﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_SuperBiblioteca.DTOs.Libro
{
    public class CreateLibroDto
    {
        public string Titulo { get; set; } 
        public string Autor { get; set; }
        public string Editorial { get; set; }
        public int TipoID { get; set;}
        public int GeneroID { get; set; }
        public DateTime AnoPublicacion { get; set; }
        public string ISBN { get; set; }
        public string Imagen { get; set; }

    }
}
