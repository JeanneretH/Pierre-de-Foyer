namespace Pierre_de_Foyer
{
    partial class Inscription
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inscription));
            this.btnInscription = new System.Windows.Forms.Button();
            this.btnRetourMenu = new System.Windows.Forms.Button();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbxNom = new System.Windows.Forms.TextBox();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.tbxMotDePasse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnInscription
            // 
            this.btnInscription.Font = new System.Drawing.Font("Candara", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnInscription.Location = new System.Drawing.Point(201, 214);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(256, 53);
            this.btnInscription.TabIndex = 1;
            this.btnInscription.Text = "Inscrivez-vous !";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.NewCompte_Click);
            // 
            // btnRetourMenu
            // 
            this.btnRetourMenu.Font = new System.Drawing.Font("Candara", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnRetourMenu.Location = new System.Drawing.Point(201, 273);
            this.btnRetourMenu.Name = "btnRetourMenu";
            this.btnRetourMenu.Size = new System.Drawing.Size(256, 53);
            this.btnRetourMenu.TabIndex = 1;
            this.btnRetourMenu.Text = "Retour au menu";
            this.btnRetourMenu.UseVisualStyleBackColor = true;
            this.btnRetourMenu.Click += new System.EventHandler(this.RetourMenu_Click);
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Candara", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblNom.ForeColor = System.Drawing.Color.White;
            this.lblNom.Location = new System.Drawing.Point(202, 101);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(120, 29);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Votre nom";
            // 
            // tbxNom
            // 
            this.tbxNom.Location = new System.Drawing.Point(201, 133);
            this.tbxNom.Name = "tbxNom";
            this.tbxNom.Size = new System.Drawing.Size(256, 20);
            this.tbxNom.TabIndex = 5;
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Font = new System.Drawing.Font("Candara", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblMotDePasse.ForeColor = System.Drawing.Color.White;
            this.lblMotDePasse.Location = new System.Drawing.Point(202, 156);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(208, 29);
            this.lblMotDePasse.TabIndex = 2;
            this.lblMotDePasse.Text = "Votre mot de passe";
            // 
            // tbxMotDePasse
            // 
            this.tbxMotDePasse.Location = new System.Drawing.Point(201, 188);
            this.tbxMotDePasse.Name = "tbxMotDePasse";
            this.tbxMotDePasse.Size = new System.Drawing.Size(256, 20);
            this.tbxMotDePasse.TabIndex = 5;
            this.tbxMotDePasse.TextChanged += new System.EventHandler(this.tbxMotDePasse_TextChanged);
            // 
            // Inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(661, 544);
            this.Controls.Add(this.tbxMotDePasse);
            this.Controls.Add(this.tbxNom);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.btnRetourMenu);
            this.Controls.Add(this.btnInscription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inscription";
            this.Text = "Pierre-de-Foyer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Inscription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Button btnRetourMenu;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbxNom;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox tbxMotDePasse;
    }
}