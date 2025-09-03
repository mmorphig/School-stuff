namespace Travail_2
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblJeux = new System.Windows.Forms.Label();
            this.lblPoints = new System.Windows.Forms.Label();
            this.picHautGauche = new System.Windows.Forms.PictureBox();
            this.picHautDroit = new System.Windows.Forms.PictureBox();
            this.picBasGauche = new System.Windows.Forms.PictureBox();
            this.picBasDroite = new System.Windows.Forms.PictureBox();
            this.btnGenere = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picHautGauche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHautDroit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasGauche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasDroite)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Info;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(12, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Points gagnées";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(12, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de parties";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblJeux
            // 
            this.lblJeux.BackColor = System.Drawing.SystemColors.Info;
            this.lblJeux.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblJeux.Location = new System.Drawing.Point(118, 198);
            this.lblJeux.Name = "lblJeux";
            this.lblJeux.Size = new System.Drawing.Size(50, 23);
            this.lblJeux.TabIndex = 2;
            this.lblJeux.Text = "25";
            this.lblJeux.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPoints
            // 
            this.lblPoints.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lblPoints.Location = new System.Drawing.Point(118, 229);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(50, 23);
            this.lblPoints.TabIndex = 3;
            this.lblPoints.Text = "0";
            this.lblPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picHautGauche
            // 
            this.picHautGauche.BackColor = System.Drawing.Color.Lime;
            this.picHautGauche.Location = new System.Drawing.Point(12, 12);
            this.picHautGauche.Name = "picHautGauche";
            this.picHautGauche.Size = new System.Drawing.Size(75, 75);
            this.picHautGauche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHautGauche.TabIndex = 4;
            this.picHautGauche.TabStop = false;
            this.picHautGauche.Click += new System.EventHandler(this.picClick);
            // 
            // picHautDroit
            // 
            this.picHautDroit.BackColor = System.Drawing.Color.Yellow;
            this.picHautDroit.Location = new System.Drawing.Point(93, 12);
            this.picHautDroit.Name = "picHautDroit";
            this.picHautDroit.Size = new System.Drawing.Size(75, 75);
            this.picHautDroit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHautDroit.TabIndex = 5;
            this.picHautDroit.TabStop = false;
            this.picHautDroit.Click += new System.EventHandler(this.picClick);
            // 
            // picBasGauche
            // 
            this.picBasGauche.BackColor = System.Drawing.Color.Red;
            this.picBasGauche.Location = new System.Drawing.Point(12, 93);
            this.picBasGauche.Name = "picBasGauche";
            this.picBasGauche.Size = new System.Drawing.Size(75, 75);
            this.picBasGauche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBasGauche.TabIndex = 6;
            this.picBasGauche.TabStop = false;
            this.picBasGauche.Click += new System.EventHandler(this.picClick);
            // 
            // picBasDroite
            // 
            this.picBasDroite.BackColor = System.Drawing.Color.Blue;
            this.picBasDroite.Location = new System.Drawing.Point(93, 93);
            this.picBasDroite.Name = "picBasDroite";
            this.picBasDroite.Size = new System.Drawing.Size(75, 75);
            this.picBasDroite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBasDroite.TabIndex = 7;
            this.picBasDroite.TabStop = false;
            this.picBasDroite.Click += new System.EventHandler(this.picClick);
            // 
            // btnGenere
            // 
            this.btnGenere.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenere.Location = new System.Drawing.Point(174, 52);
            this.btnGenere.Name = "btnGenere";
            this.btnGenere.Size = new System.Drawing.Size(93, 35);
            this.btnGenere.TabIndex = 8;
            this.btnGenere.Text = "Génère";
            this.btnGenere.UseVisualStyleBackColor = true;
            this.btnGenere.Click += new System.EventHandler(this.btnGenere_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(279, 261);
            this.Controls.Add(this.btnGenere);
            this.Controls.Add(this.picBasDroite);
            this.Controls.Add(this.picBasGauche);
            this.Controls.Add(this.picHautDroit);
            this.Controls.Add(this.picHautGauche);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.lblJeux);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "Attrape Mario";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHautGauche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHautDroit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasGauche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBasDroite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblJeux;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.PictureBox picHautGauche;
        private System.Windows.Forms.PictureBox picHautDroit;
        private System.Windows.Forms.PictureBox picBasGauche;
        private System.Windows.Forms.PictureBox picBasDroite;
        private System.Windows.Forms.Button btnGenere;
    }
}

