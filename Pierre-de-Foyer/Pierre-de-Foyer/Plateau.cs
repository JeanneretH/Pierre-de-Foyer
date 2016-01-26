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
        List<Carte> MainHeroAdverse = new List<Carte>();
        bool bTour = true, bDejaUtilise = false;

        //déclaration des deck
        List<Carte> DeckHero = new List<Carte>();
        List<Carte> DeckHeroAdverse = new List<Carte>();

        private void Plateau_Load(object sender, EventArgs e)
        {
            //Ajout de 20 Mannequin
            for (int i = 0; i < 30; i++)
            {
                Serviteur Mannequin = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", true, Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true, true);

                DeckHero.Add(Mannequin);
                //DeckHeroAdverse.Add(Mannequin);
            }

            //ajout de 10 Huit
            for (int i = 0; i < 30; i++)
            {
                Serviteur Huit = new Serviteur(1, 8, "Son attaque ne change jamais.", "Je savais pas quoi mettre", "Huit", true, Properties.Resources.CarteHuit_Temporaire, 8, 8, true, false, false);

                //DeckHero.Add(Huit);
                DeckHeroAdverse.Add(Huit);
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
                lblDeckHero.Text = "Cartes restante :" + Convert.ToString(DeckHero.Count);
            }
            CacherMain(MainHero, "joueur");

            for (int i = 0; i < 4; i++)
            {
                MainHeroAdverse.Add(hero.PiocherCartes(DeckHeroAdverse));
                lblDeckHeroAdverse.Text = "Cartes restante :" + Convert.ToString(DeckHeroAdverse.Count);
            }
            CacherMain(MainHeroAdverse, "adversaire");

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
                if (MainHeroAdverse.Count <= 7)
                {
                    MainHeroAdverse.Add(hero.PiocherCartes(DeckHeroAdverse));
                    lblDeckHeroAdverse.Text = "Cartes restante :" + Convert.ToString(DeckHeroAdverse.Count);
                }
                bTour = false;
                CacherMain(MainHero, "joueur");
                CacherMain(MainHeroAdverse, "adversaire");
            }
            else
            {
                if (MainHero.Count <= 7)
                {
                    MainHero.Add(hero.PiocherCartes(DeckHero));
                    lblDeckHero.Text = "Cartes restante :" + Convert.ToString(DeckHero.Count);
                }
                bTour = true;
                CacherMain(MainHero, "joueur");
                CacherMain(MainHeroAdverse, "adversaire");
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
            if (bTour == false)
            {
                AfficheCarte(MainHeroAdverse);
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
            if (bTour)
            {
                foreach (Carte carte in main)
                {
                    carte.Size = new Size(200, 250);
                    carte.Location = new Point((5 + carte.Width) * iCompteur, this.Height - carte.Height - 4);
                    carte.Name = carte.strNom;
                    carte.BackColor = Color.White;
                    carte.Image = carte._imageCarte;
                    Controls.Add(carte);
                    iCompteur++;
                }
            }
            else
            {
                foreach (Carte carte in main)
                {
                    carte.Size = new Size(200, 250);
                    carte.Location = new Point((5 + carte.Width) * iCompteur, 4);
                    carte.Name = carte.strNom;
                    carte.BackColor = Color.White;
                    carte.Image = carte._imageCarte;
                    Controls.Add(carte);
                    iCompteur++;
                }
            }
        }

        private void CacherMain(List<Carte> main, string hero)
        {
            int iCompteur = 0;

            if (hero == "joueur")
            {
                foreach (Carte carte in main)
                {
                    carte.Size = new Size(200, 250);
                    carte.Location = new Point((5 + carte.Width) * iCompteur, this.Height - carte.Height - 4);
                    carte.Name = carte.strNom;
                    carte.BackColor = Color.White;
                    carte.Image = Properties.Resources.Dos_de_Carte_Hugo;
                    Controls.Add(carte);
                    iCompteur++;
                }
            }
            if(hero == "adversaire")
            {
                foreach (Carte carte in main)
                {
                    carte.Size = new Size(200, 250);
                    carte.Location = new Point((5 + carte.Width) * iCompteur, 4);
                    carte.Name = carte.strNom;
                    carte.BackColor = Color.White;
                    carte.Image = Properties.Resources.Dos_de_Carte_Hugo;
                    Controls.Add(carte);
                    iCompteur++;
                }
            }
        }
    }
}
