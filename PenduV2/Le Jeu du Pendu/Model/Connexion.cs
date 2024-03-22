using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySqlConnector;

namespace Le_Jeu_du_Pendu.Model
{
    public class Connexion
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        private void Initialise()
        {
            server = "localhost";
            database = "bdd_pendu";
            uid = "guerin2_bryan";
            password = "Bs9IP91a";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        public Connexion()
        {

        }

        public Connexion(MySqlConnection laConnection, string leServer, string laDatabase, string leUid,string lePassword)
        {
            connection = laConnection;
            server = leServer;
            database = laDatabase;
            uid = leUid;
            password = lePassword;
        }




    }
}
