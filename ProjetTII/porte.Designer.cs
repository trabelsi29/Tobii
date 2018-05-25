namespace ProjetTII
{
    partial class porte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(porte));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accueil = new System.Windows.Forms.Button();
            this.ouvrir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statut_porte = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetTII.Properties.Resources.salvat3;
            this.pictureBox1.Location = new System.Drawing.Point(1802, 822);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // accueil
            // 
            this.accueil.BackColor = System.Drawing.Color.Transparent;
            this.accueil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("accueil.BackgroundImage")));
            this.accueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.accueil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.accueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accueil.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accueil.ForeColor = System.Drawing.Color.Transparent;
            this.accueil.Location = new System.Drawing.Point(789, 744);
            this.accueil.Name = "accueil";
            this.accueil.Size = new System.Drawing.Size(496, 171);
            this.accueil.TabIndex = 21;
            this.accueil.UseVisualStyleBackColor = false;
            this.accueil.Click += new System.EventHandler(this.accueil_Click);
            // 
            // ouvrir
            // 
            this.ouvrir.BackColor = System.Drawing.Color.Transparent;
            this.ouvrir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ouvrir.BackgroundImage")));
            this.ouvrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ouvrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ouvrir.Font = new System.Drawing.Font("LH Lamar Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ouvrir.Location = new System.Drawing.Point(383, 119);
            this.ouvrir.Name = "ouvrir";
            this.ouvrir.Size = new System.Drawing.Size(300, 300);
            this.ouvrir.TabIndex = 22;
            this.ouvrir.UseVisualStyleBackColor = false;
            this.ouvrir.Click += new System.EventHandler(this.ouvrir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("LH Lamar Pro", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1373, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 300);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Dream Orphans", 22F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(485, 480);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 45);
            this.label1.TabIndex = 24;
            this.label1.Text = "Ouvrir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Dream Orphans", 22F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(1448, 480);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 45);
            this.label2.TabIndex = 25;
            this.label2.Text = "Fermer";
            // 
            // statut_porte
            // 
            this.statut_porte.AutoSize = true;
            this.statut_porte.BackColor = System.Drawing.Color.Transparent;
            this.statut_porte.Font = new System.Drawing.Font("Dream Orphans", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statut_porte.Location = new System.Drawing.Point(758, 561);
            this.statut_porte.Name = "statut_porte";
            this.statut_porte.Size = new System.Drawing.Size(0, 96);
            this.statut_porte.TabIndex = 26;
            // 
            // porte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1851, 1055);
            this.Controls.Add(this.statut_porte);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ouvrir);
            this.Controls.Add(this.accueil);
            this.Controls.Add(this.pictureBox1);
            this.Name = "porte";
            this.Text = "porte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button accueil;
        private System.Windows.Forms.Button ouvrir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statut_porte;
    }
}