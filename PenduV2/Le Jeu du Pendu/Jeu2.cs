using Le_Jeu_du_Pendu.Model;
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
    public partial class Jeu2 : Form
    {
        // Déclaration de l'objet P de la classe Partie pour la portée de la variable et une réutilisation dans le projet; 
        
        Partie P;
        public Jeu2()
        {
            InitializeComponent();
           
            // Instanciation de l'objet P à cet endroit. 

            P = new Partie();
            init();

  

        }

        private void init()
        {
            List<string> listeMotaTrouver = new List<string> { "Francophile", "Chlorophylle", "Conspirateur", "Qualification", "Attraction", "Cornemuse", "Tourisme", "Diapason", "Brouhaha" };
            P.choisirMotATrouver(listeMotaTrouver);
            P.genererMotAfficher();
            txt_motatrouver.Text = P.motaafficher;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            List<string> listeMotaTrouver = new List<string> { "Francophile", "Chlorophylle", "Conspirateur", "Qualification", "Attraction", "Cornemuse", "Tourisme", "Diapason", "Brouhaha" };
            P.verifier(((Button)sender).Text.ToString(), txt_motatrouver);
            ((Button)sender).Enabled = false;
            P.changerIMG(pb_pendu);
            P.victoire(this, txt_motatrouver, listeMotaTrouver, pb_pendu);
        }
        
    }
}
