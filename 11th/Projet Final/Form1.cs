using Microsoft.VisualBasic.Devices;
using Projet_Final.Properties;
using System.Diagnostics;
using System.Numerics;

namespace Projet_Final
{
    public partial class Form1 : Form
    {
        public class GameObject
        {
            public int[] position;
            public int tempsDeVie; // Vie restante en secondes
            public int type; // 0 = pièce, 1 = ennemi, 2 = ami
            public bool vivante; // Si l'objet est vivant ou pas, les pièces sont vivantes aussi
            public Control actualObject;
            public int vitesse;

            public GameObject(int[] position, Control actualObject)
            {
                Random rd = new Random();
                this.position = position;
                this.actualObject = actualObject;
                this.tempsDeVie = 5;
                this.type = 1; // Default type 1 (ennemi)
                this.vivante = true;
                this.vitesse = rd.Next(1, 4);
            }
            public GameObject(int[] position, Control actualObject, int type)
            {
                Random rd = new Random();
                this.position = position;
                this.actualObject = actualObject;
                this.tempsDeVie = 5;
                this.type = type;
                this.vivante = true;
                this.vitesse = rd.Next(1, 4);
            }
            public GameObject(Control actualObject)
            {
                Random rd = new Random();
                this.position = new int[] { 0, 0 };
                this.actualObject = actualObject;
                this.tempsDeVie = 5;
                this.type = 1; // Default type 1 (ennemi)
                this.vivante = true;
                this.vitesse = rd.Next(1, 4);
            }
        }

        Random rd = new Random();
        bool debug = false;
        List<GameObject> gameObjects;
        public GameObject joueur;
        public int[] windowGrandeur, windowPos, displaySize, windowOffset;
        public int valeurPiece = 1, points;
        public int montantAug1 = 0, montantAug2 = 0, montantAug3 = 0;
        private HashSet<Keys> keysPressed = new();
        bool drag = false; // Si le joueur est en train de drag l'image
        bool bouge = false; // Si le joueur est en train de bouger un pictureBox
        int tempsDeGrace = 0; // Temps de grâce avant que le joueur ne puisse être touché par un ennemi après drop une image
        bool perdu = false; // Si le joueur a perdu ou pas
        Point Pinitial; // Position initiale du pictureBox lors du drag

        public Form1()
        {
            InitializeComponent();
        }

        public void Cree_Ennemi(int[] pos)
        {
            // Initialize le nouveau PictureBox
            PictureBox picTemp = new PictureBox();
            picTemp.Image = Properties.Resources.ResourceManager.GetObject("macrophage") as Image;
            picTemp.SizeMode = PictureBoxSizeMode.Zoom;
            picTemp.Size = new Size(75, 50);
            picTemp.BackColor = Color.Transparent;
            picTemp.AllowDrop = true;
            picTemp.DragEnter += Joueur_DragEnter;
            picTemp.DragDrop += Joueur_DragDrop;
            picTemp.Visible = true;
            picTemp.Parent = this;

            gameObjects.Add(new GameObject(pos, picTemp));
        }

        public void Cree_Piece(int[] pos)
        {
            // Initialize le nouveau PictureBox
            PictureBox picTemp = new PictureBox();
            picTemp.Image = Properties.Resources.ResourceManager.GetObject("cellule") as Image;
            picTemp.SizeMode = PictureBoxSizeMode.Zoom;
            picTemp.Size = new Size(40, 40);
            picTemp.BackColor = Color.Transparent;
            picTemp.Visible = true;
            picTemp.Parent = this;
            picTemp.MouseDown += picPiece_MouseDown;
            picTemp.MouseMove += picPiece_MouseMove;
            picTemp.MouseUp += picPiece_MouseUp;
            gameObjects.Add(new GameObject(pos, picTemp, 0));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tmrTick.Start();
            tmrTueAmis.Start();
            windowGrandeur = [(int)Math.Ceiling((float)(Screen.PrimaryScreen.Bounds.Size.Width / 4)), (int)Math.Ceiling((float)(Screen.PrimaryScreen.Bounds.Size.Height / 2.25))];
            windowPos = [0, 0];
            displaySize = [Screen.PrimaryScreen.Bounds.Size.Width, Screen.PrimaryScreen.Bounds.Size.Height];
            windowOffset = [0, 0];
            this.Width = displaySize[0];
            this.Height = displaySize[1];
            this.Left = 0;
            this.Top = 0;
            gameObjects = new List<GameObject>();
            joueur = new GameObject([100, 100], picJoueur);
            for (int i = 0; i < 10; i++)
            { // Crée des ennemis
              // Initialize le nouveau PictureBox
                PictureBox picTemp = new PictureBox();
                picTemp.SizeMode = PictureBoxSizeMode.Zoom;
                picTemp.Image = Properties.Resources.ResourceManager.GetObject("macrophage") as Image;
                picTemp.Size = new Size(75, 50);
                picTemp.BackColor = Color.Transparent;
                picTemp.AllowDrop = true;
                picTemp.DragEnter += Joueur_DragEnter;
                picTemp.DragDrop += Joueur_DragDrop;
                picTemp.Visible = true;
                picTemp.Parent = this;
                int[] nouvellePos = [rd.Next(0, displaySize[0] - picTemp.Width), rd.Next(0, displaySize[1] - picTemp.Height - 96)];
                int distanceX = Cursor.Position.X - nouvellePos[0];
                int disanceY = Cursor.Position.Y - nouvellePos[1];
                while (Math.Sqrt(distanceX * distanceX + disanceY * disanceY) < 400)
                {
                    distanceX = Cursor.Position.X - nouvellePos[0];
                    disanceY = Cursor.Position.Y - nouvellePos[1];
                    nouvellePos = [rd.Next(0, displaySize[0] - picTemp.Width), rd.Next(0, displaySize[1] - picTemp.Height - 96)];
                }
                gameObjects.Add(new GameObject(nouvellePos, picTemp));
            }
            for (int i = 0; i < 10; i++)
            { // Crée des pièces
                Cree_Piece([rd.Next(0, displaySize[0] - 40), rd.Next(0, displaySize[1] - 146)]);
            }
            picJoueur.Image = Properties.Resources.ResourceManager.GetObject("virus") as Image;
            picJoueur.BackColor = Color.Transparent;
            joueur.vitesse = 5;
            // Bouge le jouer pour donner le curseur un espace sécurisé au début du jeu
            joueur.position[0] = Cursor.Position.X;
            joueur.position[1] = Cursor.Position.Y;
        }

