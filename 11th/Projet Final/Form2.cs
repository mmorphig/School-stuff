using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet_Final
{
    public partial class Form2 : Form
    {
        private Form1 mainForm;

        public Form2(Form1 parentForm)
        {
            InitializeComponent();
            mainForm = parentForm;
            this.KeyPreview = true;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.KeyDown += mainForm.Form1_KeyDown;
            this.KeyUp += mainForm.Form1_KeyUp;
            lblAugmentation1.Location = new Point(12, 100);
            lblAugmentation2.Location = new Point(12, 175);
            lblAugmentation3.Location = new Point(12, 250);
            btnAugmentations1.Location = new Point(490, 100);
            btnAugmentations2.Location = new Point(490, 175);
            btnAugmentations3.Location = new Point(490, 250);
            lblPoints.Text = "Points: " + mainForm.points.ToString();
        }

        private void btnAugmentations1_Click(object sender, EventArgs e)
        {
            if (mainForm.montantAug1 > 40) // Nombre max d'augmentations
                return;
            if (mainForm.points < 2) // On ne peut pas acheter si on a pas assez de points
                return;
            mainForm.montantAug1++;
            mainForm.windowGrandeur[0] += 10;
            mainForm.windowGrandeur[1] += 10;
            mainForm.points -= 2;
            lblPoints.Text = "Points: " + mainForm.points.ToString();

            if (mainForm.montantAug1 == 40) // On ne peut pas acheter si on a pas assez de points
            {
                lblAugmentation1.Text = "Grandeur de vue: 2p        Niveau: " + mainForm.montantAug1.ToString() + " (Max)";
            }
            else
            {
                lblAugmentation1.Text = "Grandeur de vue: 2p        Niveau: " + mainForm.montantAug1.ToString();
            }
        }

        private void btnAugmentations2_Click(object sender, EventArgs e)
        {
            if (mainForm.montantAug2 > 10) // Nombre max d'augmentations
                return;
            if (mainForm.points < 5) // On ne peut pas acheter si on a pas assez de points
                return;
            mainForm.montantAug2++;
            mainForm.joueur.vitesse += 1;
            mainForm.points -= 5;
            lblPoints.Text = "Points: " + mainForm.points.ToString();

            if (mainForm.montantAug2 == 10) // On ne peut pas acheter si on a pas assez de points
            {
                lblAugmentation2.Text = "Vitesse du joueur: 5p        Niveau: " + mainForm.montantAug2.ToString() + " (Max)";
            }
            else
            {
                lblAugmentation2.Text = "Vitesse du joueur: 5p        Niveau: " + mainForm.montantAug2.ToString();
            }
        }

        private void btnAugmentations3_Click(object sender, EventArgs e)
        {
            if (mainForm.montantAug3 > 20) // Nombre max d'augmentations
                return;
            if (mainForm.points < 10) // On ne peut pas acheter si on a pas assez de points
                return;
            mainForm.montantAug3++;
            mainForm.valeurPiece++;
            mainForm.points -= 10;
            lblPoints.Text = "Points: " + mainForm.points.ToString();

            if (mainForm.montantAug3 == 20) // On ne peut pas acheter si on a pas assez de points
            {
                lblAugmentation3.Text = "Valeur des pièces: 10p        Niveau: " + mainForm.montantAug3.ToString() + " (Max)";
            }
            else
            {
                lblAugmentation3.Text = "Valeur des pièces: 10p        Niveau: " + mainForm.montantAug3.ToString();
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            lblPoints.Text = "Points: " + mainForm.points.ToString();
            // Ferme la fenêtre si la touche Echap ou E est pressée
            if (keyData == Keys.Escape || keyData == Keys.E)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
