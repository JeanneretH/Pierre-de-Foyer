using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pierre_de_Foyer
{
    public partial class Connection : Form
    {
        public Connection()
        {
            InitializeComponent();
        }

        private void Connection_Load(object sender, EventArgs e)
        {
            //Initialisation
            tbxUsername.Text = "Prenom";
            tbxPass.Text = "Nom";

            //Placement des objets
            btnConnection.Location = new Point(this.Width / 2 - btnConnection.Width / 2, this.Height / 2 - btnConnection.Height);
            tbxPass.Location = new Point(btnConnection.Location.X, btnConnection.Location.Y - tbxPass.Height - 6);
            lblPass.Location = new Point(tbxPass.Location.X, tbxPass.Location.Y - lblPass.Height - 2);
            tbxUsername.Location = new Point(lblPass.Location.X, lblPass.Location.Y - tbxUsername.Height - 6);
            lblUsername.Location = new Point(tbxUsername.Location.X, tbxUsername.Location.Y - lblUsername.Height - 2);
            btnInscription.Location = new Point(btnConnection.Location.X, btnConnection.Location.Y + btnConnection.Height + 6);
            btnQuitter.Location = new Point(btnConnection.Location.X, btnInscription.Location.Y + btnInscription.Height + 6);
        }

        /// <summary>
        /// Permet a l'utilisateur de rentrer dans le menu si le test d'identifiant est correcte.
        /// </summary>
        private void btnConnection_Click(object sender, EventArgs e)
        {
            if(VerifieIdentifiant())
            {
                Form menu = new Menu();
                menu.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Le nom de compte ou le mot de passe sont incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Vérifie si les identifiants rentré sont inclu dans les comptes enregistré dans le text.
        /// </summary>
        /// <returns>Retourn true si les identifiants sont correcte</returns>
        private bool VerifieIdentifiant()
        {
            string strCompte = tbxUsername.Text + ";" + tbxPass.Text;

            using (StreamReader sr = File.OpenText("Compte.txt"))
            {
                string strTxt;
                while((strTxt = sr.ReadLine()) != null)
                {
                    if(strTxt == strCompte)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// on regarde si le compte est déjà utilisé ou non, et si non on l'inscrit et on confirme
        /// </summary>
        /// <returns>true si le compte a été créé, et false si un compte à ce nom existe déjà</returns>
        private bool InscriptionCompte()
        {
            return true;
        }

        /// <summary>
        /// Permet à l'utilisateur de quitter le programme
        /// </summary>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