        private void Form1_Resize()
        {
            this.Width = windowGrandeur[0];
            this.Height = windowGrandeur[1];
            this.Left = windowPos[0];
            this.Top = windowPos[1];
        }

        public void Perdre()
        {
            perdu = true; // Le joueur a perdu
            tmrTueAmis.Stop();
            Form3 formPerdu = new Form3(this);
            formPerdu.Show();
            //this.Close();
        }

        private void MainTick(object sender, EventArgs e)
        {
            if (perdu)
            { // Si le joueur a perdu, ne fait rien
                if (!Application.OpenForms.OfType<Form3>().Any()) 
                    Perdre(); // Si le joueur a perdu et que Form3 n'est pas déjà ouvert, exécute Perdre()
                return; 
            }; 
            List<GameObject> vivantes = new List<GameObject>();
            foreach (GameObject obj in gameObjects)
            {
                PictureBox objet = obj.actualObject as PictureBox;
                if (obj.type == 0) // Pièce
                {
                    // Loop lente pour la collecte de la pièce
                    foreach (GameObject objCollision in gameObjects)
                    {
                        if (objCollision.type == 1 || objCollision.type == 0) continue; // Skip les autres pièces et les ennemis
                        if (obj.actualObject.Bounds.IntersectsWith(objCollision.actualObject.Bounds)) // Un ami le touche
                        {
                            obj.vivante = false;
                            points += valeurPiece;
                        }
                    }
                    // Test si le joueur le touche
                    if (joueur.actualObject.Bounds.IntersectsWith(objet.Bounds))
                    {
                        obj.vivante = false;
                        points += valeurPiece;
                    }
                }
                else if (obj.type == 1) // Ennemi
                {
                    // Position du Ennemi
                    Point positionActuelle = new Point(obj.position[0], obj.position[1]);

                    // Position cible
                    Point cible = new Point(Cursor.Position.X - (objet.Width / 2), Cursor.Position.Y - (objet.Height));

                    // Distance au joueur
                    int dxJoueur = joueur.position[0] - obj.position[0];
                    int dyJoueur = joueur.position[1] - obj.position[1];
                    double distanceAuJoueur = Math.Sqrt(dxJoueur * dxJoueur + dyJoueur * dyJoueur);

                    double safeDistance = 150.0; // Distance maximale cible au joueur en pixels

                    int dx, dy;
                    if (distanceAuJoueur < safeDistance)
                    {
                        dx = -dxJoueur;
                        dy = -dyJoueur;
                    }
                    else
                    {
                        dx = cible.X - positionActuelle.X;
                        dy = cible.Y - positionActuelle.Y;
                    }

                    double distance = Math.Sqrt(dx * dx + dy * dy);
                    if (distance < obj.vitesse && distance > 0)
                    {
                        obj.position = [positionActuelle.X + dx, positionActuelle.Y + dy];
                    }
                    else if (distance > 0)
                    {
                        int deplacementX = (int)Math.Round(obj.vitesse * dx / distance);
                        int deplacementY = (int)Math.Round(obj.vitesse * dy / distance);
                        if (deplacementX == 0 && dx != 0) deplacementX = dx > 0 ? 1 : -1;
                        if (deplacementY == 0 && dy != 0) deplacementY = dy > 0 ? 1 : -1;
                        obj.position = [positionActuelle.X + deplacementX, positionActuelle.Y + deplacementY];
                    }

                    // Test si l'ennemi as atteint le curseur
                    if (Cursor.Position.X >= obj.position[0] && Cursor.Position.X <= obj.position[0] + objet.Width &&
                        Cursor.Position.Y >= obj.position[1] && Cursor.Position.Y <= obj.position[1] + objet.Height)
                    {
                        // Perdu
                        if (!(tempsDeGrace > 0 || drag || perdu || Application.OpenForms.OfType<Form3>().Any())) // Si le joueur est en temps de grâce, ne perds pas
                            Perdre();
                    }
                    // Test si le joueur le touche
                    if (joueur.actualObject.Bounds.IntersectsWith(objet.Bounds))
                    {
                        obj.vivante = false;
                    }
                }
                else if (obj.type == 2) // Ami
                {
                    // Bouge l'ami aléatoirement
                    obj.position[0] += rd.Next(-10, 11);
                    obj.position[1] += rd.Next(-10, 11);
                }

                // Refait la liste d'objets vivantes
                if (obj.vivante)
                {
                    vivantes.Add(obj);
                }
                else
                {
                    if (obj.type == 0) // Pièce
                    {
                        // Crée une nouvelle pièce
                        // Initialize le nouveau PictureBox
                        PictureBox picTemp = new PictureBox();
                        picTemp.Image = Properties.Resources.ResourceManager.GetObject("cellule") as Image;
                        picTemp.SizeMode = PictureBoxSizeMode.Zoom;
                        picTemp.Size = new Size(40, 40);
                        picTemp.BackColor = Color.Transparent;
                        picTemp.Visible = true;
                        picTemp.Parent = this;
                        picTemp.MouseDown += picPiece_MouseDown;
                        picTemp.MouseMove += picPiece_MouseMove;
                        picTemp.MouseUp += picPiece_MouseUp;
                        vivantes.Add(new GameObject([rd.Next(0, displaySize[0] - obj.actualObject.Width), rd.Next(0, displaySize[1] - obj.actualObject.Height - 96)], picTemp, 0));
                    }
                    else if (obj.type == 1 || obj.type == 2) // Ennemi ou ami meurt, crée un nouvel ennemi
                    {
                        // Crée un nouvel ennemi
                        // Initialize le nouveau PictureBox
                        PictureBox picTemp = new PictureBox();
                        picTemp.SizeMode = PictureBoxSizeMode.Zoom;
                        picTemp.Image = Properties.Resources.ResourceManager.GetObject("macrophage") as Image;
                        picTemp.Size = new Size(75, 50);
                        picTemp.BackColor = Color.Transparent;
                        picTemp.AllowDrop = true;
                        picTemp.DragEnter += Joueur_DragEnter;
                        picTemp.DragDrop += Joueur_DragDrop;
                        picTemp.Visible = true;
                        picTemp.Parent = this;
                        int[] nouvellePos = [rd.Next(0, displaySize[0] - obj.actualObject.Width), rd.Next(0, displaySize[1] - obj.actualObject.Height - 96)];
                        int distanceX = Cursor.Position.X - nouvellePos[0];
                        int disanceY = Cursor.Position.Y - nouvellePos[1];
                        while (Math.Sqrt(distanceX * distanceX + disanceY * disanceY) < 400)
                        {
                            distanceX = Cursor.Position.X - nouvellePos[0];
                            disanceY = Cursor.Position.Y - nouvellePos[1];
                            nouvellePos = [rd.Next(0, displaySize[0] - obj.actualObject.Width), rd.Next(0, displaySize[1] - obj.actualObject.Height - 96)];
                        }
                        vivantes.Add(new GameObject(nouvellePos, picTemp));
                    }
                    obj.actualObject.Dispose(); // Dispose l'objet
                }

                // Bouge l'objet
                objet.Left = obj.position[0] - windowPos[0];
                objet.Top = obj.position[1] - windowPos[1];
            }

            gameObjects = vivantes;

            BougeJoueur();
            joueur.actualObject.Left = joueur.position[0] - windowPos[0];
            joueur.actualObject.Top = joueur.position[1] - windowPos[1];

            this.windowPos = [Cursor.Position.X - (windowGrandeur[0] / 2), Cursor.Position.Y - (windowGrandeur[1] / 2)];
            Form1_Resize();
            lblPoints.Location = new Point(10, 10);
            if (debug) // Montre la position du curseur si debug est vrai
            {
                lblPoints.Text = "Points: " + points + "\n" +
                    "X: " + Cursor.Position.X + "   Y: " + Cursor.Position.Y + "\n" +
                    "X: " + joueur.position[0] + "   Y: " + joueur.position[1];
            }
            else
            {
                lblPoints.Text = "Points: " + points + "\nPêse H pour aide";
            }
        }

