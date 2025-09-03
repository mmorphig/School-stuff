namespace Travail_5
{
    partial class Commencer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Commencer));
            this.btnDebutant = new System.Windows.Forms.Button();
            this.btnIntermediaire = new System.Windows.Forms.Button();
            this.btnDifficile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTexteMenu = new System.Windows.Forms.Label();
            this.btnJouer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDebutant
            // 
            this.btnDebutant.BackColor = System.Drawing.Color.Lime;
            this.btnDebutant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDebutant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDebutant.Location = new System.Drawing.Point(12, 274);
            this.btnDebutant.Name = "btnDebutant";
            this.btnDebutant.Size = new System.Drawing.Size(150, 75);
            this.btnDebutant.TabIndex = 0;
            this.btnDebutant.Text = "Débutant";
            this.btnDebutant.UseVisualStyleBackColor = false;
            // 
            // btnIntermediaire
            // 
            this.btnIntermediaire.BackColor = System.Drawing.Color.Yellow;
            this.btnIntermediaire.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIntermediaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntermediaire.Location = new System.Drawing.Point(168, 274);
            this.btnIntermediaire.Name = "btnIntermediaire";
            this.btnIntermediaire.Size = new System.Drawing.Size(150, 75);
            this.btnIntermediaire.TabIndex = 1;
            this.btnIntermediaire.Text = "Intermédiaire";
            this.btnIntermediaire.UseVisualStyleBackColor = false;
            // 
            // btnDifficile
            // 
            this.btnDifficile.BackColor = System.Drawing.Color.Red;
            this.btnDifficile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDifficile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDifficile.Location = new System.Drawing.Point(324, 274);
            this.btnDifficile.Name = "btnDifficile";
            this.btnDifficile.Size = new System.Drawing.Size(150, 75);
            this.btnDifficile.TabIndex = 2;
            this.btnDifficile.Text = "Difficile";
            this.btnDifficile.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Travail_5.Properties.Resources.labyrinthe;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 256);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblTexteMenu
            // 
            this.lblTexteMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexteMenu.Location = new System.Drawing.Point(481, 12);
            this.lblTexteMenu.Name = "lblTexteMenu";
            this.lblTexteMenu.Size = new System.Drawing.Size(157, 256);
            this.lblTexteMenu.TabIndex = 4;
            this.lblTexteMenu.Text = resources.GetString("lblTexteMenu.Text");
            this.lblTexteMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnJouer
            // 
            this.btnJouer.BackColor = System.Drawing.Color.LightGray;
            this.btnJouer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJouer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJouer.Location = new System.Drawing.Point(484, 274);
            this.btnJouer.Name = "btnJouer";
            this.btnJouer.Size = new System.Drawing.Size(154, 75);
            this.btnJouer.TabIndex = 5;
            this.btnJouer.Text = "Jouer";
            this.btnJouer.UseVisualStyleBackColor = false;
            this.btnJouer.Click += new System.EventHandler(this.btnJouer_Click);
            // 
            // Commencer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 361);
            this.Controls.Add(this.btnJouer);
            this.Controls.Add(this.lblTexteMenu);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDifficile);
            this.Controls.Add(this.btnIntermediaire);
            this.Controls.Add(this.btnDebutant);
            this.Name = "Commencer";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Commencer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDebutant;
        private System.Windows.Forms.Button btnIntermediaire;
        private System.Windows.Forms.Button btnDifficile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTexteMenu;
        private System.Windows.Forms.Button btnJouer;
    }
}

