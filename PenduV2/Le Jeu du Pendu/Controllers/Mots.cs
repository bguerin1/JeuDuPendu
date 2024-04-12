using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Le_Jeu_du_Pendu.Model;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Pqc.Crypto.Lms;

namespace Le_Jeu_du_Pendu.Controllers
{
    public class Mots
    {
        private DataTable dtListeMots;
        private Connexion conn;
        private string rqtSql;
        public DataTable GetListeMots()
        {
            //Instencier l’objet dtListeMots de type DataTable

            dtListeMots = new DataTable();

            //Instencier l’objet conn de type Connection
            
            conn = new Connexion();  
            
            try
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT IDMOTS,LABELMOTS as Mots, mots.IDDIFFICULTE,LABELDIFFICULTE as Difficultée FROM mots INNER JOIN difficulte ON mots.IDDIFFICULTE = difficulte.IDDIFFICULTE;", conn.Connection))
                {
                    conn.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeMots.Load(reader);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeMots;
        }
        
        public DataTable GetListeMotsdifficult(string txt_Mot, string combo_Difficult)
        {
            dtListeMots = new DataTable();
            if (txt_Mot == "") 
            {
                MessageBox.Show("Le champs du mot est vide!");
            }
            try
            {
                rqtSql = "SELECT IDMOTS," + txt_Mot + " as Mots, mots.IDDIFFICULTE,"+ combo_Difficult +" as Difficultée FROM mots INNER JOIN difficulte ON mots.IDDIFFICULTE = difficulte.IDDIFFICULTE;";
                Connexion conn = new Connexion();
                using (MySqlCommand cmd = new MySqlCommand(rqtSql, conn.Connection))
                {
                    conn.Connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();
                    dtListeMots.Load(reader);

                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Erreur 3", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
            }
            return dtListeMots;
        }



    }
}
