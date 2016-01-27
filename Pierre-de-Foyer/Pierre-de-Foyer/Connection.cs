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
            //Placement des objets
            btnConnection.Location = new Point(this.Width / 2 - btnConnection.Width / 2, this.Height / 2 - btnConnection.Height);
            tbxPass.Location = new Point(btnConnection.Location.X, btnConnection.Location.Y - tbxPass.Height - 20);
            lblPass.Location = new Point(tbxPass.Location.X, tbxPass.Location.Y - lblPass.Height - 2);
            tbxUsername.Location = new Point(lblPass.Location.X, lblPass.Location.Y - tbxUsername.Height - 20);
            lblUsername.Location = new Point(tbxUsername.Location.X, tbxUsername.Location.Y - lblUsername.Height - 2);
            btnInscription.Location = new Point(btnConnection.Location.X, btnConnection.Location.Y + btnConnection.Height + 20);
            btnQuitter.Location = new Point(btnConnection.Location.X, btnInscription.Location.Y + btnInscription.Height + 20);
        }

        /// <summary>
        /// Permet a l'utilisateur de rentrer dans le menu si le test d'identifiant est correcte.
        /// </summary>
        private void btnConnection_Click(object sender, EventArgs e)
        {
            if(VerifieIdentifiant())
            {
                Classes.Utilisateur utilisateurLocal = new Classes.Utilisateur(tbxUsername.Text);
                Form menu = new Menu();
                menu.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Le nom de compte ou le mot de passe sont incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxPass.Clear();
            }
        }

        private void btnInscription_Click(object sender, EventArgs e)
        {
            Form inscription = new Inscription();
            inscription.Show();
            this.Visible = false;
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

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbxPass_TextChanged(object sender, EventArgs e)
        {
            tbxPass.PasswordChar = '*';
        }
    }
}
