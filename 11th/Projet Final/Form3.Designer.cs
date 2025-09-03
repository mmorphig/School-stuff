namespace Projet_Final
{
    partial class Form3
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
            Titre = new Label();
            label2 = new Label();
            txtNom = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Titre
            // 
            Titre.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titre.Location = new Point(12, 9);
            Titre.Name = "Titre";
            Titre.Size = new Size(500, 50);
            Titre.TabIndex = 0;
            Titre.Text = "Tu as perdu!";
            Titre.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 2;
            label2.Text = "Entrez votre nom:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtNom
            // 
            txtNom.Location = new Point(180, 75);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(220, 23);
            txtNom.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(406, 74);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 4;
            button1.Text = "Accepter";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(524, 121);
            Controls.Add(button1);
            Controls.Add(txtNom);
            Controls.Add(label2);
            Controls.Add(Titre);
            Name = "Form3";
            Text = "Tu as perdu!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titre;
        private Label label2;
        private TextBox txtNom;
        private Button button1;
    }
}