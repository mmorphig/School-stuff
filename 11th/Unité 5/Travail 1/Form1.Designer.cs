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
            this.components = new System.ComponentModel.Container();
            this.picFond = new System.Windows.Forms.PictureBox();
            this.lblRecu = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.nudQuantite = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblChariot = new System.Windows.Forms.Label();
            this.tmrBouge = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFond)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).BeginInit();
            this.SuspendLayout();
            // 
            // picFond
            // 
            this.picFond.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFond.Image = global::Travail_1.Properties.Resources.épicerie;
            this.picFond.Location = new System.Drawing.Point(0, 0);
            this.picFond.Name = "picFond";
            this.picFond.Size = new System.Drawing.Size(899, 516);
            this.picFond.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picFond.TabIndex = 0;
            this.picFond.TabStop = false;
            // 
            // lblRecu
            // 
            this.lblRecu.AutoSize = true;
            this.lblRecu.Location = new System.Drawing.Point(560, 370);
            this.lblRecu.Name = "lblRecu";
            this.lblRecu.Size = new System.Drawing.Size(0, 13);
            this.lblRecu.TabIndex = 1;
            // 
            // btnAjouter
            // 
            this.btnAjouter.BackColor = System.Drawing.Color.LightCoral;
            this.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAjouter.Location = new System.Drawing.Point(405, 260);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(100, 35);
            this.btnAjouter.TabIndex = 2;
            this.btnAjouter.Text = "Ajouter des courses";
            this.btnAjouter.UseVisualStyleBackColor = false;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // nudQuantite
            // 
            this.nudQuantite.Location = new System.Drawing.Point(425, 50);
            this.nudQuantite.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nudQuantite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantite.Name = "nudQuantite";
            this.nudQuantite.Size = new System.Drawing.Size(50, 20);
            this.nudQuantite.TabIndex = 3;
            this.nudQuantite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudQuantite.ValueChanged += new System.EventHandler(this.nudQuantite_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(344, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // lblChariot
            // 
            this.lblChariot.Location = new System.Drawing.Point(190, 440);
            this.lblChariot.Name = "lblChariot";
            this.lblChariot.Size = new System.Drawing.Size(100, 25);
            this.lblChariot.TabIndex = 5;
            this.lblChariot.Visible = false;
            // 
            // tmrBouge
            // 
            this.tmrBouge.Interval = 10;
            this.tmrBouge.Tick += new System.EventHandler(this.tmrBouge_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 516);
            this.Controls.Add(this.lblChariot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudQuantite);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.lblRecu);
            this.Controls.Add(this.picFond);
            this.Name = "Form1";
            this.Text = "Faire de l\'épicerie, c\'est cool!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFond)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picFond;
        private System.Windows.Forms.Label lblRecu;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.NumericUpDown nudQuantite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblChariot;
        private System.Windows.Forms.Timer tmrBouge;
    }
}

