namespace ProjetTII
{
    partial class Volets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Volets));
            this.ouvrir = new System.Windows.Forms.Button();
            this.fermer = new System.Windows.Forms.Button();
            this.statut = new System.Windows.Forms.Label();
            this.accueil = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ouvrir
            // 
            this.ouvrir.BackColor = System.Drawing.Color.Transparent;
            this.ouvrir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ouvrir.BackgroundImage")));
            this.ouvrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ouvrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ouvrir.Font = new System.Drawing.Font("LH Lamar Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouvrir.Location = new System.Drawing.Point(449, 113);
            this.ouvrir.Name = "ouvrir";
            this.ouvrir.Size = new System.Drawing.Size(300, 300);
            this.ouvrir.TabIndex = 0;
            this.ouvrir.UseVisualStyleBackColor = false;
            this.ouvrir.Click += new System.EventHandler(this.ouvrir_Click);
            // 
            // fermer
            // 
            this.fermer.BackColor = System.Drawing.Color.Transparent;
            this.fermer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fermer.BackgroundImage")));
            this.fermer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.fermer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fermer.Font = new System.Drawing.Font("LH Lamar Pro", 24F);
            this.fermer.Location = new System.Drawing.Point(1251, 113);
            this.fermer.Name = "fermer";
            this.fermer.Size = new System.Drawing.Size(300, 300);
            this.fermer.TabIndex = 1;
            this.fermer.UseVisualStyleBackColor = false;
            this.fermer.Click += new System.EventHandler(this.fermer_Click);
            // 
            // statut
            // 
            this.statut.AutoSize = true;
            this.statut.BackColor = System.Drawing.Color.Transparent;
            this.statut.Font = new System.Drawing.Font("Dream Orphans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statut.Location = new System.Drawing.Point(771, 574);
            this.statut.Name = "statut";
            this.statut.Size = new System.Drawing.Size(0, 96);
            this.statut.TabIndex = 2;
            this.statut.Click += new System.EventHandler(this.statut_Click);
            // 
            // accueil
            // 
            this.accueil.BackColor = System.Drawing.Color.Transparent;
            this.accueil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accueil.BackgroundImage")));
            this.accueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.accueil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accueil.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 48F, System.Drawing.FontStyle.Bold);
            this.accueil.ForeColor = System.Drawing.Color.Transparent;
            this.accueil.Location = new System.Drawing.Point(766, 736);
            this.accueil.Name = "accueil";
            this.accueil.Size = new System.Drawing.Size(496, 171);
            this.accueil.TabIndex = 0;
            this.accueil.UseVisualStyleBackColor = false;
            this.accueil.Click += new System.EventHandler(this.accueil_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dream Orphans", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(536, 471);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ouvrir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Dream Orphans", 22F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1361, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 45);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fermer";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetTII.Properties.Resources.salvat3;
            this.pictureBox1.Location = new System.Drawing.Point(1762, 797);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Volets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1924, 1049);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.accueil);
            this.Controls.Add(this.statut);
            this.Controls.Add(this.fermer);
            this.Controls.Add(this.ouvrir);
            this.DoubleBuffered = true;
            this.Name = "Volets";
            this.Text = "Volets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ouvrir;
        private System.Windows.Forms.Button fermer;
        private System.Windows.Forms.Label statut;
        private System.Windows.Forms.Button accueil;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}