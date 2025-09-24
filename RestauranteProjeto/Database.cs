using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace RestauranteProjeto
{
    public class Database
    {
        private string conexaoString = "server=localhost;database=SistemaLogin;uid=root;pwd=utfpr;";

        public MySqlConnection GetConexao()
        {
            return new MySqlConnection(conexaoString);
        }
    }
}
