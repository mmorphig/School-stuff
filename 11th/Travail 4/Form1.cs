using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail_4
{
    public partial class Form1 : Form
    {
        bool animation = false;
        int stageFemme, stageHomme, stageFeux = 0;
        int vitesseFemme, vitesseHomme;
        Random rd = new Random();
        PictureBox picGangant;
        List<Image> listeFemme;
        List<Image> listeHomme;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picFemme.Parent = picPiste; // fait que les images peuvent être transparentes
            picHomme.Parent = picPiste;
            picCoupe.Parent = picPiste;
            picHomme.BackColor = Color.Transparent; // fait les images transparentes
            picFemme.BackColor = Color.Transparent;
            picCoupe.BackColor = Color.Transparent;
            picCoupe.Image = Travail_4.Properties.Resources.coupe;
            recommence(null,null);
            listeHomme = new List<Image>(){Properties.Resources.homme1,
                                           Properties.Resources.homme2,
                                           Properties.Resources.homme3,
                                           Properties.Resources.homme1};
            listeFemme = new List<Image>(){Properties.Resources.femme1,
                                           Properties.Resources.femme2,
                                           Properties.Resources.femme3,
                                           Properties.Resources.femme4};

        }

        public bool testAtteintFin(PictureBox sender) {
            // vérifie si l'image est arrivée à la fin de la piste
            if (sender.Location.X >= 1040)
            {
                tmrAnimation.Stop();
                //MessageBox.Show("Le gagnant est " + sender.Name);
                picGangant = sender;
                tmrCoupe.Start();
                return true;
            }
            else
            {
                return false;
            }
        }

        public void recommence(object sender, EventArgs e)
        {
            tmrAnimation.Stop(); // arrête l'animation si elle est en cours
            tmrCoupe.Stop();
            picCoupe.Location = new Point(1020, 210); // remet la coupe à sa position initiale
            // remet les agents à leur position et image initiale
            picFemme.Image = Travail_4.Properties.Resources.femme1;
            picFemme.Location = new Point(2, 120);
            picHomme.Image = Travail_4.Properties.Resources.homme1;
            picHomme.Location = new Point(2, 38);
            // vitesse aléatoire entre 1 et 3
            vitesseFemme = rd.Next(1, 3); 
            vitesseHomme = rd.Next(1, 3);
            tmrFeux.Start(); // commence l'animation des feux, elle commence l'animation au fin
        }

        private void tmrCoupe_Tick(object sender, EventArgs e)
        {
            if (picCoupe.Location != new Point(picGangant.Location.X + picGangant.Width, picGangant.Location.Y))
            {
                int stepSize = 2; 
                int targetX = picGangant.Location.X + picGangant.Width;
                int targetY = picGangant.Location.Y;

                int deltaX = targetX - picCoupe.Location.X;
                int deltaY = targetY - picCoupe.Location.Y;

                double distance = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
                double stepX = (deltaX / distance) * stepSize;
                double stepY = (deltaY / distance) * stepSize;

                int newX = (int)(picCoupe.Location.X + stepX);
                int newY = (int)(picCoupe.Location.Y + stepY);

                if (Math.Abs(newX - targetX) < stepSize && Math.Abs(newY - targetY) < stepSize)
                {
                    newX = targetX;
                    newY = targetY;
                }

                picCoupe.Location = new Point(newX, newY);
            }
        }

        private void tmrFeux_Tick(object sender, EventArgs e)
        {
            switch (stageFeux)
            {
                case 0:
                    picFeux.Image = Travail_4.Properties.Resources.images_rouge;
                    stageFeux++;
                    break;
                case 1:
                    picFeux.Image = Travail_4.Properties.Resources.images_jaune;
                    stageFeux++;
                    break;
                case 2:
                    picFeux.Image = Travail_4.Properties.Resources.images_vert;
                    tmrAnimation.Start(); // démarre l'animation de la course
                    tmrFeux.Stop();
                    stageFeux = 0; // reset stageFeux
                    break;
            }
            
        }

        private void tmrAnimation_Tick(object sender, EventArgs e)
        {
            // animation des deux images, anime un puis l'autre en cycle
            if (animation) // animation de picFemme
            {
                picFemme.Image = listeFemme[stageFemme++];
                if (stageFemme == 3) { stageFemme = 0; } // reset stageFemme 
                // Bouge picFemme
                picFemme.Location = new Point((rd.Next(4, 16) * vitesseFemme) + picFemme.Location.X, picFemme.Location.Y);
                testAtteintFin(picFemme);
                animation = false;
            }
            else // animation de picHomme
            {
                picHomme.Image = listeHomme[stageHomme++];
                if (stageHomme == 3) { stageHomme = 0; } // reset stageHomme 
                // Bouge picHomme
                picHomme.Location = new Point((rd.Next(4, 16) * vitesseHomme) + picHomme.Location.X, picHomme.Location.Y);
                testAtteintFin(picHomme);
                animation = true;
            }
        }
    }
}
