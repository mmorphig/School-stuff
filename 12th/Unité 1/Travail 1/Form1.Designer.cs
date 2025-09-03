namespace Travail_1
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nom = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Groupe = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Fonction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtFonction = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGroupe = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnViderTextes = new Guna.UI2.WinForms.Guna2Button();
            this.btnEffacerTout = new Guna.UI2.WinForms.Guna2Button();
            this.btnAjouterNouveau = new Guna.UI2.WinForms.Guna2Button();
            this.btnEffacerSelection = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Lavender;
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.listView1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txtNom);
            this.guna2Panel1.Controls.Add(this.txtFonction);
            this.guna2Panel1.Controls.Add(this.txtGroupe);
            this.guna2Panel1.Controls.Add(this.btnViderTextes);
            this.guna2Panel1.Controls.Add(this.btnEffacerTout);
            this.guna2Panel1.Controls.Add(this.btnAjouterNouveau);
            this.guna2Panel1.Controls.Add(this.btnEffacerSelection);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 12);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(776, 318);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(476, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 36);
            this.label3.TabIndex = 10;
            this.label3.Text = "Groupe";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(476, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 36);
            this.label2.TabIndex = 9;
            this.label2.Text = "Fonction";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nom,
            this.Groupe,
            this.Fonction});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 14);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(424, 287);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Nom
            // 
            this.Nom.Text = "Nom";
            this.Nom.Width = 140;
            // 
            // Groupe
            // 
            this.Groupe.Text = "Groupe";
            this.Groupe.Width = 140;
            // 
            // Fonction
            // 
            this.Fonction.Text = "Fonction";
            this.Fonction.Width = 140;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(476, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nom";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNom
            // 
            this.txtNom.BorderRadius = 10;
            this.txtNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNom.DefaultText = "";
            this.txtNom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNom.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtNom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNom.Location = new System.Drawing.Point(561, 14);
            this.txtNom.Name = "txtNom";
            this.txtNom.PlaceholderText = "";
            this.txtNom.SelectedText = "";
            this.txtNom.Size = new System.Drawing.Size(200, 36);
            this.txtNom.TabIndex = 6;
            // 
            // txtFonction
            // 
            this.txtFonction.BorderRadius = 10;
            this.txtFonction.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFonction.DefaultText = "";
            this.txtFonction.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFonction.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFonction.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFonction.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFonction.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFonction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtFonction.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFonction.Location = new System.Drawing.Point(561, 56);
            this.txtFonction.Name = "txtFonction";
            this.txtFonction.PlaceholderText = "";
            this.txtFonction.SelectedText = "";
            this.txtFonction.Size = new System.Drawing.Size(200, 36);
            this.txtFonction.TabIndex = 5;
            // 
            // txtGroupe
            // 
            this.txtGroupe.BorderRadius = 10;
            this.txtGroupe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGroupe.DefaultText = "";
            this.txtGroupe.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGroupe.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGroupe.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGroupe.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGroupe.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGroupe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGroupe.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGroupe.Location = new System.Drawing.Point(561, 98);
            this.txtGroupe.Name = "txtGroupe";
            this.txtGroupe.PlaceholderText = "";
            this.txtGroupe.SelectedText = "";
            this.txtGroupe.Size = new System.Drawing.Size(200, 36);
            this.txtGroupe.TabIndex = 4;
            // 
            // btnViderTextes
            // 
            this.btnViderTextes.BorderRadius = 20;
            this.btnViderTextes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViderTextes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViderTextes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViderTextes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViderTextes.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViderTextes.ForeColor = System.Drawing.Color.White;
            this.btnViderTextes.Location = new System.Drawing.Point(495, 149);
            this.btnViderTextes.Name = "btnViderTextes";
            this.btnViderTextes.Size = new System.Drawing.Size(128, 45);
            this.btnViderTextes.TabIndex = 3;
            this.btnViderTextes.Text = "VIDER LES TEXTES";
            this.btnViderTextes.Click += new System.EventHandler(this.btnViderTextes_Click);
            // 
            // btnEffacerTout
            // 
            this.btnEffacerTout.BorderRadius = 20;
            this.btnEffacerTout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEffacerTout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEffacerTout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEffacerTout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEffacerTout.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEffacerTout.ForeColor = System.Drawing.Color.White;
            this.btnEffacerTout.Location = new System.Drawing.Point(495, 204);
            this.btnEffacerTout.Name = "btnEffacerTout";
            this.btnEffacerTout.Size = new System.Drawing.Size(128, 45);
            this.btnEffacerTout.TabIndex = 2;
            this.btnEffacerTout.Text = "EFFACER TOUT";
            this.btnEffacerTout.Click += new System.EventHandler(this.btnEffacerTout_Click);
            // 
            // btnAjouterNouveau
            // 
            this.btnAjouterNouveau.BorderRadius = 20;
            this.btnAjouterNouveau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouterNouveau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouterNouveau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouterNouveau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjouterNouveau.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAjouterNouveau.ForeColor = System.Drawing.Color.White;
            this.btnAjouterNouveau.Location = new System.Drawing.Point(633, 149);
            this.btnAjouterNouveau.Name = "btnAjouterNouveau";
            this.btnAjouterNouveau.Size = new System.Drawing.Size(128, 45);
            this.btnAjouterNouveau.TabIndex = 1;
            this.btnAjouterNouveau.Text = "AJOUTER UN NOUVEAU";
            this.btnAjouterNouveau.Click += new System.EventHandler(this.btnAjouterNouveau_Click);
            // 
            // btnEffacerSelection
            // 
            this.btnEffacerSelection.BorderRadius = 20;
            this.btnEffacerSelection.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEffacerSelection.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEffacerSelection.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEffacerSelection.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEffacerSelection.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEffacerSelection.ForeColor = System.Drawing.Color.White;
            this.btnEffacerSelection.Location = new System.Drawing.Point(633, 204);
            this.btnEffacerSelection.Name = "btnEffacerSelection";
            this.btnEffacerSelection.Size = new System.Drawing.Size(128, 45);
            this.btnEffacerSelection.TabIndex = 0;
            this.btnEffacerSelection.Text = "EFFACER LA SÉLECTION";
            this.btnEffacerSelection.Click += new System.EventHandler(this.btnEffacerSelection_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Form1";
            this.Text = "Ma Première ListView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtNom;
        private Guna.UI2.WinForms.Guna2TextBox txtFonction;
        private Guna.UI2.WinForms.Guna2TextBox txtGroupe;
        private Guna.UI2.WinForms.Guna2Button btnViderTextes;
        private Guna.UI2.WinForms.Guna2Button btnEffacerTout;
        private Guna.UI2.WinForms.Guna2Button btnAjouterNouveau;
        private Guna.UI2.WinForms.Guna2Button btnEffacerSelection;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nom;
        private System.Windows.Forms.ColumnHeader Groupe;
        private System.Windows.Forms.ColumnHeader Fonction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}

