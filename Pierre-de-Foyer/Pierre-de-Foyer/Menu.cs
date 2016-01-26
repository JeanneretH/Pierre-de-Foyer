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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            //Deplacement des objets
            btnJouer.Location = new Point(this.Width / 2 - btnJouer.Width / 2 , this.Height / 2 - btnJouer.Height / 2);
            btnDeck.Location = new Point(btnJouer.Location.X , btnJouer.Location.Y - btnDeck.Height - 6);
            btnQuitter.Location = new Point(btnJouer.Location.X , btnJouer.Location.Y + btnJouer.Height + 6);
        }

        // Permet à l'utilisateur de quitter le programme
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Affiche le plateau (Temporaire)
        private void btnJouer_Click(object sender, EventArgs e)
        {
            Form plateau = new Plateau();
            plateau.Show();
            this.Close();
        }

        private void btnDeck_Click(object sender, EventArgs e)
        {
            Form deck = new Deck();
            deck.Show();
            this.Close();
        }
    }
}
