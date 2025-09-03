namespace Travail_3
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
            this.btnArrete = new System.Windows.Forms.Button();
            this.picFeux = new System.Windows.Forms.PictureBox();
            this.tmrChange = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picFeux)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArrete
            // 
            this.btnArrete.Location = new System.Drawing.Point(12, 226);
            this.btnArrete.Name = "btnArrete";
            this.btnArrete.Size = new System.Drawing.Size(160, 23);
            this.btnArrete.TabIndex = 0;
            this.btnArrete.Text = "Arrête";
            this.btnArrete.UseVisualStyleBackColor = true;
            this.btnArrete.Click += new System.EventHandler(this.btnArrete_Click);
            // 
            // picFeux
            // 
            this.picFeux.Image = global::Travail_3.Properties.Resources.images_vert;
            this.picFeux.Location = new System.Drawing.Point(12, 12);
            this.picFeux.Name = "picFeux";
            this.picFeux.Size = new System.Drawing.Size(160, 208);
            this.picFeux.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picFeux.TabIndex = 1;
            this.picFeux.TabStop = false;
            // 
            // tmrChange
            // 
            this.tmrChange.Interval = 1000;
            this.tmrChange.Tick += new System.EventHandler(this.tmrChange_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 261);
            this.Controls.Add(this.picFeux);
            this.Controls.Add(this.btnArrete);
            this.Name = "Form1";
            this.Text = "Feux de circulation";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picFeux)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArrete;
        private System.Windows.Forms.PictureBox picFeux;
        private System.Windows.Forms.Timer tmrChange;
    }
}

