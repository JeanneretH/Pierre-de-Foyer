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

        //déclaration de la liste
        List<Carte> DeckHero = new List<Carte>();

        private void Plateau_Load(object sender, EventArgs e)
        {
            //Ajout de 20 Mannequin
            for (int i = 0; i < 20; i++)
            {
                Serviteur Mannequin = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);

                DeckHero.Add(Mannequin);
            }

            //ajout de 10 Huit
            for (int i = 0; i < 10; i++)
            {
                Serviteur Huit = new Serviteur(1, 8, "Son attaque ne change jamais.", "Je savais pas quoi mettre", "Huit", true, Properties.Resources.CarteHuit_Temporaire, 8, 8, true, false, false);

                DeckHero.Add(Huit);
            }


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

            for (int i = 0; i < 4; i++)
            {
                MainHero.Add(hero.PiocherCartes(DeckHero));
                PictureBox pbxCarte = new PictureBox();
                pbxCarte.Size = new Size(200, 250);
                pbxCarte.Location = new Point(this.Width / 2 + (5 + pbxCarte.Width) * i, (this.Height / 3) * 2 - pbxCarte.Height / 2);
                pbxCarte.Name = hero.PiocherCartes(DeckHero).strNom;
                pbxCarte.BackColor = Color.White;
                pbxCarte.Image = hero.PiocherCartes(DeckHero)._imageCarte;
                Controls.Add(pbxCarte);
            }

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
                bDejaUtilise = true;
            }
        }

        // Appelle cette fonction lorsque le joueur adverse utilise sont pouvoir heroique
        private void pbxPouvoirHeroAdverse_Click(object sender, EventArgs e)
        {
            if(bTour == false && bDejaUtilise == false)
            {
                bDejaUtilise = true;
            }
        }

        // Appelle cette fonction lorsque le joueur passe sont tour
        private void btnPasser_Click(object sender, EventArgs e)
        {
            if(bTour == true)
            {
                heroAdverse.PiocherCartes(DeckHero);
                bTour = false;
            }
            else
            {
                hero.PiocherCartes(DeckHero);
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
                pbxCarte.Size = new Size(200, 250);
                pbxCarte.Location = new Point((5 + pbxCarte.Width) * iCompteur, (this.Height  / 3) * 2 - pbxCarte.Height / 2);
                pbxCarte.Name = carte.strNom;
                pbxCarte.BackColor = Color.White;
                pbxCarte.Image = carte._imageCarte;
                Controls.Add(pbxCarte);
                iCompteur++;
            }
        }
    }
}
