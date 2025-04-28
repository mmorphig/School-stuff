using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zig_zag
{
    public partial class Form1 : Form
    {
        int VelX = 5, VelY = -5, stage = 0;
        public static int score = 0;
        public static string nom;
        public Form1()
        {
            InitializeComponent();
        }

        private void tmrÉtoiles_Tick(object sender, EventArgs e)
        {
            picLuigi.Left += VelX;
            picLuigi.Top += VelY;

            int v = collision();
            if (v != 0)
            {
                if (v == 3) { VelX = 0; VelY = 0; picGagner.Show(); }
                score = int.Parse(lblPoints.Text) + v;
                lblPoints.Text = score.ToString();
                VelY = -VelY;
            }
        }

        public int collision()
        {
            if (picLuigi.Bounds.IntersectsWith(picEtoile1.Bounds) && stage == 0)
            {
                stage = 1;
                return 1;
            }
            else if (picLuigi.Bounds.IntersectsWith(picEtoile2.Bounds) && stage == 1)
            {
                stage = 2;
                return 2;
            }
            else if (picLuigi.Bounds.IntersectsWith(picEtoile3.Bounds) && stage == 2)
            {
                stage = 3;
                return 3;
            }
            return 0;
        }

        private void btnCertificat_Click(object sender, EventArgs e)
        {
            if (stage != 3) { return; }
            if (txtNom.Text == "")
            {
                MessageBox.Show("Veuillez entrer votre nom !", "Nom");
                return;
            }
            nom = txtNom.Text;
            Form F2 = new Form2();
            F2.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            picEtoile1.Parent = picFond;
            picEtoile2.Parent = picFond;
            picEtoile3.Parent = picFond;
            picLuigi.Parent = picFond;
            picGagner.Parent = picFond;
            lblPoints.Text = score.ToString();
            picGagner.Hide();
        }
        
    }
}
