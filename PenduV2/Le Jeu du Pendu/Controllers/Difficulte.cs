using Le_Jeu_du_Pendu.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Le_Jeu_du_Pendu.Controllers
{
    public class Difficulte
    {

        private DataTable dtListeDifficulte;
        private Connexion conn;


        public DataTable GetListeDifficulte()
        {
            //Instencier l’objet dtListeMots de type DataTable

            dtListeDifficulte = new DataTable();

            //Instencier l’objet conn de type Connection

            conn = new Connexion();

            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDDIFFICULTE,LABELDIFFICULTE FROM difficulte;", conn.Connection))
                {
                    conn.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeDifficulte.Load(reader);
                    DataRow workRow = dtListeDifficulte.NewRow();
                    workRow[0] = -1;
                    workRow[1] = "";
                    dtListeDifficulte.Rows.InsertAt(workRow, 0);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeDifficulte;
        }

    }
}
