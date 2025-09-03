using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail_3
{
    public partial class Form1 : Form
    {
        int feuCourant = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnArrete_Click(object sender, EventArgs e)
        {
            if (!tmrChange.Enabled)
            {
                tmrChange.Start();
                btnArrete.Text = "Arrête";
            }
            else
            {
                tmrChange.Stop();
                btnArrete.Text = "Commence";
            }
        }

        private void tmrChange_Tick(object sender, EventArgs e)
        {
            feuCourant++;
            switch (feuCourant) { 
                case 0:
                    picFeux.Image = Travail_3.Properties.Resources.images_rouge;
                    tmrChange.Interval = 2000; // 2 secondes pour le rouge
                    break;
                case 1:
                    picFeux.Image = Travail_3.Properties.Resources.images_jaune;
                    tmrChange.Interval = 500; // 0.5 secondes (500 millisecondes) pour le jaune
                    break;
                case 2:
                    picFeux.Image = Travail_3.Properties.Resources.images_vert;
                    tmrChange.Interval = 3000; // 30 secondes pour le vert
                    feuCourant = -1; // Reset à -1 pour recommencer le cycle
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrChange.Start();
        }
    }
}
