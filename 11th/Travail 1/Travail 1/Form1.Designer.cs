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
            this.lblAffiche = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.picPersonne = new System.Windows.Forms.PictureBox();
            this.btnAfficher = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSport = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPersonne)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAffiche
            // 
            this.lblAffiche.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblAffiche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAffiche.Location = new System.Drawing.Point(12, 302);
            this.lblAffiche.Name = "lblAffiche";
            this.lblAffiche.Size = new System.Drawing.Size(400, 50);
            this.lblAffiche.TabIndex = 0;
            this.lblAffiche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNom
            // 
            this.txtNom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtNom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNom.Location = new System.Drawing.Point(268, 42);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(150, 20);
            this.txtNom.TabIndex = 1;
            // 
            // picPersonne
            // 
            this.picPersonne.Image = global::Travail_1.Properties.Resources.steve;
            this.picPersonne.Location = new System.Drawing.Point(12, 12);
            this.picPersonne.Name = "picPersonne";
            this.picPersonne.Size = new System.Drawing.Size(250, 250);
            this.picPersonne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picPersonne.TabIndex = 2;
            this.picPersonne.TabStop = false;
            // 
            // btnAfficher
            // 
            this.btnAfficher.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAfficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAfficher.Location = new System.Drawing.Point(418, 302);
            this.btnAfficher.Name = "btnAfficher";
            this.btnAfficher.Size = new System.Drawing.Size(154, 52);
            this.btnAfficher.TabIndex = 3;
            this.btnAfficher.Text = "Afficher les informations";
            this.btnAfficher.UseVisualStyleBackColor = false;
            this.btnAfficher.Click += new System.EventHandler(this.btnAfficher_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.GrayText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ton nom";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.GrayText;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tes informations";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.GrayText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(424, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 30);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ton âge";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAge.Location = new System.Drawing.Point(424, 42);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(150, 20);
            this.txtAge.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.GrayText;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(268, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 30);
            this.label4.TabIndex = 15;
            this.label4.Text = "Ton prénom";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrenom
            // 
            this.txtPrenom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtPrenom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrenom.Location = new System.Drawing.Point(268, 107);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(150, 20);
            this.txtPrenom.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GrayText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ton sport";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSport
            // 
            this.txtSport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.txtSport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSport.Location = new System.Drawing.Point(424, 108);
            this.txtSport.Name = "txtSport";
            this.txtSport.Size = new System.Drawing.Size(150, 20);
            this.txtSport.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSport);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAfficher);
            this.Controls.Add(this.picPersonne);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblAffiche);
            this.Name = "Form1";
            this.Text = "Informations personelles";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPersonne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAffiche;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.PictureBox picPersonne;
        private System.Windows.Forms.Button btnAfficher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSport;
    }
}

