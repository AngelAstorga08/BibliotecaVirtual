using API_SuperBiblioteca.DTOs.Libro;
using API_SuperBiblioteca.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_SuperBiblioteca.Data.Interfaces
{
    public interface ILibroService
    {
        public Task<IEnumerable<LibroModel>> FindAll();
        public Task<LibroModel> FindOne(int LibroID);
        public Task<LibroModel> Create(CreateLibroDto createLibroDto);
        public Task<LibroModel> Update(UpdateLibroDto updateLibroDto);
        public Task<LibroModel> Remove(int LibroID);
    }
}
