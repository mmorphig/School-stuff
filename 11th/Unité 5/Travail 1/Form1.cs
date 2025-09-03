using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail_1
{
    public partial class Form1 : Form
    {
        List<course> listeFruits, listeLegumes;

        Random rd = new Random();
        int courses = 0, index1 = 0, totalCourses = 1;

        float somme;
        PictureBox pic;

        private void tmrBouge_Tick(object sender, EventArgs e)
        {
            int vitesse = 5;

            Point positionActuelle = pic.Location;

            // Position cible (centre du Label)
            Point cible = new Point(
                lblChariot.Left + lblChariot.Width / 2 - pic.Width / 2,
                lblChariot.Top + lblChariot.Height / 2 - pic.Height / 2
            );

            // Calcul du vecteur direction
            int dx = cible.X - positionActuelle.X;
            int dy = cible.Y - positionActuelle.Y;

            double distance = Math.Sqrt(dx * dx + dy * dy);
            if (distance < vitesse)
            {
                pic.Location = cible;
            }
            else
            {
                int deplacementX = (int)(vitesse * dx / distance);
                int deplacementY = (int)(vitesse * dy / distance);
                pic.Location = new Point(positionActuelle.X + deplacementX, positionActuelle.Y + deplacementY);
            }

            // Vérifier à nouveau l’intersection après le déplacement
            if (pic.Bounds.IntersectsWith(lblChariot.Bounds))
            {
                index1 += 1;
                if (index1 > 6) // Continue le mouvement pour 5 pas
                    tmrBouge.Stop();
            }
        }

        private void nudQuantite_ValueChanged(object sender, EventArgs e)
        {
            totalCourses = (int)nudQuantite.Value;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Ajout de fruits à la liste
            listeFruits = new List<course>() {
                new course("Pomme", 6.78f, Travail_1.Properties.Resources.pommes),
                new course("Bananes", 2.67f, Travail_1.Properties.Resources.bananes),
                new course("Fraises", 8.99f, Travail_1.Properties.Resources.fraises),
                new course("Raisins", 5.79f, Travail_1.Properties.Resources.raisins),
            };
            // Ajout de légumes à la liste
            listeLegumes = new List<course>()
            {
                new course("Carottes", 1.99f, Travail_1.Properties.Resources.carottes),
                new course("Tomate", 3.78f, Travail_1.Properties.Resources.tomates),
                new course("Brocoli", 2.99f, Travail_1.Properties.Resources.brocoli),
                new course("Poivrons", 6.56f, Travail_1.Properties.Resources.poivrons)
            };
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (courses >= totalCourses)
            {
                tmrBouge.Enabled = false;
                btnAjouter.Enabled = false;
                lblRecu.Text += "\nTotal : " + somme.ToString("0.00") + " $";
                return;
            }
            // Choix aléatoire entre fruits et légumes
            int courseCourr = -1; // Initialisation de courseCourr à un impossible
            int fruitOuLegume = rd.Next(0, 2);
            if (fruitOuLegume == 0)
                courseCourr = rd.Next(0, listeFruits.Count);
            else
                courseCourr = rd.Next(0, listeLegumes.Count);

            // Ajoute le produit au recu
            int nombre = rd.Next(1,3);

            lblRecu.Text += nombre + " " + (fruitOuLegume == 0 ? listeFruits[courseCourr].nom : listeLegumes[courseCourr].nom) + " " + ((fruitOuLegume == 0 ? listeFruits[courseCourr].prix : listeLegumes[courseCourr].prix) * nombre) + " $\n";

            if (courseCourr < 0) return; // Si le produit n'est pas valide
            // Affichage du produit choisi
            if (fruitOuLegume == 0)
                pic = new PictureBox() { Image = listeFruits[courseCourr].img };
            else
                pic = new PictureBox() { Image = listeLegumes[courseCourr].img };
            pic.BackColor = Color.Transparent;
            pic.Parent = picFond;
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.Size = new Size(60, 60);
            pic.Location = new Point(490, 320);
            pic.BringToFront();
            picFond.Controls.Add(pic);

            // Affichage du prix
            somme += (fruitOuLegume == 0 ? listeFruits[courseCourr].prix : listeLegumes[courseCourr].prix) * nombre;
            index1 = 0;
            tmrBouge.Enabled = true;
            courses++;
            if (fruitOuLegume == 0)
                listeFruits.RemoveAt(courseCourr);
            else
                listeLegumes.RemoveAt(courseCourr);
        }
    }
    class course
    {
        public string nom;
        public float prix;
        public Image img;

        public course(string nom, float prix, Image img)
        {
            this.nom = nom;
            this.prix = prix;
            this.img = img;
        }
    }
}
