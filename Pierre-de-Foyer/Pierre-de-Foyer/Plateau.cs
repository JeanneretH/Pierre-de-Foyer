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
    public partial class Plateau : Form
    {
        public Plateau()
        {
            InitializeComponent();
        }

        //Initialisation
        Classes.Hero hero = new Classes.Hero();
        Classes.Hero heroAdverse = new Classes.Hero();
        List<Carte> MainHero = new List<Carte>();
        List<Carte> MainHeroAdverce = new List<Carte>();
        bool bTour = true, bDejaUtilise = false;

        private void Plateau_Load(object sender, EventArgs e)
        {
            //Image des objet (Temporaire)
            pbxHero.BackColor = Color.Green;
            pbxHeroAdverse.BackColor = Color.Red;
            pbxPouvoirHero.BackColor = Color.Yellow;
            pbxPouvoirHeroAdverse.BackColor = Color.Yellow;
            pbxDeck.BackColor = Color.Blue;
            pbxDeckAdverse.BackColor = Color.Blue;

            //Placement des objets
            pbxHero.Location = new Point(this.Width / 2 - pbxHero.Width / 2, this.Height - pbxHeroAdverse.Height);
            pbxHeroAdverse.Location = new Point(this.Width / 2 - pbxHeroAdverse.Width / 2, 0);
            pbxPouvoirHero.Location = new Point(this.Width / 2 + pbxHero.Width / 2, this.Height - pbxPouvoirHero.Height);
            pbxPouvoirHeroAdverse.Location = new Point(this.Width / 2 - pbxHeroAdverse.Width / 2 - pbxPouvoirHeroAdverse.Width, 0);
            btnPasser.Location = new Point(this.Width - btnPasser.Width, this.Height / 2 - btnPasser.Height / 2);
            btnRetour.Location = new Point(this.Width - btnRetour.Width, 0);

            //Création d'une carte test
            Serviteur ServiteurTest = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest2 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest3 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest4 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest5 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest6 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest7 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest8 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest9 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest10 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest11 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);
            Serviteur ServiteurTest12 = new Serviteur(1, 10, "Détruit tous les serviteurs et vous défausse de votre main.", "Je savais pas quoi mettre", "Aile de mort", true, Properties.Resources.AileDeMort, 12, 12, true, false, false);

            MainHero.Add(ServiteurTest);
            MainHero.Add(ServiteurTest2);
            MainHero.Add(ServiteurTest3);
            MainHero.Add(ServiteurTest4);
            MainHero.Add(ServiteurTest5);
            MainHero.Add(ServiteurTest6);
            MainHero.Add(ServiteurTest7);
            MainHero.Add(ServiteurTest8);
            MainHero.Add(ServiteurTest9);
            MainHero.Add(ServiteurTest10);
            MainHero.Add(ServiteurTest11);
            MainHero.Add(ServiteurTest12);

            //Affichage de la main (Temporaire)
            pbxDeck.Location = new Point(this.Width / 4 * 3, 0);
            pbxDeck.Top = this.Height - pbxDeck.Height;
            pbxDeckAdverse.Location = new Point(this.Width / 4, 0);
        }

        private void Plateau_Paint(object sender, PaintEventArgs e)
        {
            //Dessine le trait de séparation du plateau
            Pen pen = new Pen(Color.Black, 3);
            e.Graphics.DrawLine(pen, 0, this.Height / 2, this.Width, this.Height / 2);
        }

        // Appelle cette fonction lorsque le joueur utilise sont pouvoir heroique
        private void pbxPouvoirHero_Click(object sender, EventArgs e)
        {
            if (bTour == true && bDejaUtilise == false)
            {
                hero._pouvoirHeroique();
                bDejaUtilise = true;
            }
        }

        // Appelle cette fonction lorsque le joueur adverse utilise sont pouvoir heroique
        private void pbxPouvoirHeroAdverse_Click(object sender, EventArgs e)
        {
            if(bTour == false && bDejaUtilise == false)
            {
                heroAdverse.getPouvoirHeroique();
                bDejaUtilise = true;
            }
        }

        // Appelle cette fonction lorsque le joueur passe sont tour
        private void btnPasser_Click(object sender, EventArgs e)
        {
            if(bTour == true)
            {
                heroAdverse.PiocherCartes();
                bTour = false;
            }
            else
            {
                hero.PiocherCartes();
                bTour = true;
            }
            bDejaUtilise = false;
        }

        // Quitte le plateau de jeu
        private void btnRetour_Click(object sender, EventArgs e)
        {
            Form menu = new Menu();
            menu.Show();
            this.Close();
        }

        private void pbxDeckAdverse_Click(object sender, EventArgs e)
        {
            if(bTour == false)
            {
                AfficheCarte(MainHeroAdverce);
            }
        }

        private void pbxDeck_Click(object sender, EventArgs e)
        {
            if(bTour == true)
            {
                AfficheCarte(MainHero);
            }
        }

        private void AfficheCarte(List<Carte> main)
        {
            int iCompteur = 0;
            foreach (Carte carte in main)
            {
                PictureBox pbxCarte = new PictureBox();
                pbxCarte.Size = new Size(150, 250);
                pbxCarte.Location = new Point((5 + pbxCarte.Width) * iCompteur, this.Height / 2 - pbxCarte.Height / 2);
                pbxCarte.Name = carte.strNom;
                pbxCarte.BackColor = Color.Pink;
                pbxCarte.Image = carte._imageCarte;
                Controls.Add(pbxCarte);
                iCompteur++;
            }
        }
    }
}
