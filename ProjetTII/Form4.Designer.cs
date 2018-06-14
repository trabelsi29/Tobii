namespace ProjetTII
{
    partial class TV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TV));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.accueil = new System.Windows.Forms.Button();
            this.PlusV = new System.Windows.Forms.Button();
            this.MoinsV = new System.Windows.Forms.Button();
            this.PlusCh = new System.Windows.Forms.Button();
            this.MoinsCH = new System.Windows.Forms.Button();
            this.OK = new System.Windows.Forms.Button();
            this.arret = new System.Windows.Forms.Button();
            this.muet = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.statut = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Label();
            this.chaine = new System.Windows.Forms.Label();
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
            this.pictureBox1.TabIndex = 26;
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
            this.accueil.Location = new System.Drawing.Point(860, 729);
            this.accueil.Name = "accueil";
            this.accueil.Size = new System.Drawing.Size(496, 171);
            this.accueil.TabIndex = 28;
            this.accueil.UseVisualStyleBackColor = false;
            this.accueil.Click += new System.EventHandler(this.accueil_Click);
            // 
            // PlusV
            // 
            this.PlusV.BackColor = System.Drawing.Color.Transparent;
            this.PlusV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlusV.BackgroundImage")));
            this.PlusV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlusV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlusV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusV.ForeColor = System.Drawing.Color.Transparent;
            this.PlusV.Location = new System.Drawing.Point(341, 580);
            this.PlusV.Name = "PlusV";
            this.PlusV.Size = new System.Drawing.Size(206, 83);
            this.PlusV.TabIndex = 29;
            this.PlusV.UseVisualStyleBackColor = false;
            this.PlusV.Click += new System.EventHandler(this.PlusV_Click);
            // 
            // MoinsV
            // 
            this.MoinsV.BackColor = System.Drawing.Color.Transparent;
            this.MoinsV.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MoinsV.BackgroundImage")));
            this.MoinsV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoinsV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoinsV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoinsV.ForeColor = System.Drawing.Color.Transparent;
            this.MoinsV.Location = new System.Drawing.Point(341, 825);
            this.MoinsV.Name = "MoinsV";
            this.MoinsV.Size = new System.Drawing.Size(206, 83);
            this.MoinsV.TabIndex = 30;
            this.MoinsV.UseVisualStyleBackColor = false;
            this.MoinsV.Click += new System.EventHandler(this.MoinsV_Click);
            // 
            // PlusCh
            // 
            this.PlusCh.BackColor = System.Drawing.Color.Transparent;
            this.PlusCh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PlusCh.BackgroundImage")));
            this.PlusCh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PlusCh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PlusCh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PlusCh.ForeColor = System.Drawing.Color.Transparent;
            this.PlusCh.Location = new System.Drawing.Point(528, 641);
            this.PlusCh.Name = "PlusCh";
            this.PlusCh.Size = new System.Drawing.Size(83, 206);
            this.PlusCh.TabIndex = 31;
            this.PlusCh.UseVisualStyleBackColor = false;
            this.PlusCh.Click += new System.EventHandler(this.PlusCh_Click);
            // 
            // MoinsCH
            // 
            this.MoinsCH.BackColor = System.Drawing.Color.Transparent;
            this.MoinsCH.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MoinsCH.BackgroundImage")));
            this.MoinsCH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MoinsCH.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MoinsCH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MoinsCH.ForeColor = System.Drawing.Color.Transparent;
            this.MoinsCH.Location = new System.Drawing.Point(274, 641);
            this.MoinsCH.Name = "MoinsCH";
            this.MoinsCH.Size = new System.Drawing.Size(83, 206);
            this.MoinsCH.TabIndex = 32;
            this.MoinsCH.UseVisualStyleBackColor = false;
            this.MoinsCH.Click += new System.EventHandler(this.MoinsCH_Click);
            // 
            // OK
            // 
            this.OK.BackColor = System.Drawing.Color.Transparent;
            this.OK.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("OK.BackgroundImage")));
            this.OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OK.ForeColor = System.Drawing.Color.Transparent;
            this.OK.Location = new System.Drawing.Point(379, 679);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(130, 130);
            this.OK.TabIndex = 33;
            this.OK.UseVisualStyleBackColor = false;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // arret
            // 
            this.arret.BackColor = System.Drawing.Color.Transparent;
            this.arret.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("arret.BackgroundImage")));
            this.arret.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arret.Cursor = System.Windows.Forms.Cursors.Hand;
            this.arret.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arret.ForeColor = System.Drawing.Color.Transparent;
            this.arret.Location = new System.Drawing.Point(288, 209);
            this.arret.Name = "arret";
            this.arret.Size = new System.Drawing.Size(130, 130);
            this.arret.TabIndex = 34;
            this.arret.UseVisualStyleBackColor = false;
            this.arret.Click += new System.EventHandler(this.arret_Click);
            // 
            // muet
            // 
            this.muet.BackColor = System.Drawing.Color.Transparent;
            this.muet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("muet.BackgroundImage")));
            this.muet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.muet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.muet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.muet.ForeColor = System.Drawing.Color.Transparent;
            this.muet.Location = new System.Drawing.Point(462, 209);
            this.muet.Name = "muet";
            this.muet.Size = new System.Drawing.Size(130, 130);
            this.muet.TabIndex = 35;
            this.muet.UseVisualStyleBackColor = false;
            this.muet.Click += new System.EventHandler(this.muet_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.Black;
            this.listBox1.Font = new System.Drawing.Font("Prosto", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.ItemHeight = 33;
            this.listBox1.Location = new System.Drawing.Point(804, 252);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(637, 386);
            this.listBox1.TabIndex = 36;
            this.listBox1.Visible = false;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // statut
            // 
            this.statut.AutoSize = true;
            this.statut.BackColor = System.Drawing.Color.Transparent;
            this.statut.Font = new System.Drawing.Font("Prosto", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statut.Location = new System.Drawing.Point(852, 137);
            this.statut.Name = "statut";
            this.statut.Size = new System.Drawing.Size(133, 47);
            this.statut.TabIndex = 37;
            this.statut.Text = "label1";
            // 
            // volume
            // 
            this.volume.AutoSize = true;
            this.volume.BackColor = System.Drawing.Color.Transparent;
            this.volume.Font = new System.Drawing.Font("Prosto", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume.Location = new System.Drawing.Point(852, 53);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(133, 47);
            this.volume.TabIndex = 38;
            this.volume.Text = "label1";
            this.volume.Click += new System.EventHandler(this.volume_Click);
            // 
            // chaine
            // 
            this.chaine.AutoSize = true;
            this.chaine.BackColor = System.Drawing.Color.Transparent;
            this.chaine.Font = new System.Drawing.Font("Prosto", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chaine.Location = new System.Drawing.Point(966, 652);
            this.chaine.Name = "chaine";
            this.chaine.Size = new System.Drawing.Size(0, 47);
            this.chaine.TabIndex = 39;
            // 
            // TV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1924, 949);
            this.Controls.Add(this.chaine);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.statut);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.muet);
            this.Controls.Add(this.arret);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.PlusV);
            this.Controls.Add(this.MoinsCH);
            this.Controls.Add(this.PlusCh);
            this.Controls.Add(this.MoinsV);
            this.Controls.Add(this.accueil);
            this.Controls.Add(this.pictureBox1);
            this.Name = "TV";
            this.Text = "Form4";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button accueil;
        private System.Windows.Forms.Button PlusV;
        private System.Windows.Forms.Button MoinsV;
        private System.Windows.Forms.Button PlusCh;
        private System.Windows.Forms.Button MoinsCH;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button arret;
        private System.Windows.Forms.Button muet;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label statut;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.Label chaine;
    }
}