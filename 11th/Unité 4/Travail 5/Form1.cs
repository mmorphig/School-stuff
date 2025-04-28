using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail_5
{
    public partial class Commencer : Form
    {
        int difficulte = 1; // 1 = Débutant, 2 = Intermédiaire, 3 = Difficile
        // Ne commence pas à 0 car la vitesse est avec une multiplication
        public Commencer()
        {
            InitializeComponent();
        }

        private void btnJouer_Click(object sender, EventArgs e)
        {

        }

        // Fonction pour les boutons de difficulté
        private void btnDifficulte_Click(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            switch (clicked.Name) {
                case "btnDebutant":
                    difficulte = 1;
                    break; 
                case "btnIntermediaire":
                    difficulte = 2;
                    break;
                case "btnDifficile":
                    difficulte = 3; 
                    break;
            }
        }

        private void Commencer_Load(object sender, EventArgs e)
        {

        }
    }
}
