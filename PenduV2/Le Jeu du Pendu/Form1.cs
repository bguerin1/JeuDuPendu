using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_Jeu_du_Pendu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox_difficulté.Items.Add("Facile");
            comboBox_difficulté.Items.Add("Moyen");
            comboBox_difficulté.Items.Add("Difficile");
            comboBox_difficulté.Items.Add("Enfer");


           
        }



        private void btn_valider_Click(object sender, EventArgs e)
        {

            if (txt_prenom.Text == "" && txt_nom.Text == "")
            {
                MessageBox.Show("Aucun nom et prénom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txt_nom.Text == "")
                {
                    MessageBox.Show("Aucun nom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (txt_prenom.Text == "")
                {
                    MessageBox.Show("Aucun prénom n'est rentré", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (comboBox_difficulté.SelectedIndex == -1)
            {
                MessageBox.Show("Vous n'avez pas choisi de difficulté !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if(txt_prenom.Text !="" && txt_nom.Text !="" && comboBox_difficulté.SelectedIndex > -1)
            {
                Jeu2 Form2= new Jeu2(txt_prenom.Text+" "+txt_nom.Text, comboBox_difficulté.Text);
                Form2.Show();
                this.Hide();
            }
            


        }

        private void comboBox_difficulté_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            if (comboBox_difficulté.SelectedItem.ToString() == "Enfer")
            {
                this.BackColor = Color.Red;
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Bold);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Bold);
                lbl_difficulté.Font = new Font(lbl_difficulté.Font, FontStyle.Bold);
                
            }
            else
            {
                this.BackColor = Color.White;
                lbl_nom.Font = new Font(lbl_nom.Font, FontStyle.Regular);
                lbl_prenom.Font = new Font(lbl_prenom.Font, FontStyle.Regular);
                lbl_difficulté.Font = new Font(lbl_difficulté.Font, FontStyle.Regular);
            }
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {

        }
    }
}
