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
                Serviteur Mannequin = new Serviteur(1, 1, "Charge, provocation, râle d'agonie, cri de guerre invoque un autre mannequin.", "Je savais pas quoi mettre", "Mannequin crash test", Properties.Resources.CarteMannequinCrashTest_Temporaire, 1, 1, true, true);

                DeckHero.Add(Mannequin);
                //DeckHeroAdverse.Add(Mannequin);
            }

            //ajout de 10 Huit
            for (int i = 0; i < 30; i++)
            {
                Serviteur Huit = new Serviteur(1, 8, "Son attaque ne change jamais.", "Je savais pas quoi mettre", "Huit", Properties.Resources.CarteHuit_Temporaire, 8, 8, false, false);

                //DeckHero.Add(Huit);
                DeckHeroAdverse.Add(Huit);
            }

            //Image des objet (Temporaire)
            pbxHero.BackColor = Color.Green;
            pbxHeroAdverse.BackColor = Color.Red;
            pbxPouvoirHero.BackColor = Color.Yellow;
            pbxPouvoirHeroAdverse.BackColor = Color.Yellow;

            //Placement des objets
            pbxHero.Location = new Point(this.Width / 2 - pbxHero.Width / 2, this.Height - pbxHeroAdverse.Height);
            pbxHeroAdverse.Location = new Point(this.Width / 2 - pbxHeroAdverse.Width / 2, 0);
            pbxPouvoirHero.Location = new Point(this.Width / 2 + pbxHero.Width / 2, this.Height - pbxPouvoirHero.Height);
            pbxPouvoirHeroAdverse.Location = new Point(this.Width / 2 - pbxHeroAdverse.Width / 2 - pbxPouvoirHeroAdverse.Width, 0);
            btnPasser.Location = new Point(this.Width - btnPasser.Width, this.Height / 2 - btnPasser.Height / 2);
            btnRetour.Location = new Point(this.Width - btnRetour.Width, 0);

            //Fais piocher trois cartes du deck du heros et les places dans sa main
            for (int i = 0; i < 4; i++)
            {
                MainHero.Add(hero.PiocherCartes(DeckHero));
                lblDeckHero.Text = "Cartes restante :" + Convert.ToString(DeckHero.Count);
            }
            CacherMain(MainHero, "joueur"); //Seul le dos de carte s'affiche

            //Fais piocher trois cartes du deck de l'adversaire et les places dans sa main
            for (int i = 0; i < 4; i++)
            {
                MainHeroAdverse.Add(hero.PiocherCartes(DeckHeroAdverse));
                lblDeckHeroAdverse.Text = "Cartes restante :" + Convert.ToString(DeckHeroAdverse.Count);
            }
            CacherMain(MainHeroAdverse, "adversaire"); //Seul le dos de carte s'affiche

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
            if (bTour == false && bDejaUtilise == false)
            {
                bDejaUtilise = true;
            }
        }

        // Appelle cette fonction lorsque le joueur passe sont tour
        private void btnPasser_Click(object sender, EventArgs e)
        {
            if (bTour == true) //Vérifie à qui s'est le tour
            {
                //Le heros ne peut avoir qu'un certain nombre de carte dans sa main
                if (MainHeroAdverse.Count <= 7)
                {
                    MainHeroAdverse.Add(hero.PiocherCartes(DeckHeroAdverse)); //pioche une carte au debut du tour
                    lblDeckHeroAdverse.Text = "Cartes restante :" + Convert.ToString(DeckHeroAdverse.Count); //Affiche la quantité de carte qui reste dans le deck
                }
                bTour = false;
                CacherMain(MainHero, "joueur");
                CacherMain(MainHeroAdverse, "adversaire");
            }
            else
            {
                //Le heros ne peut avoir qu'un certain nombre de carte dans sa main
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

        /// <summary>
        /// Fait apparaitre l'interface des cartes dans la main
        /// </summary>
        /// <param name="main">La liste de carte dans la main qu'il faut afficher</param>
        private void AfficheCarte(List<Carte> main)
        {
            int iCompteur = 0;

            if (bTour)
            {
                //Matérialise chaque carte de la liste du heros
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
                //Matérialise chaque carte de la liste de l'adversaire
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

        /// <summary>
        /// Cache toute les cartes en affichant le dos de la carte
        /// </summary>
        /// <param name="main">Précisé la main qu'il faut cacher</param>
        /// <param name="hero">Précisé à qui appartient la main</param>
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
                    carte.Click += new EventHandler(this.AfficheMain);
                    Controls.Add(carte);
                    iCompteur++;
                }
            }
            if (hero == "adversaire")
            {
                foreach (Carte carte in main)
                {
                    carte.Size = new Size(200, 250);
                    carte.Location = new Point((5 + carte.Width) * iCompteur, 4);
                    carte.Name = carte.strNom;
                    carte.BackColor = Color.White;
                    carte.Image = Properties.Resources.Dos_de_Carte_Hugo;
                    carte.Click += new EventHandler(this.AfficheMainAdverse);
                    Controls.Add(carte);
                    iCompteur++;
                }
            }
        }

        /// <summary>
        /// Appele la fonction qui affiche la main du hero lorsque l'on clique dessus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficheMain(object sender, EventArgs e)
        {
            if (bTour)
                AfficheCarte(MainHero);
        }

        /// <summary>
        /// Appele la fonction qui affiche la main de l'adversaire lorsque l'on clique dessus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AfficheMainAdverse(object sender, EventArgs e)
        {
            if (!bTour)
                AfficheCarte(MainHeroAdverse);
        }
    }
}
