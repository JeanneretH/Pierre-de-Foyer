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

namespace Pierre_de_Foyer.Classes
{
    class Hero
    {
        //propriétés
        public string strNom { get; private set; } = "";
        public int iPointDeVie { get; private set; } = 0;
        public int iAttaque { get; set; } = 0;
        public PouvoirHeroique _pouvoirHeroique { get; set; } = null;
        public List<Carte> _cartes { get; set; } = null;
        public Image _ImageHero { get; private set; } = null;
        private Random _random = new Random();


        /// <summary>
        /// Constructeur pas défaut (temporaire)
        /// </summary>
        public Hero()
        {

        }

        /// <summary>
        /// Constructeur spécifique de la classe Heros
        /// </summary>
        /// <param name="nomHeros">Nom du hero</param>
        /// <param name="pointDeVieHeros">Point de vie du hero</param>
        /// <param name="attaqueHeros">Point d'attaque du hero</param>
        /// <param name="pouvoirHeroique">Pouvoir heroique du hero</param>
        /// <param name="cartes">deck du hero</param>
        public Hero(string nom, int pointDeVie, int attaque, PouvoirHeroique pouvoirHeroique, List<Carte> cartes, Image image)
        {
            strNom = nom;
            iPointDeVie = pointDeVie;
            iAttaque = attaque;
            _pouvoirHeroique = pouvoirHeroique;
            _cartes = cartes;
            _ImageHero = image;
        }

        /// <summary>
        /// Permet au serviteur de se prendre des dégats
        /// </summary>
        /// <param name="nbrDegats">nombre de dégats subit par le hero</param>
        public void PrendreDesDegats(int nbrDegats)
        {
            iPointDeVie -= nbrDegats;
        }

        /// <summary>
        /// Permet d'attaquer un serviteur adverse
        /// </summary>
        /// <param name="serviteur">Il faut spécifier le serviteur en question</param>
        public void Attaquer(Serviteur serviteur)
        {
            serviteur.PrendreDesDegats(iAttaque);//on appelle la méthode 'PrendreDesDegats' du serviteur spécifié en paramétre
            PrendreDesDegats(serviteur.iAttaque);//on spécifie en paramétre l'attaque du serviteur passé en paramétre
        }

        /// <summary>
        /// Permet d'attaquer un hero adverse
        /// </summary>
        /// <param name="hero">Il faut spécifier le hero en question</param>
        public void Attaquer(Hero hero)
        {
            hero.PrendreDesDegats(iAttaque);//on appelle la méthode 'PrendreDesDegats' du hero spécifié en paramétre
            PrendreDesDegats(hero.iAttaque);//on spécifie en paramétre l'attaque du hero passé en paramétre
        }

        /// <summary>
        /// Permet au hero de piocher une carte
        /// </summary>
        /// <param name="deck">Il faut spécifier le deck en question</param>
        /// <returns>La carte pioché est retourné</returns>
        public Carte PiocherCartes(List<Carte> deck)
        {
            if (deck.Count > 0)
            {
                Carte _cartePioche = deck[_random.Next(0, deck.Count)];//permet de tirer une carte Random dans le deck
                deck.Remove(_cartePioche);
                return _cartePioche;
            }
            else
            {
                //Le joueur subira de la fatigue
                MessageBox.Show("Le Joueur subit de la fatigue !");
                return null;
            }
        }
    }
}
