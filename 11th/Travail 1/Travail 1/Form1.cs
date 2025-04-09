using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (txtNom.Text.Length > 0 && txtAge.Text.Length > 0 && txtPrenom.Text.Length > 0 && txtSport.Text.Length > 0)
            {
                int age;
                if (int.TryParse(txtAge.Text, out age))
                {
                    lblAffiche.Text = txtNom.Text + ", " + txtPrenom.Text + "\n" + "tu as: " + age.ToString() + "ans et ton sport est: " + txtSport.Text;

                }
                else
                {
                    MessageBox.Show("L'âge doit être un nombre entier.");
                }
            }
            else 
            {
                MessageBox.Show("Manque d'information, assure-toi que tout les botes sont remplis");
            }
        }
    }
}
