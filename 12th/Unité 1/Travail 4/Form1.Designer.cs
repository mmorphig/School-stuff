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
            this.listNoms = new System.Windows.Forms.ListView();
            this.listM = new System.Windows.Forms.ListView();
            this.columnNomM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listF = new System.Windows.Forms.ListView();
            this.columnNomF = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMessage = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listNoms
            // 
            this.listNoms.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listNoms.HideSelection = false;
            this.listNoms.Location = new System.Drawing.Point(12, 25);
            this.listNoms.Name = "listNoms";
            this.listNoms.Size = new System.Drawing.Size(417, 237);
            this.listNoms.TabIndex = 0;
            this.listNoms.UseCompatibleStateImageBehavior = false;
            this.listNoms.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listNoms_MouseClick);
            // 
            // listM
            // 
            this.listM.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNomM});
            this.listM.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listM.HideSelection = false;
            this.listM.Location = new System.Drawing.Point(528, 25);
            this.listM.Name = "listM";
            this.listM.Size = new System.Drawing.Size(87, 237);
            this.listM.TabIndex = 1;
            this.listM.UseCompatibleStateImageBehavior = false;
            this.listM.View = System.Windows.Forms.View.Details;
            // 
            // columnNomM
            // 
            this.columnNomM.Text = "Nom";
            this.columnNomM.Width = 80;
            // 
            // listF
            // 
            this.listF.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnNomF});
            this.listF.Font = new System.Drawing.Font("Sitka Banner", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listF.HideSelection = false;
            this.listF.Location = new System.Drawing.Point(435, 25);
            this.listF.Name = "listF";
            this.listF.Size = new System.Drawing.Size(87, 237);
            this.listF.TabIndex = 2;
            this.listF.UseCompatibleStateImageBehavior = false;
            this.listF.View = System.Windows.Forms.View.Details;
            // 
            // columnNomF
            // 
            this.columnNomF.Text = "Nom";
            this.columnNomF.Width = 80;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.LightGray;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
            this.lblMessage.Location = new System.Drawing.Point(33, 13);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(84, 16);
            this.lblMessage.TabIndex = 3;
            this.lblMessage.Text = "Existe déjà";
            this.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMessage.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Féminin";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(528, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Masculin";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 274);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.listF);
            this.Controls.Add(this.listM);
            this.Controls.Add(this.listNoms);
            this.Name = "Form1";
            this.Text = "Classification des données";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listNoms;
        private System.Windows.Forms.ListView listM;
        private System.Windows.Forms.ListView listF;
        private System.Windows.Forms.ColumnHeader columnNomM;
        private System.Windows.Forms.ColumnHeader columnNomF;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
    }
}

