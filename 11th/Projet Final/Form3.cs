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
    public partial class Form3 : Form
    {
        private Form1 mainForm;
        string nom = "Null"; // Nom du joueur, est "Null" par défaut, on ne force pas l'utilisateur à entrer un nom
        public Form3(Form1 parentForm)
        {
            InitializeComponent();
            mainForm = parentForm;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNom.Text != "")
                nom = txtNom.Text; // On entre le nom du joueur
            MessageBox.Show(nom + " as finit le jeu avec " + mainForm.points.ToString() + " points!", "Fin du jeu", MessageBoxButtons.OK, MessageBoxIcon.Information);
            mainForm.Close(); // On ferme le jeu
        }
    }
}
