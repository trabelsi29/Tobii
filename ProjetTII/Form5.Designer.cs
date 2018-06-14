namespace ProjetTII
{
    partial class Chauffage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chauffage));
            this.logo = new System.Windows.Forms.PictureBox();
            this.boutonAccueil = new System.Windows.Forms.Button();
            this.moins = new System.Windows.Forms.Button();
            this.plus = new System.Windows.Forms.Button();
            this.tmp = new System.Windows.Forms.Label();
            this.maxmin = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.Image = global::ProjetTII.Properties.Resources.salvat3;
            this.logo.Location = new System.Drawing.Point(1802, 822);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(150, 150);
            this.logo.TabIndex = 26;
            this.logo.TabStop = false;
            // 
            // boutonAccueil
            // 
            this.boutonAccueil.BackColor = System.Drawing.Color.Transparent;
            this.boutonAccueil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("boutonAccueil.BackgroundImage")));
            this.boutonAccueil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boutonAccueil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.boutonAccueil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.boutonAccueil.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boutonAccueil.ForeColor = System.Drawing.Color.Transparent;
            this.boutonAccueil.Location = new System.Drawing.Point(766, 736);
            this.boutonAccueil.Name = "boutonAccueil";
            this.boutonAccueil.Size = new System.Drawing.Size(496, 171);
            this.boutonAccueil.TabIndex = 27;
            this.boutonAccueil.UseVisualStyleBackColor = false;
            this.boutonAccueil.Click += new System.EventHandler(this.boutonAccueil_Click);
            // 
            // moins
            // 
            this.moins.Image = ((System.Drawing.Image)(resources.GetObject("moins.Image")));
            this.moins.Location = new System.Drawing.Point(616, 219);
            this.moins.Name = "moins";
            this.moins.Size = new System.Drawing.Size(242, 238);
            this.moins.TabIndex = 28;
            this.moins.UseVisualStyleBackColor = true;
            this.moins.Click += new System.EventHandler(this.moins_Click);
            // 
            // plus
            // 
            this.plus.Image = ((System.Drawing.Image)(resources.GetObject("plus.Image")));
            this.plus.Location = new System.Drawing.Point(1162, 219);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(242, 238);
            this.plus.TabIndex = 29;
            this.plus.UseVisualStyleBackColor = true;
            this.plus.Click += new System.EventHandler(this.plus_Click);
            // 
            // tmp
            // 
            this.tmp.AutoSize = true;
            this.tmp.BackColor = System.Drawing.Color.Transparent;
            this.tmp.Font = new System.Drawing.Font("Bebas", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tmp.ForeColor = System.Drawing.Color.Black;
            this.tmp.Location = new System.Drawing.Point(929, 587);
            this.tmp.Name = "tmp";
            this.tmp.Size = new System.Drawing.Size(386, 80);
            this.tmp.TabIndex = 30;
            this.tmp.Text = "Temperature";
            this.tmp.Click += new System.EventHandler(this.label1_Click);
            // 
            // maxmin
            // 
            this.maxmin.AutoSize = true;
            this.maxmin.BackColor = System.Drawing.Color.Transparent;
            this.maxmin.Font = new System.Drawing.Font("Georgia Pro Cond", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxmin.ForeColor = System.Drawing.Color.Red;
            this.maxmin.Location = new System.Drawing.Point(832, 503);
            this.maxmin.Name = "maxmin";
            this.maxmin.Size = new System.Drawing.Size(148, 43);
            this.maxmin.TabIndex = 31;
            this.maxmin.Text = "message";
            this.maxmin.Click += new System.EventHandler(this.maxmin_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1101, 587);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(66, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bebas", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(582, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(852, 106);
            this.label1.TabIndex = 33;
            this.label1.Text = "Controle  du  chauffage";
            // 
            // Chauffage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1646, 876);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.maxmin);
            this.Controls.Add(this.tmp);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.moins);
            this.Controls.Add(this.boutonAccueil);
            this.Controls.Add(this.logo);
            this.Name = "Chauffage";
            this.Text = "chauffage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Chauffage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button boutonAccueil;
        private System.Windows.Forms.Button moins;
        private System.Windows.Forms.Button plus;
        private System.Windows.Forms.Label tmp;
        private System.Windows.Forms.Label maxmin;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}