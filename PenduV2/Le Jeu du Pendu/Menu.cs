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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public Form activeForm = null;
        public void openChildForm(Form formEnfant)
        {
            if (activeForm != null)
                activeForm.Close();

            activeForm = formEnfant;
            formEnfant.TopLevel = false;
            formEnfant.FormBorderStyle = FormBorderStyle.None;
            formEnfant.Dock = DockStyle.Fill;
            panelMenu.Controls.Add(formEnfant);
            panelMenu.Tag = formEnfant;
            formEnfant.BringToFront();
            formEnfant.Show();

            
        }

        private void démarrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openChildForm(new Form1());
        }
    }
}
