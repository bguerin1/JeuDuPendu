﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_Jeu_du_Pendu.Model
{
    public class Partie
    {
        public Int32 nbEssais=1;
        public String motatrouver;
        public String motaafficher; 
        public List<String> listeATrouver;
        public DialogResult msg;
        public int dureeTotale=0;
        public Timer timer;
        public Int32 dureeCout;

        public void changerIMG(PictureBox pb_pendu)
        {
            
            switch (nbEssais)
            {
   
                
                case 1:
                    pb_pendu.Image = Properties.Resources.C1;
                    break;
                case 2:
                    pb_pendu.Image = Properties.Resources.C2;
                    break;
                case 3:
                    pb_pendu.Image = Properties.Resources.C3;
                    break;
                case 4:
                    pb_pendu.Image = Properties.Resources.C4;
                    break;
                case 5:
                    pb_pendu.Image = Properties.Resources.C5;
                    break;
                case 6:
                    pb_pendu.Image = Properties.Resources.C6;
                    break;
                case 7:
                    pb_pendu.Image = Properties.Resources.C7;
                    break;
                case 8:
                    pb_pendu.Image = Properties.Resources.C8;
                    break;
                case 9:
                    pb_pendu.Image = Properties.Resources.C9;
                    break;

                // Code à completer pour prendre en compte toutes les images
                default:
                    pb_pendu.Image = Properties.Resources.C1;
                    break;
                
            }

           

        }
        public void verifier(string lettretape, TextBox txt_afficher)
        {
            char[] cArray = motatrouver.ToCharArray();
            char[] motaff = motaafficher.ToCharArray();
            motaafficher = "";
            bool erreur = false; 

            for (int i=0; i<cArray.Count() ;i++)
            {
                if (cArray[i] == Convert.ToChar(lettretape))
                {
                    motaafficher += lettretape;
                    erreur = true;


                }
                else
                {
                    motaafficher += motaff[i];
                    

                }
               

            }
            if (erreur == false)
            {
                nbEssais++;
                
            }
            txt_afficher.Text = motaafficher;

        }
        public void genererMotAfficher()
        {
            string motaff = "";

            
            for(int i =1; i <= motatrouver.Count(); i++)
            {
                motaff += "_";
            }
            motaafficher = motaff;

        }

        public void choisirMotATrouver(List<String> listeATrouver)
        {
            Random aleatoire = new Random();
            int nbAleatoire=aleatoire.Next(listeATrouver.Count);
            
            motatrouver = listeATrouver[nbAleatoire].ToUpper();
          
        }

        public void victoire(Form formulaireJeuActif, TextBox txt_motaafficher,List<string> listeMotaTrouver, PictureBox pb_pendu, TextBox txt_timer)
        { 
            if (nbEssais >= 9)
            {
                timer.Stop();
                msg = MessageBox.Show("Vous avez perdu !! \r\n Vous deviez trouver le mot : "+motatrouver+"\r\nVoulez vous faire une autre partie ??","You loose", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                if(msg == DialogResult.Yes)
                {
                    remiseAZero(formulaireJeuActif, txt_motaafficher, listeMotaTrouver, pb_pendu,timer);
                }
                else
                {
                    SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["Menu"] as Menu).panelMenu);
                    SF.openChildForm(new Form1());
                    formulaireJeuActif.Hide();
                }
            }
            else
            {
                if(motatrouver==motaafficher && nbEssais < 9)
                {
                    timer.Stop();
                    msg = MessageBox.Show("Vous avez gagné !! \r\n Vous deviez trouver le mot : " + motatrouver + "\r\n Vous avez trouvé le mot en : "+txt_timer.Text+"\r\nVoulez vous faire une autre partie ??", "You win", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                    
                    if (msg == DialogResult.Yes)
                    {
                        remiseAZero(formulaireJeuActif, txt_motaafficher, listeMotaTrouver, pb_pendu,timer);
                    }
                    else
                    {
                        SousFormulaire SF = new SousFormulaire((System.Windows.Forms.Application.OpenForms["Menu"] as Menu).panelMenu);
                        SF.openChildForm(new Form1());
                        formulaireJeuActif.Hide();
                    }
                }

            }
            
            
  
        }
       

        public void remiseAZero(Form formulaireJeuActif, TextBox txt_motaafficher, List<string> listeMotaTrouver, PictureBox pb_pendu,Timer timer)
        {
            //Mettre à vide les attribut motaafficher et motatrouver
            motaafficher = "";
            motatrouver = "";
            // Mettre le nombre d'essai à 1
            nbEssais = 1;

            // Mettre à jour le timer 
            dureeTotale = 0;
            timer.Start(); 

            // Choisir un nouveau mot à trouver
            choisirMotATrouver(listeMotaTrouver);
            // Générer un nouveau mot à afficher
            genererMotAfficher();

            txt_motaafficher.Text = motaafficher;

            foreach(Control c in formulaireJeuActif.Controls)
            {
                if (c.GetType() == typeof(Button))
                    c.Enabled = true;
            }
            //Mettre à jour l'image 

            pb_pendu.Image = Properties.Resources.C1;


        }

        public void gestionTimer(TextBox txt_timer, ProgressBar progressBar, PictureBox pb_pendu, Form formulaireJeuActif,TextBox txt_motaafficher, List<string> listeMotaTrouver)
        {
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += (sender, e) => Timer_Tick(sender, e, txt_timer,progressBar,pb_pendu, formulaireJeuActif, txt_motaafficher, listeMotaTrouver);

            timer.Start();

            
        }

        public void remiseZeroProgress(ProgressBar progressBar)
        {
            progressBar.Value = 0;
        }
        public void Timer_Tick(object sender, EventArgs e, TextBox txt_timer,ProgressBar progressBar, PictureBox pb_pendu,Form formulaireJeuActif, TextBox txt_motaafficher, List<string> listeMotaTrouver)
        {
            dureeTotale++;
            dureeCout++;
            progressBar.Increment(1);
            if(dureeCout>=10)
            {
                dureeCout = 0;
                nbEssais++;
                changerIMG(pb_pendu);
                progressBar.Value = 0;
                victoire(formulaireJeuActif, txt_motaafficher, listeMotaTrouver, pb_pendu, txt_timer);

            }
            
            txt_timer.Text = dureeTotale.ToString() + " sec";
        }



    }

}