        private void Joueur_DragEnter(object? sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void Joueur_DragDrop(object? sender, DragEventArgs e)
        {
            drag = false; // Le joueur n'est plus en train de drag l'image
            tempsDeGrace = 2; // Donne le temps de grâce (2 secondes)
            tmrGrace.Start(); // Démarre le timer de grâce
            if (sender is not PictureBox pb || e.Data == null)
                return;

            // Trouve l'objet ami correspondant
            var amiObj = gameObjects.FirstOrDefault(obj => obj.actualObject == pb && obj.type == 1);
            if (amiObj != null)
            {
                var img = e.Data.GetData(DataFormats.Bitmap) as Image;
                if (img != null)
                {
                    pb.Image = img;
                    amiObj.type = 2;
                    amiObj.actualObject.BackColor = Color.Transparent;
                }
            }
        }

        public void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (!keysPressed.Contains(e.KeyCode))
                keysPressed.Add(e.KeyCode);
            e.Handled = true;
        }

        public void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            keysPressed.Remove(e.KeyCode);
            e.Handled = true;
        }

        private void BougeJoueur()
        {
        // Bouge le joueur selon les touches pressées, fait sûr que le joueur ne sort pas de l'écran
        int dx = 0, dy = 0;
            if ((keysPressed.Contains(Keys.Up) || keysPressed.Contains(Keys.W)) && joueur.position[1] > 0)
                dy -= joueur.vitesse;
            if ((keysPressed.Contains(Keys.Down) || keysPressed.Contains(Keys.S)) && joueur.position[1] < displaySize[1] - joueur.actualObject.Height - 96)
                dy += joueur.vitesse;
            if ((keysPressed.Contains(Keys.Left) || keysPressed.Contains(Keys.A)) && joueur.position[0] > 0)
                dx -= joueur.vitesse;
            if ((keysPressed.Contains(Keys.Right) || keysPressed.Contains(Keys.D)) && joueur.position[0] < displaySize[0] - joueur.actualObject.Width)
                dx += joueur.vitesse;
            joueur.position[0] += dx;
            joueur.position[1] += dy;

            if (keysPressed.Contains(Keys.Q))
                this.Close();
            if (keysPressed.Contains(Keys.E))
            {
                Form2 form2 = new Form2(this);
                form2.Show();
                keysPressed.Remove(Keys.E);
            }
            if (keysPressed.Contains(Keys.H))
            {
                Form4 form4 = new Form4();
                form4.Show();
                keysPressed.Remove(Keys.H);
            }
        }
        private void tmrTueAmis_Tick(object sender, EventArgs e)
        {
            foreach (GameObject obj in gameObjects)
            {
                if (obj.type == 2) // Ami
                {
                    if (obj.tempsDeVie > 0)
                    {
                        obj.tempsDeVie--; // Diminue la vie de l'ami
                    }
                    else
                    {
                        obj.vivante = false; // L'ami est mort
                    }
                }
            }
        }

