using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail_4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void tmrProgressBar_Tick(object sender, EventArgs e)
        {
            if (progressBar.Value < 100)
            {
                switch (((float)progressBar.Value)/5) {
                    case 4f:
                        lblProgress.Text = "Démarrage de l'environnement";
                        break;
                    case 8f:
                        lblProgress.Text = "Chargement des modules";
                        break;
                    case 12f:
                        lblProgress.Text = "Chargement des ressources";
                        break;
                    default:
                        lblProgress.Text += ".";
                        break;
                }
                progressBar.Value += 1;
            }
            else
            {
                tmrProgressBar.Stop();
                this.Hide();
                Form1 form1 = new Form1();
                form1.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            tmrProgressBar.Start();
        }
    }
}
