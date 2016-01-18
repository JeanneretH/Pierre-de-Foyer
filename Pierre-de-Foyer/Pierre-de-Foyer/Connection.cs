using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        /// <summary>
        /// Permet a l'utilisateur de rentrer dans le menu si le test d'identifiant est correcte.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnection_Click(object sender, EventArgs e)
        {
            if(VerifieIdentifiant() == true)
            {
                Form connection = new Connection();
                Form menu = new Menu();
                menu.Show();
                connection.Visible = false;
                
            }
            else
            {
                MessageBox.Show("Le nom de compte ou le mot de passe sont incorrect", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Vérifie si les identifiants rentré sont inclu dans les compte.
        /// </summary>
        /// <returns>Retourn true si les identifiants sont correcte</returns>
        private bool VerifieIdentifiant()
        {
            return true;
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
