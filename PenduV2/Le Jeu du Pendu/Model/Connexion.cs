using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Le_Jeu_du_Pendu.Model
{
    public class Connexion
    {
        private MySqlConnection connection;
        private string server = "192.168.10.16";
        private string database = "guerin2_bryan_BDD_Pendu";
        private string uid = "guerin2_bryan";
        private string password = "Bs9IP91a";
        public MySqlConnection Connection 
        { 
            get { return connection; }
            set { connection = value; }     
        
        } 
        private void Initialise()
        {
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        public Connexion()
        {
            Initialise();
        }
        public Connexion(string leServer, string laDatabase, string leUid, string lePassword)
        {
            server = leServer;
            database = laDatabase;
            uid = leUid;
            password = lePassword;
            Initialise();
        }

       




    }
}
