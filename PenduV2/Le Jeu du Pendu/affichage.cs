using Le_Jeu_du_Pendu.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Le_Jeu_du_Pendu.Model;

namespace Le_Jeu_du_Pendu
{
    public partial class affichage : Form
    {
        public Mots dt_mot;
        private DataView dv;
        public Difficulte dt_difficulte;
        public affichage()
        {
            InitializeComponent();
            dt_mot = new Mots();
            dv = new DataView(dt_mot.GetListeMots());
            dgv_Mots.DataSource = dv;
            //Cacher les colonnes qui ne servent à rien pour l’utilisateur
            dgv_Mots.Columns["IDMOTS"].Visible = false;
            dgv_Mots.Columns["IDDIFFICULTE"].Visible = false;
            //Gérer la largeur des colonnes
            dgv_Mots.Columns["Mots"].Width = 190;
            dgv_Mots.Columns["Difficultée"].Width = 190;

            dt_difficulte = new Difficulte();

            comboBox_Difficult.DataSource = dt_difficulte.GetListeDifficulte();
            comboBox_Difficult.DisplayMember = "LABELDIFFICULTE"; //nom de l’alias SQL
            comboBox_Difficult.ValueMember = "IDDIFFICULTE"; //nom de l’alias SQL


        }

        private void btn_quitterAffichage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Mot_TextChanged(object sender, EventArgs e)
        {
            dv = new DataView(dt_mot.GetListeMotsdifficult(txt_Mot.Text, comboBox_Difficult.SelectedValue.ToString()));
            dgv_Mots.DataSource = dv;

        }

        private void comboBox_Difficult_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dv = new DataView(dt_mot.GetListeMotsdifficult(txt_Mot.Text, comboBox_Difficult.SelectedValue.ToString()));
            dgv_Mots.DataSource = dv;
        }
    }
}
