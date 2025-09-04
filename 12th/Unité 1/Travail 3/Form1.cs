using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travail_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* 
         * Grands blocs de commentaires est du code alternatif qui n'utilise pas un tableau 2D
         * Aussi marqué avec des regions avec un scope vide pour être plus visible
         * version 1D: mets en commentaire les regions 2D et enlève les commentaires des regions 1D
         * version 2D: mets en commentaire les regions 1D et enlève les commentaires des regions 2D
         */

        string[] infos = null;
        #region version2D
        string[][] infos2D = null;
        #endregion version2D

        private void Form1_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add(listView1.Columns.Count.ToString(), "Nom", 75);
            listView1.Columns.Add(listView1.Columns.Count.ToString(), "Prénom", 85);
            listView1.Columns.Add(listView1.Columns.Count.ToString(), "Date de naissance", 150);
            listView1.Columns.Add(listView1.Columns.Count.ToString(), "Addresse", 300);
        }

        private void btnOuvrirFichier_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog
            {
                Title = "Ouvrir un fichier texte",
                FileName = "Renseignement.txt", // Nom du fichier par défaut
                Filter = "Fichiers texte|*.txt", // Accepte seulement des fichiers .txt
                DefaultExt = "txt",
                InitialDirectory = Path.GetFullPath(
                    Path.Combine(Application.StartupPath, @"..\..\Resources") // Path au dossier Resources depuis le dossier du binaire, brise si on change les dossiers
                )
            };
            dialog.ShowDialog();

            if (dialog.FileName != "")
            {
                FileStream fichier = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read, FileShare.None);
                StreamReader streamFichier = new StreamReader(fichier);
                infos = streamFichier.ReadToEnd().Split('\n'); // Utile en version 1D et 2D
                #region version2D
                {
                    infos2D = new string[infos.Length][];
                    for (int i = 0; i < infos.Length; i++)
                    {
                        infos2D[i] = new string[4];
                        for (int j = 0; j < 4; j++)
                        {
                            int idx = i * 4 + j;
                            infos2D[i][j] = idx < infos.Length ? infos[idx] : ""; // Si la linge n'existe pas, ne l'accède pas
                        }
                    }
                }
                #endregion version2D
                streamFichier?.Close();
                fichier?.Close();
            }
        }

        private void btnAfficher_Click(object sender, EventArgs e)
        {
            if (infos == null) return;
            /*
            #region tableau1D
            {
                for (int i = 0; i < infos.Length; i += 4) // Loop par le nombre d'infos, 4 par personne
                {
                    listView1.Items.Add(new ListViewItem(new[] {
                            infos[i],
                            infos[i + 1],
                            infos[i + 2],
                            infos[i + 3]
                        }));
                }
            }
            #endregion tableau1D
            */
            #region version2D
            {
                if (infos2D == null) return;
                for (int i = 0; i < infos.Length; i++)
                {
                    listView1.Items.Add(new ListViewItem(new[] {
                        infos2D[i][0],
                        infos2D[i][1],
                        infos2D[i][2],
                        infos2D[i][3]
                    }));
                }
            }
            #endregion version2D
        }
    }
}
