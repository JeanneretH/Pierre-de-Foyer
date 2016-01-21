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
    public partial class Plateau : Form
    {
        public Plateau()
        {
            InitializeComponent();
        }

        private void Plateau_Load(object sender, EventArgs e)
        {
            //Initialisation
            Classes.Hero hero = new Classes.Hero();
            Classes.Hero heroAdverce = new Classes.Hero();

            //Image des objet (Temporaire)
            pbxHero.BackColor = Color.Green;
            pbxHeroAdverse.BackColor = Color.Red;
            pbxPouvoirHero.BackColor = Color.Yellow;
            pbxPouvoirHeroAdverse.BackColor = Color.Yellow;

            //Placement des objet
            pbxHero.Location = new Point(this.Width / 2 - pbxHero.Width / 2, this.Height - pbxHeroAdverse.Height);
            pbxHeroAdverse.Location = new Point(this.Width / 2 - pbxHeroAdverse.Width / 2, 0);
            pbxPouvoirHero.Location = new Point(this.Width / 2 + pbxHero.Width / 2, this.Height - pbxPouvoirHero.Height);
            pbxPouvoirHeroAdverse.Location = new Point(this.Width / 2 - pbxHeroAdverse.Width / 2 - pbxPouvoirHeroAdverse.Width, 0);
        }
    }
}
