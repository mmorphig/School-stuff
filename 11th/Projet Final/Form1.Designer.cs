namespace Projet_Final
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tmrTick = new System.Windows.Forms.Timer(components);
            picJoueur = new PictureBox();
            tmrTueAmis = new System.Windows.Forms.Timer(components);
            lblPoints = new Label();
            tmrGrace = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)picJoueur).BeginInit();
            SuspendLayout();
            // 
            // tmrTick
            // 
            tmrTick.Interval = 1;
            tmrTick.Tick += MainTick;
            // 
            // picJoueur
            // 
            picJoueur.Location = new Point(379, 67);
            picJoueur.Name = "picJoueur";
            picJoueur.Size = new Size(50, 50);
            picJoueur.SizeMode = PictureBoxSizeMode.Zoom;
            picJoueur.TabIndex = 1;
            picJoueur.TabStop = false;
            picJoueur.MouseDown += Joueur_MouseDown;
            // 
            // tmrTueAmis
            // 
            tmrTueAmis.Interval = 1000;
            tmrTueAmis.Tick += tmrTueAmis_Tick;
            // 
            // lblPoints
            // 
            lblPoints.AutoSize = true;
            lblPoints.Location = new Point(12, 9);
            lblPoints.Name = "lblPoints";
            lblPoints.Size = new Size(0, 15);
            lblPoints.TabIndex = 2;
            // 
            // tmrGrace
            // 
            tmrGrace.Interval = 1000;
            tmrGrace.Tick += tmrGrace_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPoints);
            Controls.Add(picJoueur);
            Name = "Form1";
            Text = "Vue";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            KeyUp += Form1_KeyUp;
            ((System.ComponentModel.ISupportInitialize)picJoueur).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer tmrTick;
        private PictureBox picJoueur;
        private System.Windows.Forms.Timer tmrTueAmis;
        private Label lblPoints;
        private System.Windows.Forms.Timer tmrGrace;
    }
}
