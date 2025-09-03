using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail_1
{
    public partial class Form1 : Form
    {
        Control[] controlsTXT = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize le listView pour le fonctionnement qu'on veut
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.View = View.Details;
            controlsTXT = new Control[] { txtNom, txtFonction, txtGroupe}; // Array pour vider les textBox plus efficacement (crée ci-haut pour être globale)
            // Ajoute les items défaut en range
            listView1.Items.AddRange(new ListViewItem[] { 
                new ListViewItem(new[] { "Kadi", "Superviseurs", "Les Alliers" }), 
                new ListViewItem(new[] { "William", "Responsable", "Les Lasers" }) 
            });
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtNom.Text = listView1.SelectedItems[0].SubItems[0].Text;
                txtFonction.Text = listView1.SelectedItems[0].SubItems[1].Text;
                txtGroupe.Text = listView1.SelectedItems[0].SubItems[2].Text;
            }
            catch (Exception exc) // Bizarre ArgumentOutOfRangeException quand on change de sélection, on peut l'ignorer, ne change rien
            {
                Console.WriteLine(exc.ToString()); // ToString() est seulment pour faire sûr, pas requis
            }
        }

        private void btnEffacerSelection_Click(object sender, EventArgs e)
        {
            // Efface tout dans la sélection
            foreach (ListViewItem selected in listView1.SelectedItems) 
            {
                listView1.Items.RemoveAt(selected.Index);
            }
        }

        private void btnViderTextes_Click(object sender, EventArgs e)
        {
            foreach (Control c in controlsTXT) // Ne parcours pas tout les controles, seulement les textBox
            {
                c.Text = "";
            }
        }

        private void btnAjouterNouveau_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(new ListViewItem(new[] { txtNom.Text, txtFonction.Text, txtGroupe.Text }));
            // Pourrait vider les textes aussi avec:
            // btnViderTextes_Click(null, null);
        }

        private void btnEffacerTout_Click(object sender, EventArgs e)
        {
            // Vide les textes, fonction existe déja
            btnViderTextes_Click(null, null);

            listView1.Items.Clear();
        }
    }
}
