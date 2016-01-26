using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Pierre_de_Foyer.Classes;

namespace Pierre_de_Foyer
{
    public partial class Deck : Form
    {
        public Deck()
        {
            InitializeComponent();
        }

        private void Deck_Load(object sender, EventArgs e)
        {
            Bdd bdd = new Bdd();
            List<Serviteur> serviteurs = bdd.LoadServiteurs();
            List<Sort> sorts = bdd.LoadSorts();
            List<Arme> armes = bdd.LoadArmes();

            List<Label> labels = new List<Label>();

            bdd.Test();

            /*foreach (Serviteur serviteur in serviteurs)
            {
                Label label = new Label();
                label.Text = serviteur.ToString();
                labels.Add(label);
            }

            int iX = 50;
            int iY = 50;

            foreach(Label label in labels)
            {
                iY += 50;

                Controls.Add(label);
                label.Location = new Point(iX, iY);
            }*/
        }
    }
}
