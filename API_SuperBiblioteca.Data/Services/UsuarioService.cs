using API_SuperBiblioteca.Data.Interfaces;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_SuperBiblioteca.Data.Services
{
    public class UsuarioService : IUsuarioService
    {
        public PostgresqlConfiguration _connection;
        public UsuarioService(PostgresqlConfiguration connection) => _connection = connection;
        public NpgsqlConnection CreateConnection() => new(_connection.Connection);
    }
}
