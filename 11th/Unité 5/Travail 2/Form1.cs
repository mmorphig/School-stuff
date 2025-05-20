using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }
        private Point Pinitial;
        private bool bouge = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < imgListe.Images.Count; i++)
            {
                cmbImages.Items.Add(i);
            }

            cmbImages.MaxDropDownItems = imgListe.Images.Count;
            cmbImages.DrawMode = DrawMode.OwnerDrawVariable;
            cmbImages.DrawItem += cmbImages_DrawItem;
            cmbImages.MeasureItem += cmbImages_MeasureItem;
            cmbImages.SelectedIndexChanged += cmbImages_SelectedIndexChanged;

            picDemo.Visible = false;
            picDemo.MouseDown += picDemo_MouseDown;
            picDemo.MouseMove += picDemo_MouseMove;
            picDemo.MouseUp += picDemo_MouseUp;
        }

        private void cmbImages_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();

            if (e.Index >= 0)
            {
                Image img = imgListe.Images[e.Index];
                e.Graphics.DrawImage(img, new Rectangle(e.Bounds.Left, e.Bounds.Top, 40, 40));
            }

            e.DrawFocusRectangle();
        }

        private void cmbImages_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = 45;
        }

        private void cmbImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            picDemo.Visible = true;
            picDemo.Image = SelectImage(cmbImages.SelectedIndex);
            picDemo.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private Image SelectImage(int selectedIndex)
        {
            Image photo = null;

            switch (selectedIndex)
            {
                case 0:
                    photo = Properties.Resources.image0;
                    break;
                case 1:
                    photo = Properties.Resources.image1;
                    break;
                case 2:
                    photo = Properties.Resources.image2;
                    break;
                case 3:
                    photo = Properties.Resources.image3;
                    break;
                case 4:
                    photo = Properties.Resources.image4;
                    break;
                case 5:
                    photo = Properties.Resources.image5;
                    break;
            }

            return photo;
        }

        private void picDemo_MouseDown(object sender, MouseEventArgs e)
        {
            bouge = true;
            Pinitial = e.Location;
        }

        private void picDemo_MouseMove(object sender, MouseEventArgs e)
        {
            if (bouge && e.Button == MouseButtons.Left || e.Button == MouseButtons.Right)
            {
                Point positionForme = picDemo.Location;

                positionForme.X += e.X - Pinitial.X;
                positionForme.Y += e.Y - Pinitial.Y;

                picDemo.Location = positionForme;
            }
        }

        private void picDemo_MouseUp(object sender, MouseEventArgs e)
        {
            bouge = false;
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
