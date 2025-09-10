using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Travail_4
{
    public partial class Form1 : Form
    {
        // Utilise des listes pour facilement agrandir la liste des noms déjà ajoutés sans stresser quelqu'un qui sait c++
        List<ListViewItem> itemsF = new List<ListViewItem> { };
        List<ListViewItem> itemsM = new List<ListViewItem> { };
        byte t; // Compte seulement jusqu'à 5 pour le timer, byte est suffisant
        // Crée les colonnes pour le listView des noms
        private ColumnHeader columnHeader4 = new ColumnHeader(), 
            columnHeader1 = new ColumnHeader(), 
            columnHeader2 = new ColumnHeader(), 
            columnHeader3 = new ColumnHeader();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialise les colonnes du listView des noms
            columnHeader4.Text = "Nom";
            columnHeader4.Width = 100;
            columnHeader1.Text = "Titre du poste";
            columnHeader1.Width = 120;
            columnHeader2.Text = "Fonction";
            columnHeader2.Width = 140;
            columnHeader3.Text = "Genre";
            columnHeader3.Width = 50;
            listNoms.Columns.AddRange(new ColumnHeader[4] { columnHeader4, columnHeader1, columnHeader2, columnHeader3 });
            listNoms.View = View.Details;

            Remplir();
        }

        private void Remplir()
        {
            listNoms.Items.Add(new ListViewItem(new[] { "Andréa Cheney", "Superviseur de l'équipe IT", "Planification", "F" }));
            listNoms.Items.Add(new ListViewItem(new[] { "Justin Trudeau", "Premier Ministre", "Voyager", "M" }));
            listNoms.Items.Add(new ListViewItem(new[] { "George Estibal", "Chef de chantier", "Construction", "M" }));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t++;
            if (t == 5) {
                lblMessage.Visible = false;
                timer1.Stop();
                t = 0;
            }
        }

        private void listNoms_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewItem itemNom = listNoms.GetItemAt(e.X, e.Y);
            if (itemNom == null) return;
            string itemNomGenre = itemNom.SubItems[3].Text;
            if (itemNomGenre == null) return;
            if (itemsF.Contains(itemNom) || itemsM.Contains(itemNom))
            {
                // Sans offset la position est un peu mal
                lblMessage.Location = new Point(e.X + 10, e.Y + 10);
                lblMessage.Visible = true;
                timer1.Start();
            }
            else if (itemNomGenre == "F")
            {
                listF.Items.Add(new ListViewItem(itemNom.SubItems[0].Text));
                itemsF.Add(itemNom);
            }
            else if (itemNomGenre == "M") 
            {
                listM.Items.Add(new ListViewItem(itemNom.SubItems[0].Text));
                itemsM.Add(itemNom);
            }
        }
    }
}
