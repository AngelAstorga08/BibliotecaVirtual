using API_SuperBiblioteca.Data.Interfaces;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_SuperBiblioteca.Data.Services
{
    public class LibroService : ILibroService
    {
        public PostgresqlConfiguration _connection;
        public LibroService(PostgresqlConfiguration connection) => _connection = connection;
        public NpgsqlConnection CreateConnection() => new (_connection.Connection);

    }
}