        private void Joueur_MouseDown(object? sender, MouseEventArgs e)
        {
            drag = true; // Le joueur est en train de drag l'image
            if (picJoueur.Image != null)
            {
                picJoueur.DoDragDrop(picJoueur.Image, DragDropEffects.Copy);
            }
        }

        private void picPiece_MouseDown(object sender, MouseEventArgs e)
        {
            if (((PictureBox)sender).Visible == false) return;
            bouge = true;
            Pinitial = Cursor.Position;
        }

        private void picPiece_MouseMove(object sender, MouseEventArgs e)
        {
            if (bouge && e.Button == MouseButtons.Left)
            {
                if (sender is not PictureBox pb)
                    return;

                int offsetX = Cursor.Position.X - Pinitial.X;
                int offsetY = Cursor.Position.Y - Pinitial.Y;

                pb.Left = pb.Left;
                pb.Top = pb.Top;

                var pieceObj = gameObjects.FirstOrDefault(obj => obj.actualObject == pb && obj.type == 0);
                if (pieceObj != null)
                {
                    pieceObj.position[0] = pb.Left + windowPos[0];
                    pieceObj.position[1] = pb.Top + windowPos[1];
                }

                Pinitial = Cursor.Position;
            }
        }

        private void picPiece_MouseUp(object sender, MouseEventArgs e)
        {
            bouge = false;
        }

        private void tmrGrace_Tick(object sender, EventArgs e)
        {
            tempsDeGrace--;
            if (tempsDeGrace <= 0)
            {
                tmrGrace.Stop(); // Arrête le timer de grâce
            }
        }
    }
}
