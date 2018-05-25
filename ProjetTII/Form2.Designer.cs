namespace ProjetTII
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.button1 = new System.Windows.Forms.Button();
            this.m_statusB1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.m_statusB2 = new System.Windows.Forms.Label();
            this.statut_lumiere = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Haettenschweiler", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Image = global::ProjetTII.Properties.Resources._29_bulb;
            this.button1.Location = new System.Drawing.Point(529, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 300);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // m_statusB1
            // 
            this.m_statusB1.AutoSize = true;
            this.m_statusB1.BackColor = System.Drawing.Color.Transparent;
            this.m_statusB1.Font = new System.Drawing.Font("Dream Orphans", 22F, System.Drawing.FontStyle.Bold);
            this.m_statusB1.Location = new System.Drawing.Point(629, 382);
            this.m_statusB1.Name = "m_statusB1";
            this.m_statusB1.Size = new System.Drawing.Size(134, 45);
            this.m_statusB1.TabIndex = 7;
            this.m_statusB1.Text = "Allumer";
            this.m_statusB1.Click += new System.EventHandler(this.m_statusB1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(766, 736);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(496, 171);
            this.button2.TabIndex = 8;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Haettenschweiler", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Image = global::ProjetTII.Properties.Resources.LumEteinte;
            this.button3.Location = new System.Drawing.Point(1218, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 300);
            this.button3.TabIndex = 9;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // m_statusB2
            // 
            this.m_statusB2.AutoSize = true;
            this.m_statusB2.BackColor = System.Drawing.Color.Transparent;
            this.m_statusB2.Font = new System.Drawing.Font("Dream Orphans", 22F, System.Drawing.FontStyle.Bold);
            this.m_statusB2.Location = new System.Drawing.Point(1311, 382);
            this.m_statusB2.Name = "m_statusB2";
            this.m_statusB2.Size = new System.Drawing.Size(150, 45);
            this.m_statusB2.TabIndex = 10;
            this.m_statusB2.Text = "Éteindre";
            this.m_statusB2.Click += new System.EventHandler(this.m_statusB2_Click);
            // 
            // statut_lumiere
            // 
            this.statut_lumiere.AutoSize = true;
            this.statut_lumiere.BackColor = System.Drawing.Color.Transparent;
            this.statut_lumiere.Font = new System.Drawing.Font("Dream Orphans", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statut_lumiere.Location = new System.Drawing.Point(829, 628);
            this.statut_lumiere.Name = "statut_lumiere";
            this.statut_lumiere.Size = new System.Drawing.Size(0, 57);
            this.statut_lumiere.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ProjetTII.Properties.Resources.salvat3;
            this.pictureBox1.Location = new System.Drawing.Point(1802, 822);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 150);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1862, 855);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statut_lumiere);
            this.Controls.Add(this.m_statusB2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.m_statusB1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Form2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label m_statusB1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label m_statusB2;
        private System.Windows.Forms.Label statut_lumiere;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}