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

        /// <summary>
        /// Permet à l'utilisateur de quitter le programme
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
