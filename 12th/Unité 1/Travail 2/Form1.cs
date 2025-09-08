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
            // Utilise byte, qui limite les ages a 0-255
            public byte age;
            // Utilise DateTime pour les dates pour être plus flexible
            public DateTime dateNaissance;
            public DateTime dateEnregistement;
            // 2 Constructeurs, un avec dateEnregistement par defaut a aujourd'hui pour le premier
            public Etudiant(string nom, byte age, DateTime dateNaissance)
            {
                this.nom = nom;
                // Pourrait faire un XOR ((byte)(age ^ 0b10000000)) pour un clamp entre 0-127 mais quelques personnes vivent longtemps maintenenant
                this.age = age;
                this.dateNaissance = dateNaissance;
                this.dateEnregistement = DateTime.Now;
            }
            public Etudiant(string nom, byte age, DateTime dateNaissance, DateTime dateEnregistement)
            {
                this.nom = nom;
                this.age = age;
                this.dateNaissance = dateNaissance;
                this.dateEnregistement = dateEnregistement;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public Etudiant[] Telecharger() 
        {
            return new Etudiant[] {
                new Etudiant("Jean Smithson", 21, new DateTime(1997, 12, 1), new DateTime(2021, 3, 10)),
                new Etudiant("Nima Abdo", 17, new DateTime(2001, 5, 23), new DateTime(2021, 7, 25)),
                new Etudiant("Simon Malheureux", 18, new DateTime(2000, 11, 15), new DateTime(2021, 5, 16)),
                new Etudiant("Rita Mou", 17, new DateTime(2001, 8, 30), new DateTime(2021, 10, 25))
            };
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

        private void Form1_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-GB"); // Pour avoir dd/mm/YYYY (même fr-CA ne donne pas la bonne)
            Etudiant[] etudiants = Telecharger();
            Afficher(etudiants);
        }
    }
}
