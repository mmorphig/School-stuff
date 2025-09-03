using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Media;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail_4
{
    public partial class Form1 : Form
    {
        Random rd = new Random();
        bool zombie1 = false, zombie2 = false, zombie3 = false, zombie4 = false, zombie5 = false;
        bool plante1 = false, plante2 = false, plante3 = false, plante4 = false, plante5 = false;

        int vitesse1, vitesse2, vitesse3, vitesse4, vitesse5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<PictureBox> listPlantes = new List<PictureBox> { picEmplacement1, picEmplacement2, picEmplacement3, picEmplacement4, picEmplacement5 };

            foreach (PictureBox pic in listPlantes)
            {
                pic.AllowDrop = true;
                pic.DragEnter += Plante_DragEnter;
                pic.DragDrop += Plante_DragDrop;
                pic.BackColor = Color.Transparent;
            }
            picZombie1.Parent = picFond;
            picZombie2.Parent = picFond;
            picZombie3.Parent = picFond;
            picZombie4.Parent = picFond;
            picZombie5.Parent = picFond;
            picEmplacement1.Parent = picFond;
            picEmplacement2.Parent = picFond;
            picEmplacement3.Parent = picFond;
            picEmplacement4.Parent = picFond;
            picEmplacement5.Parent = picFond;
            picEmplacement1.BackColor = Color.ForestGreen;
            picEmplacement2.BackColor = Color.ForestGreen;
            picEmplacement3.BackColor = Color.ForestGreen;
            picEmplacement4.BackColor = Color.ForestGreen;
            picEmplacement5.BackColor = Color.ForestGreen;
        }

        private void Plante_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void Plante_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            if (pb != null)
            {
                pb.Image = (Image)e.Data.GetData(DataFormats.Bitmap);

                if (pb == picEmplacement1) zombie1 = true;
                if (pb == picEmplacement2) zombie2 = true;
                if (pb == picEmplacement3) zombie3 = true;
                if (pb == picEmplacement4) zombie4 = true;
                if (pb == picEmplacement5) zombie5 = true;
            }
        }

        private void picPlante1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && picPlante1.Image != null)
                picPlante1.DoDragDrop(picPlante1.Image, DragDropEffects.Copy);
        }

        private void picPlante2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && picPlante2.Image != null)
                picPlante2.DoDragDrop(picPlante2.Image, DragDropEffects.Copy);
        }

        private void picPlante3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && picPlante3.Image != null)
                picPlante3.DoDragDrop(picPlante3.Image, DragDropEffects.Copy);
        }

        private void btnCommencer_Click(object sender, EventArgs e)
        {
            if (!zombie1 && !zombie2 && !zombie3 && !zombie4 && !zombie5) return;

            if (zombie1 && picEmplacement1.Image != null) { vitesse1 = rd.Next(2, 5); picZombie1.Visible = true; }
            if (zombie2 && picEmplacement2.Image != null) { vitesse2 = rd.Next(2, 5); picZombie1.Visible = true; }
            if (zombie3 && picEmplacement3.Image != null) { vitesse3 = rd.Next(2, 5); picZombie1.Visible = true; }
            if (zombie4 && picEmplacement4.Image != null) { vitesse4 = rd.Next(2, 5); picZombie1.Visible = true; }
            if (zombie5 && picEmplacement5.Image != null) { vitesse5 = rd.Next(2, 5); picZombie1.Visible = true; }

            tmrZombies.Start();

            SoundPlayer sound = new SoundPlayer(Properties.Resources.Zombie1);
            sound.Play();
        }

        private void tmrZombie_Tick(object sender, EventArgs e)
        {
            if (zombie1)
            {
                picZombie1.Left -= vitesse1;
                if (Math.Abs(picZombie1.Left - picEmplacement1.Left) < 200)
                {
                    plante1 = true;
                    tmrPlante.Start();
                }
            }

            if (zombie2)
            {
                picZombie2.Left -= vitesse2;
                if (Math.Abs(picZombie2.Left - picEmplacement2.Left) < 200)
                {
                    plante2 = true;
                    tmrPlante.Start();
                }
            }

            if (zombie3)
            {
                picZombie3.Left -= vitesse3;
                if (Math.Abs(picZombie3.Left - picEmplacement3.Left) < 200)
                {
                    plante3 = true;
                    tmrPlante.Start();
                }
            }

            if (zombie4)
            {
                picZombie4.Left -= vitesse4;
                if (Math.Abs(picZombie4.Left - picEmplacement4.Left) < 200)
                {
                    plante4 = true;
                    tmrPlante.Start();
                }
            }

            if (zombie5)
            {
                picZombie5.Left -= vitesse5;
                if (Math.Abs(picZombie5.Left - picEmplacement5.Left) < 200)
                {
                    plante5 = true;
                    tmrPlante.Start();
                }
            }
        }

        private void tmrPlante_Tick(object sender, EventArgs e)
        {
            if (plante1)
            {
                picEmplacement1.Left += 5;
                if (picEmplacement1.Bounds.IntersectsWith(picZombie1.Bounds))
                {
                    picZombie1.Width -= 10;
                    if (picZombie1.Width < 1)
                    {
                        picEmplacement1.Visible = false;
                        plante1 = false;
                        zombie1 = false;
                    }
                }
            }

            if (plante2)
            {
                picEmplacement2.Left += 5;
                if (picEmplacement2.Bounds.IntersectsWith(picZombie2.Bounds))
                {
                    picZombie2.Width -= 10;
                    if (picZombie2.Width < 1)
                    {
                        picEmplacement2.Visible = false;
                        plante2 = false;
                        zombie2 = false;
                    }
                }
            }

            if (plante3)
            {
                picEmplacement3.Left += 5;
                if (picEmplacement3.Bounds.IntersectsWith(picZombie3.Bounds))
                {
                    picZombie3.Width -= 10;
                    if (picZombie3.Width < 1)
                    {
                        picEmplacement3.Visible = false;
                        plante3 = false;
                        zombie3 = false;
                    }
                }
            }

            if (plante4)
            {
                picEmplacement4.Left += 5;
                if (picEmplacement4.Bounds.IntersectsWith(picZombie4.Bounds))
                {
                    picZombie4.Width -= 10;
                    if (picZombie4.Width < 1)
                    {
                        picEmplacement4.Visible = false;
                        plante4 = false;
                        zombie4 = false;
                    }
                }
            }

            if (plante5)
            {
                picEmplacement5.Left += 5;
                if (picEmplacement5.Bounds.IntersectsWith(picZombie5.Bounds))
                {
                    picZombie5.Width -= 10;
                    if (picZombie5.Width < 1)
                    {
                        picEmplacement5.Visible = false;
                        plante5 = false;
                        zombie5 = false;
                    }
                }
            }
        }
    }
}
