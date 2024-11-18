using API_SuperBiblioteca.Data.Interfaces;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_SuperBiblioteca.Data.Services
{
    public class AuthService : IAuthService
    {
        public PostgresqlConfiguration _connection;
        public AuthService(PostgresqlConfiguration connection) => _connection = connection;
        public NpgsqlConnection CreateConnection() => new(_connection.Connection);
    }
}
