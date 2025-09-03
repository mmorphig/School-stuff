namespace Zig_zag
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.tmrÉtoiles = new System.Windows.Forms.Timer(this.components);
            this.btnCertificat = new System.Windows.Forms.Button();
            this.picFond = new System.Windows.Forms.PictureBox();
            this.picLuigi = new System.Windows.Forms.PictureBox();
            this.picEtoile1 = new System.Windows.Forms.PictureBox();
            this.picEtoile2 = new System.Windows.Forms.PictureBox();
            this.picEtoile3 = new System.Windows.Forms.PictureBox();
            this.picGagner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLuigi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEtoile1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEtoile2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEtoile3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGagner)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 289;
            this.label2.Text = "Points";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(55, 0);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(139, 29);
            this.txtNom.TabIndex = 286;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 287;
            this.label1.Text = "Nom ";
            // 
            // lblPoints
            // 
            this.lblPoints.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoints.Location = new System.Drawing.Point(462, 1);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(37, 19);
            this.lblPoints.TabIndex = 295;
            // 
            // tmrÉtoiles
            // 
            this.tmrÉtoiles.Enabled = true;
            this.tmrÉtoiles.Tick += new System.EventHandler(this.tmrÉtoiles_Tick);
            // 
            // btnCertificat
            // 
            this.btnCertificat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCertificat.Location = new System.Drawing.Point(503, 226);
            this.btnCertificat.Name = "btnCertificat";
            this.btnCertificat.Size = new System.Drawing.Size(98, 35);
            this.btnCertificat.TabIndex = 296;
            this.btnCertificat.Text = "Afficher certificat";
            this.btnCertificat.UseVisualStyleBackColor = false;
            this.btnCertificat.Click += new System.EventHandler(this.btnCertificat_Click);
            // 
            // picFond
            // 
            this.picFond.BackColor = System.Drawing.Color.Transparent;
            this.picFond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFond.Image = global::Zig_zag.Properties.Resources.fond;
            this.picFond.Location = new System.Drawing.Point(0, 0);
            this.picFond.Name = "picFond";
            this.picFond.Size = new System.Drawing.Size(615, 270);
            this.picFond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFond.TabIndex = 297;
            this.picFond.TabStop = false;
            // 
            // picLuigi
            // 
            this.picLuigi.BackColor = System.Drawing.Color.Transparent;
            this.picLuigi.Image = ((System.Drawing.Image)(resources.GetObject("picLuigi.Image")));
            this.picLuigi.Location = new System.Drawing.Point(12, 198);
            this.picLuigi.Name = "picLuigi";
            this.picLuigi.Size = new System.Drawing.Size(43, 47);
            this.picLuigi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLuigi.TabIndex = 290;
            this.picLuigi.TabStop = false;
            // 
            // picEtoile1
            // 
            this.picEtoile1.BackColor = System.Drawing.Color.Transparent;
            this.picEtoile1.Image = global::Zig_zag.Properties.Resources.Étoile_3;
            this.picEtoile1.Location = new System.Drawing.Point(176, 64);
            this.picEtoile1.Name = "picEtoile1";
            this.picEtoile1.Size = new System.Drawing.Size(34, 44);
            this.picEtoile1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEtoile1.TabIndex = 291;
            this.picEtoile1.TabStop = false;
            // 
            // picEtoile2
            // 
            this.picEtoile2.BackColor = System.Drawing.Color.Transparent;
            this.picEtoile2.Image = global::Zig_zag.Properties.Resources.Étoile_3;
            this.picEtoile2.Location = new System.Drawing.Point(311, 181);
            this.picEtoile2.Name = "picEtoile2";
            this.picEtoile2.Size = new System.Drawing.Size(34, 44);
            this.picEtoile2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEtoile2.TabIndex = 292;
            this.picEtoile2.TabStop = false;
            // 
            // picEtoile3
            // 
            this.picEtoile3.BackColor = System.Drawing.Color.Transparent;
            this.picEtoile3.Image = global::Zig_zag.Properties.Resources.Étoile_3;
            this.picEtoile3.Location = new System.Drawing.Point(476, 51);
            this.picEtoile3.Name = "picEtoile3";
            this.picEtoile3.Size = new System.Drawing.Size(34, 44);
            this.picEtoile3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picEtoile3.TabIndex = 293;
            this.picEtoile3.TabStop = false;
            // 
            // picGagner
            // 
            this.picGagner.BackColor = System.Drawing.Color.Transparent;
            this.picGagner.Image = global::Zig_zag.Properties.Resources.luigi_gain;
            this.picGagner.Location = new System.Drawing.Point(462, 1);
            this.picGagner.Name = "picGagner";
            this.picGagner.Size = new System.Drawing.Size(191, 290);
            this.picGagner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGagner.TabIndex = 294;
            this.picGagner.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(615, 270);
            this.Controls.Add(this.picEtoile3);
            this.Controls.Add(this.picEtoile2);
            this.Controls.Add(this.picEtoile1);
            this.Controls.Add(this.btnCertificat);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.picGagner);
            this.Controls.Add(this.picLuigi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.picFond);
            this.Name = "Form1";
            this.Text = "Zig Zag";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLuigi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEtoile1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEtoile2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEtoile3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGagner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.Timer tmrÉtoiles;
        private System.Windows.Forms.Button btnCertificat;
        internal System.Windows.Forms.PictureBox picFond;
        internal System.Windows.Forms.PictureBox picLuigi;
        internal System.Windows.Forms.PictureBox picEtoile1;
        internal System.Windows.Forms.PictureBox picEtoile2;
        internal System.Windows.Forms.PictureBox picEtoile3;
        internal System.Windows.Forms.PictureBox picGagner;
    }
}

