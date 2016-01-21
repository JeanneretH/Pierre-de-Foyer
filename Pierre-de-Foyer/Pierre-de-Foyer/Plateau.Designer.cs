namespace Pierre_de_Foyer
{
    partial class Plateau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plateau));
            this.pbxHero = new System.Windows.Forms.PictureBox();
            this.pbxHeroAdverse = new System.Windows.Forms.PictureBox();
            this.pbxPouvoirHero = new System.Windows.Forms.PictureBox();
            this.pbxPouvoirHeroAdverse = new System.Windows.Forms.PictureBox();
            this.btnPasser = new System.Windows.Forms.Button();
            this.btnRetour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeroAdverse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPouvoirHero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPouvoirHeroAdverse)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxHero
            // 
            this.pbxHero.Location = new System.Drawing.Point(12, 12);
            this.pbxHero.Name = "pbxHero";
            this.pbxHero.Size = new System.Drawing.Size(150, 150);
            this.pbxHero.TabIndex = 0;
            this.pbxHero.TabStop = false;
            // 
            // pbxHeroAdverse
            // 
            this.pbxHeroAdverse.Location = new System.Drawing.Point(12, 168);
            this.pbxHeroAdverse.Name = "pbxHeroAdverse";
            this.pbxHeroAdverse.Size = new System.Drawing.Size(150, 150);
            this.pbxHeroAdverse.TabIndex = 1;
            this.pbxHeroAdverse.TabStop = false;
            // 
            // pbxPouvoirHero
            // 
            this.pbxPouvoirHero.Location = new System.Drawing.Point(168, 12);
            this.pbxPouvoirHero.Name = "pbxPouvoirHero";
            this.pbxPouvoirHero.Size = new System.Drawing.Size(50, 50);
            this.pbxPouvoirHero.TabIndex = 2;
            this.pbxPouvoirHero.TabStop = false;
            this.pbxPouvoirHero.Click += new System.EventHandler(this.pbxPouvoirHero_Click);
            // 
            // pbxPouvoirHeroAdverse
            // 
            this.pbxPouvoirHeroAdverse.Location = new System.Drawing.Point(168, 68);
            this.pbxPouvoirHeroAdverse.Name = "pbxPouvoirHeroAdverse";
            this.pbxPouvoirHeroAdverse.Size = new System.Drawing.Size(50, 50);
            this.pbxPouvoirHeroAdverse.TabIndex = 3;
            this.pbxPouvoirHeroAdverse.TabStop = false;
            this.pbxPouvoirHeroAdverse.Click += new System.EventHandler(this.pbxPouvoirHeroAdverse_Click);
            // 
            // btnPasser
            // 
            this.btnPasser.Location = new System.Drawing.Point(168, 124);
            this.btnPasser.Name = "btnPasser";
            this.btnPasser.Size = new System.Drawing.Size(118, 38);
            this.btnPasser.TabIndex = 4;
            this.btnPasser.Text = "Passer";
            this.btnPasser.UseVisualStyleBackColor = true;
            this.btnPasser.Click += new System.EventHandler(this.btnPasser_Click);
            // 
            // btnRetour
            // 
            this.btnRetour.Location = new System.Drawing.Point(168, 168);
            this.btnRetour.Name = "btnRetour";
            this.btnRetour.Size = new System.Drawing.Size(75, 23);
            this.btnRetour.TabIndex = 5;
            this.btnRetour.Text = "Retour";
            this.btnRetour.UseVisualStyleBackColor = true;
            this.btnRetour.Click += new System.EventHandler(this.btnRetour_Click);
            // 
            // Plateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 718);
            this.Controls.Add(this.btnRetour);
            this.Controls.Add(this.btnPasser);
            this.Controls.Add(this.pbxPouvoirHeroAdverse);
            this.Controls.Add(this.pbxPouvoirHero);
            this.Controls.Add(this.pbxHeroAdverse);
            this.Controls.Add(this.pbxHero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Plateau";
            this.Text = "Plateau";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Plateau_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Plateau_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbxHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHeroAdverse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPouvoirHero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPouvoirHeroAdverse)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxHero;
        private System.Windows.Forms.PictureBox pbxHeroAdverse;
        private System.Windows.Forms.PictureBox pbxPouvoirHero;
        private System.Windows.Forms.PictureBox pbxPouvoirHeroAdverse;
        private System.Windows.Forms.Button btnPasser;
        private System.Windows.Forms.Button btnRetour;
    }
}