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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cmbImages = new System.Windows.Forms.ComboBox();
            this.picDemo = new System.Windows.Forms.PictureBox();
            this.imgListe = new System.Windows.Forms.ImageList(this.components);
            this.btnQuitter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbImages
            // 
            this.cmbImages.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbImages.DropDownHeight = 200;
            this.cmbImages.IntegralHeight = false;
            this.cmbImages.Location = new System.Drawing.Point(12, 12);
            this.cmbImages.Name = "cmbImages";
            this.cmbImages.Size = new System.Drawing.Size(121, 21);
            this.cmbImages.TabIndex = 0;
            // 
            // picDemo
            // 
            this.picDemo.Location = new System.Drawing.Point(162, 94);
            this.picDemo.Name = "picDemo";
            this.picDemo.Size = new System.Drawing.Size(450, 335);
            this.picDemo.TabIndex = 1;
            this.picDemo.TabStop = false;
            // 
            // imgListe
            // 
            this.imgListe.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListe.ImageStream")));
            this.imgListe.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListe.Images.SetKeyName(0, "image0");
            this.imgListe.Images.SetKeyName(1, "image1");
            this.imgListe.Images.SetKeyName(2, "image2");
            this.imgListe.Images.SetKeyName(3, "image3");
            this.imgListe.Images.SetKeyName(4, "image4");
            this.imgListe.Images.SetKeyName(5, "image5");
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(537, 12);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 2;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.cmbImages);
            this.Controls.Add(this.picDemo);
            this.Name = "Form1";
            this.Text = "Bouge avec le souris";
            ((System.ComponentModel.ISupportInitialize)(this.picDemo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbImages;
        private System.Windows.Forms.PictureBox picDemo;
        private System.Windows.Forms.ImageList imgListe;
        private System.Windows.Forms.Button btnQuitter;
    }
}

