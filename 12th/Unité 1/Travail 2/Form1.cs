using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail_2
{
    public partial class Form1 : Form
    {
        public class Etudiant
        {
            public string nom;
            public uint age;
            public DateTime dateNaissance;
            public DateTime dateEnregistement;
            public Etudiant(string nom, uint age, DateTime dateNaissance)
            {
                this.nom = nom;
                this.age = age;
                this.dateNaissance = dateNaissance;
                this.dateEnregistement = DateTime.Now;
            }
            public Etudiant(string nom, uint age, DateTime dateNaissance, DateTime dateEnregistement)
            {
                this.nom = nom;
                this.age = age;
                this.dateNaissance = dateNaissance;
                this.dateEnregistement = dateEnregistement;
            }
        }

        public Etudiant[] Telecharger() 
        {
            Etudiant[] etudiantsTelecharge = new Etudiant[] {
                new Etudiant("Jean Smithson", 21, new DateTime(1997, 12, 1), new DateTime(2021, 3, 10)),
                new Etudiant("Nima Abdo", 17, new DateTime(2001, 5, 23), new DateTime(2021, 7, 25)),
                new Etudiant("Simon Malheureux", 18, new DateTime(2000, 11, 15), new DateTime(2021, 5, 16)),
                new Etudiant("Rita Mou", 17, new DateTime(2001, 8, 30), new DateTime(2021, 10, 25))
            };
            return etudiantsTelecharge;
        }

        public void Afficher(Etudiant[] etudiantsAAfficher)
        {
            listView1.Items.Clear(); // Clear est inutile ici, mais utile dans une situation reelle
            foreach (Etudiant etudiant in etudiantsAAfficher)
            {
                listView1.Items.Add(new ListViewItem(new[] {
                    etudiant.nom, 
                    etudiant.age.ToString(), 
                    etudiant.dateNaissance.ToShortDateString(), 
                    etudiant.dateEnregistement.ToShortDateString() 
                }));
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB"); // pour avoir dd/mm/YYYY
            Etudiant[] etudiants = Telecharger();
            Afficher(etudiants);
        }
    }
}
