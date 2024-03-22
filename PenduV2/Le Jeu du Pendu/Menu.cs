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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void démarrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["Menu"] as Menu).panelMenu);
            SF.openChildForm(new Form1());
            SF.openChildForm(new affichage());
        }
    }
}
