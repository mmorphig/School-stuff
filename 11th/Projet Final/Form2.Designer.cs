namespace Projet_Final
{
    partial class Form2
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
            lblTitre = new Label();
            lblAugmentation1 = new Label();
            lblAugmentation2 = new Label();
            lblAugmentation3 = new Label();
            lblPoints = new Label();
            btnAugmentations1 = new Button();
            btnAugmentations2 = new Button();
            btnAugmentations3 = new Button();
            SuspendLayout();
            // 
            // lblTitre
            // 
            lblTitre.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitre.Location = new Point(12, 9);
            lblTitre.Name = "lblTitre";
            lblTitre.Size = new Size(581, 57);
            lblTitre.TabIndex = 0;
            lblTitre.Text = "Augmentations";
            lblTitre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAugmentation1
            // 
            lblAugmentation1.AutoSize = true;
            lblAugmentation1.Font = new Font("Comic Sans MS", 18F);
            lblAugmentation1.Location = new Point(12, 90);
            lblAugmentation1.Name = "lblAugmentation1";
            lblAugmentation1.Size = new Size(237, 33);
            lblAugmentation1.TabIndex = 2;
            lblAugmentation1.Text = "Grandeur de vue: 2p";
            // 
            // lblAugmentation2
            // 
            lblAugmentation2.AutoSize = true;
            lblAugmentation2.Font = new Font("Comic Sans MS", 18F);
            lblAugmentation2.Location = new Point(12, 162);
            lblAugmentation2.Name = "lblAugmentation2";
            lblAugmentation2.Size = new Size(251, 33);
            lblAugmentation2.TabIndex = 3;
            lblAugmentation2.Text = "Vitesse du joueur: 5p";
            // 
            // lblAugmentation3
            // 
            lblAugmentation3.AutoSize = true;
            lblAugmentation3.Font = new Font("Comic Sans MS", 18F);
            lblAugmentation3.Location = new Point(12, 241);
            lblAugmentation3.Name = "lblAugmentation3";
            lblAugmentation3.Size = new Size(262, 33);
            lblAugmentation3.TabIndex = 4;
            lblAugmentation3.Text = "Valeur des pièces: 10p";
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Font = new Font("Comic Sans MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPoints.Location = new Point(12, 9);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(84, 29);
            lblPoints.TabIndex = 5;
            lblPoints.Text = "points: ";
            // 
            // btnAugmentations1
            // 
            btnAugmentations1.Font = new Font("Comic Sans MS", 12F);
            btnAugmentations1.Location = new Point(493, 90);
            btnAugmentations1.Name = "btnAugmentations1";
            btnAugmentations1.Size = new Size(100, 40);
            btnAugmentations1.TabIndex = 6;
            btnAugmentations1.Text = "Achète";
            btnAugmentations1.UseVisualStyleBackColor = true;
            btnAugmentations1.Click += btnAugmentations1_Click;
            // 
            // btnAugmentations2
            // 
            btnAugmentations2.Font = new Font("Comic Sans MS", 12F);
            btnAugmentations2.Location = new Point(493, 162);
            btnAugmentations2.Name = "btnAugmentations2";
            btnAugmentations2.Size = new Size(100, 40);
            btnAugmentations2.TabIndex = 7;
            btnAugmentations2.Text = "Achète";
            btnAugmentations2.UseVisualStyleBackColor = true;
            btnAugmentations2.Click += btnAugmentations2_Click;
            // 
            // btnAugmentations3
            // 
            btnAugmentations3.Font = new Font("Comic Sans MS", 12F);
            btnAugmentations3.Location = new Point(493, 241);
            btnAugmentations3.Name = "btnAugmentations3";
            btnAugmentations3.Size = new Size(100, 40);
            btnAugmentations3.TabIndex = 8;
            btnAugmentations3.Text = "Achète";
            btnAugmentations3.UseVisualStyleBackColor = true;
            btnAugmentations3.Click += btnAugmentations3_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(605, 450);
            Controls.Add(btnAugmentations3);
            Controls.Add(btnAugmentations2);
            Controls.Add(btnAugmentations1);
            Controls.Add(lblPoints);
            Controls.Add(lblAugmentation3);
            Controls.Add(lblAugmentation2);
            Controls.Add(lblAugmentation1);
            Controls.Add(lblTitre);
            Name = "Form2";
            Text = "Augmentations";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitre;
        private Label lblAugmentation1;
        private Label lblAugmentation2;
        private Label lblAugmentation3;
        private Label lblPoints;
        private Button btnAugmentations1;
        private Button btnAugmentations2;
        private Button btnAugmentations3;
    }
}