namespace Travail_4
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
            this.components = new System.ComponentModel.Container();
            this.btnRecommencer = new System.Windows.Forms.Button();
            this.picPiste = new System.Windows.Forms.PictureBox();
            this.picHomme = new System.Windows.Forms.PictureBox();
            this.picFemme = new System.Windows.Forms.PictureBox();
            this.tmrAnimation = new System.Windows.Forms.Timer(this.components);
            this.picCoupe = new System.Windows.Forms.PictureBox();
            this.tmrFeux = new System.Windows.Forms.Timer(this.components);
            this.picFeux = new System.Windows.Forms.PictureBox();
            this.tmrCoupe = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPiste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHomme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFemme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoupe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFeux)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRecommencer
            // 
            this.btnRecommencer.Location = new System.Drawing.Point(122, 207);
            this.btnRecommencer.Name = "btnRecommencer";
            this.btnRecommencer.Size = new System.Drawing.Size(111, 23);
            this.btnRecommencer.TabIndex = 0;
            this.btnRecommencer.Text = "Recommencer";
            this.btnRecommencer.UseVisualStyleBackColor = true;
            this.btnRecommencer.Click += new System.EventHandler(this.recommence);
            // 
            // picPiste
            // 
            this.picPiste.Image = global::Travail_4.Properties.Resources.piste;
            this.picPiste.Location = new System.Drawing.Point(12, 12);
            this.picPiste.Name = "picPiste";
            this.picPiste.Size = new System.Drawing.Size(1160, 437);
            this.picPiste.TabIndex = 1;
            this.picPiste.TabStop = false;
            // 
            // picHomme
            // 
            this.picHomme.Image = global::Travail_4.Properties.Resources.homme1;
            this.picHomme.Location = new System.Drawing.Point(16, 48);
            this.picHomme.Name = "picHomme";
            this.picHomme.Size = new System.Drawing.Size(64, 64);
            this.picHomme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHomme.TabIndex = 2;
            this.picHomme.TabStop = false;
            // 
            // picFemme
            // 
            this.picFemme.Image = global::Travail_4.Properties.Resources.femme1;
            this.picFemme.Location = new System.Drawing.Point(16, 130);
            this.picFemme.Name = "picFemme";
            this.picFemme.Size = new System.Drawing.Size(64, 64);
            this.picFemme.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFemme.TabIndex = 3;
            this.picFemme.TabStop = false;
            // 
            // tmrAnimation
            // 
            this.tmrAnimation.Interval = 33;
            this.tmrAnimation.Tick += new System.EventHandler(this.tmrAnimation_Tick);
            // 
            // picCoupe
            // 
            this.picCoupe.Image = global::Travail_4.Properties.Resources.coupe;
            this.picCoupe.Location = new System.Drawing.Point(1020, 210);
            this.picCoupe.Name = "picCoupe";
            this.picCoupe.Size = new System.Drawing.Size(60, 70);
            this.picCoupe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picCoupe.TabIndex = 4;
            this.picCoupe.TabStop = false;
            // 
            // tmrFeux
            // 
            this.tmrFeux.Interval = 400;
            this.tmrFeux.Tick += new System.EventHandler(this.tmrFeux_Tick);
            // 
            // picFeux
            // 
            this.picFeux.Image = global::Travail_4.Properties.Resources.images_rouge;
            this.picFeux.Location = new System.Drawing.Point(16, 207);
            this.picFeux.Name = "picFeux";
            this.picFeux.Size = new System.Drawing.Size(100, 140);
            this.picFeux.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFeux.TabIndex = 5;
            this.picFeux.TabStop = false;
            // 
            // tmrCoupe
            // 
            this.tmrCoupe.Interval = 10;
            this.tmrCoupe.Tick += new System.EventHandler(this.tmrCoupe_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 461);
            this.Controls.Add(this.picFeux);
            this.Controls.Add(this.picCoupe);
            this.Controls.Add(this.picFemme);
            this.Controls.Add(this.picHomme);
            this.Controls.Add(this.btnRecommencer);
            this.Controls.Add(this.picPiste);
            this.Name = "Form1";
            this.Text = "Qui va ganger";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPiste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHomme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFemme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCoupe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFeux)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecommencer;
        private System.Windows.Forms.PictureBox picPiste;
        private System.Windows.Forms.PictureBox picHomme;
        private System.Windows.Forms.PictureBox picFemme;
        private System.Windows.Forms.Timer tmrAnimation;
        private System.Windows.Forms.PictureBox picCoupe;
        private System.Windows.Forms.Timer tmrFeux;
        private System.Windows.Forms.PictureBox picFeux;
        private System.Windows.Forms.Timer tmrCoupe;
    }
}

