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
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void Inscription_Load(object sender, EventArgs e)
        {
            //Placement des objets
            btnInscription.Location = new Point(this.Width / 2 - btnInscription.Width / 2, this.Height / 2 - btnInscription.Height);
        }

        private void NewCompte_Click(object sender, EventArgs e)
        {

        }

        private void RetourMenu_Click(object sender, EventArgs e)
        {
            Form connection = new Connection();
            connection.Show();
            this.Visible = false;
        }
    }
}
