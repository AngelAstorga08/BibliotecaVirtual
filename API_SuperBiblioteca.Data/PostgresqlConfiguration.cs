using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_SuperBiblioteca.Data
{
    public class PostgresqlConfiguration
    {
        public string Connection;
        public PostgresqlConfiguration(string connection) => Connection = connection;
    }
}
