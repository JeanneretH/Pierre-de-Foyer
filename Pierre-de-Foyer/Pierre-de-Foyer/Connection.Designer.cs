namespace Pierre_de_Foyer
{
    partial class Connection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connection));
            this.btnInscription = new System.Windows.Forms.Button();
            this.lblPass = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.tbxUsername = new System.Windows.Forms.TextBox();
            this.btnConnection = new System.Windows.Forms.Button();
            this.tbxPass = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnInscription
            // 
            this.btnInscription.Font = new System.Drawing.Font("Candara", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnInscription.Location = new System.Drawing.Point(228, 267);
            this.btnInscription.Name = "btnInscription";
            this.btnInscription.Size = new System.Drawing.Size(256, 53);
            this.btnInscription.TabIndex = 3;
            this.btnInscription.Text = "Inscription ";
            this.btnInscription.UseVisualStyleBackColor = true;
            this.btnInscription.Click += new System.EventHandler(this.btnInscription_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Candara", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblPass.ForeColor = System.Drawing.Color.White;
            this.lblPass.Location = new System.Drawing.Point(223, 150);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(146, 29);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Mot de passe";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Candara", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.btnQuitter.Location = new System.Drawing.Point(228, 326);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(256, 53);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // tbxUsername
            // 
            this.tbxUsername.Location = new System.Drawing.Point(228, 127);
            this.tbxUsername.Name = "tbxUsername";
            this.tbxUsername.Size = new System.Drawing.Size(256, 20);
            this.tbxUsername.TabIndex = 0;
            // 
            // btnConnection
            // 
            this.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConnection.Font = new System.Drawing.Font("Candara", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btnConnection.Location = new System.Drawing.Point(228, 208);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Size = new System.Drawing.Size(256, 53);
            this.btnConnection.TabIndex = 2;
            this.btnConnection.Text = "Connexion";
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // tbxPass
            // 
            this.tbxPass.Location = new System.Drawing.Point(228, 182);
            this.tbxPass.Name = "tbxPass";
            this.tbxPass.Size = new System.Drawing.Size(256, 20);
            this.tbxPass.TabIndex = 1;
            this.tbxPass.TextChanged += new System.EventHandler(this.tbxPass_TextChanged);
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Candara", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(223, 95);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(174, 29);
            this.lblUsername.TabIndex = 6;
            this.lblUsername.Text = "Nom de compte";
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(671, 507);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.tbxPass);
            this.Controls.Add(this.tbxUsername);
            this.Controls.Add(this.btnConnection);
            this.Controls.Add(this.btnInscription);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.btnQuitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connection";
            this.Text = "Pierre-de-Foyer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Connection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInscription;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.TextBox tbxUsername;
        private System.Windows.Forms.Button btnConnection;
        private System.Windows.Forms.TextBox tbxPass;
        private System.Windows.Forms.Label lblUsername;
    }
}

