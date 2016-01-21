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

        /// <summary>
        /// Permet a l'utilisateur de rentrer dans le menu si le test d'identifiant est correcte.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// Permet à l'utilisateur de quitter le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
