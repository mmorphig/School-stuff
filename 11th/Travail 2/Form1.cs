using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail_2
{
    public partial class Form1 : Form
    {
        Random Rd = new Random();
        int jeuxRestant, points, tirage;
        public Form1()
        {
            InitializeComponent();
        }
        
        public void perdu()
        {
            jeuxRestant--;
            switch (tirage) {
                case 1:
                    picHautGauche.Image = Properties.Resources.mario;
                    break;
                case 2:
                    picHautDroit.Image = Properties.Resources.mario;
                    break;
                case 3:
                    picBasGauche.Image = Properties.Resources.mario;
                    break;
                case 4:
                    picBasDroite.Image = Properties.Resources.mario;
                    break;
            }
        }

        public void gagne(object sender)
        {
            jeuxRestant--;
            points++;
            lblPoints.Text = points.ToString();
            ((PictureBox)sender).Image = Properties.Resources.mario;
        }

        private void btnGenere_Click(object sender, EventArgs e)
        {
            // Enlève l'image de les pictureBox
            foreach (Control c in Controls)
            {
                if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
            }

            lblJeux.Text = jeuxRestant.ToString();
            
            // Vérifie si le joueur a encore des jeux restants
            if (jeuxRestant == 0)
            {
                MessageBox.Show("Les 25 parties sont écoulées!", "Fin des jeux");
            }
            else
            {
                // Initialise le jeu
                tirage = Rd.Next(1, 5);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            jeuxRestant = 25;
            tirage = Rd.Next(1, 5);
        }
        public void picClick(object sender, EventArgs e)
        {
            // Enlève l'image de les pictureBox
            foreach (Control c in Controls)
            {
                if (c is PictureBox)
                {
                    ((PictureBox)c).Image = null;
                }
            }
            switch (((PictureBox)sender).Name) {
                case "picHautGauche":
                    if (tirage != 1) { perdu(); } else { gagne(sender); }
                    break;
                case "picHautDroit":
                    if (tirage != 2) { perdu(); } else { gagne(sender); }
                    break;
                case "picBasGauche":
                    if (tirage != 3) { perdu(); } else { gagne(sender); }
                    break;
                case "picBasDroite":
                    if (tirage != 4) { perdu(); } else { gagne(sender); }
                    break;
            }
        }
    }
}
