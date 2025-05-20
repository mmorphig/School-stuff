using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Labyrinthe_niveau_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int commencer = 0;
        int compteur = 0;
        List<Label> labelsH, labelsV, labelsRH, labelsRV;

        private void Commencer_Click(object sender, EventArgs e)
        {
            compteur = 0;
            commencer = 1;
            tmrTemps.Enabled = true;
            // Réinitialiser tout
            picObjet.Location = new Point(65, 55);
            picSerpent.Location = new Point(520, 395);
            picSerpent.Visible = false;
        }

        private void tmrTemps_Tick(object sender, EventArgs e)
        {
            compteur++;
            lblCompteur.Text = compteur.ToString();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Liste des labels rouges Horizontaux
            labelsRH = new List<Label>() { Rouge2, Rouge6 };
            // Liste des labels rouges Verticaux
            labelsRV = new List<Label>() { Rouge1, Rouge3, Rouge4, Rouge5, Rouge7 };
            // Liste des labels verts horizontaux
            labelsH = new List<Label>() {vert1, vert2, vert5, vert9, vert15, vert3, vert11, vert13,
            vert12, vert14, vert16, vert17, vert19, vert18};
            // Liste des labels verts verticaux
            labelsV = new List<Label>() { vert10, vert7, vert8, vert6, vert4 };
        }
      
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (commencer == 0) { return; } // Si le jeu n'est pas commencé, on ne fait rien
            switch (e.KeyCode)
            {
                case Keys.Up:
                    picObjet.Top -= 5;
                    break;
                case Keys.Down:
                    picObjet.Top += 5;
                    break;
                case Keys.Left:
                    picObjet.Left -= 5;
                    break;
                case Keys.Right:
                    picObjet.Left += 5;
                    break;
            }

            // Pour chacun des labels rouges horizontaux
            foreach (Label rougeHorizontal in labelsRH)
            {
                if (picObjet.Bounds.IntersectsWith(rougeHorizontal.Bounds))
                {
                    tmrSerpent.Start();
                    picSerpent.Visible = true;
                    if (picObjet.Top < rougeHorizontal.Top)
                        picObjet.Top -= 5;
                    else
                        picObjet.Top += 5;
                }
            }
            // Pour chacun des labels rouges verticaux
            foreach (Label rougeVertical in labelsRV)
            {
                if (picObjet.Bounds.IntersectsWith(rougeVertical.Bounds))
                {
                    tmrSerpent.Start();
                    picSerpent.Visible = true;
                    if (picObjet.Left < rougeVertical.Left)
                        picObjet.Left -= 5;
                    else
                        picObjet.Left += 5;
                }
            }

            // Pour tous les labels verticaux, l'oeuf est avant ou après
            foreach (Label vertVertical in labelsV) 
            {
                if (picObjet.Bounds.IntersectsWith(vertVertical.Bounds))
                {
                    if (picObjet.Left < vertVertical.Left)
                        picObjet.Left -= 5;
                    else
                        picObjet.Left += 5;
                }
            }
            // Pour tous les labels horizontaux, l'oeuf est en - dessous ou au-dessus
            foreach (Label vertHorizontal in labelsH) 
            {
                if (picObjet.Bounds.IntersectsWith(vertHorizontal.Bounds))
                {
                    if (picObjet.Top < vertHorizontal.Top)
                        picObjet.Top -= 5;
                    else
                        picObjet.Top += 5;
                }
            }
              
            // FIN
            if (picObjet.Bounds.IntersectsWith(lblFin.Bounds))
            {
                tmrTemps.Enabled = false;
                tmrSerpent.Enabled = false;
                commencer = 0;
                MessageBox.Show("Tu as gagné!", "Bravo!");
            }

        }

        private void tmrSerpent_Tick(object sender, EventArgs e)
        {
            // Vitesse de déplacement en pixels par tick
            int vitesse = 2;

            // Position actuelle du PictureBox
            Point positionActuelle = picSerpent.Location;

            // Position cible (centre du Label)
            Point cible = new Point(
                picObjet.Left + picObjet.Width / 2 - picSerpent.Width / 2,
                picObjet.Top + picObjet.Height / 2 - picSerpent.Height / 2
            );

            // Calcul du vecteur direction
            int dx = cible.X - positionActuelle.X;
            int dy = cible.Y - positionActuelle.Y;

            // Normaliser le vecteur direction et appliquer la vitesse
            double distance = Math.Sqrt(dx * dx + dy * dy);
            if (distance < vitesse)
            {
                picSerpent.Location = cible;
            }
            else
            {
                int deplacementX = (int)(vitesse * dx / distance);
                int deplacementY = (int)(vitesse * dy / distance);
                picSerpent.Location = new Point(positionActuelle.X + deplacementX, positionActuelle.Y + deplacementY);
            }

            // Si le serpent as atteint l'oeuf
            if (picSerpent.Bounds.IntersectsWith(picObjet.Bounds)) 
            {
                tmrTemps.Enabled = false;
                tmrSerpent.Enabled = false;
                MessageBox.Show("Tu as perdu :(", "Perdu");
            }
        }
    }
}

