using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pierre_de_Foyer.Classes
{
    class Serviteur:Carte
    {
        //propriétés
        public int iAttaque { get; set; } = 0;
        public int iPointDeVie { get; set; } = 0;
        public bool bPeutAttaquer { get; set; } = false;
        public bool bProvocation { get; set; } = false;
        public bool bCharge { get; set; } = false;


        /// <summary>
        /// Constructeur par défaut de la classe serviteur
        /// </summary>
        /// <param name="id">id de la carte</param>
        /// <param name="mana">cout en mana de la carte</param>
        /// <param name="description">description de la carte</param>
        /// <param name="heros">hero a qui appartient la carte</param>
        /// <param name="nom">nom de la carte</param>
        /// <param name="attaquable">mettre à 'true' si la carte peut se faire attaquer</param>
        /// <param name="attaque">nombre de point d'attaque</param>
        /// <param name="vie">nombre de point de vie</param>
        /// <param name="peutAttaquer">'true' si le heros peut attaquer</param>
        /// <param name="provocation">'true' si la carte est une provocation</param>
        /// <param name="charge">'true' si la carte a charge</param>
        public Serviteur(int id, int mana, string description, string heros, string nom, Image imageCarte, int attaque, int pointDeVie, bool provocation, bool charge)
        {
            iId = id;
            iMana = mana;
            strDescription = description;
            strHeros = heros;
            bAttaquable = true;
            _imageCarte = imageCarte;
            iAttaque = attaque;
            iPointDeVie = pointDeVie;
            bPeutAttaquer = false;
            bProvocation = provocation;
            bCharge = charge;
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
        /// Permet de tuer un serviteur 
        /// </summary>
        public void Mourrir()
        {
            this.Enabled = false;
        }

        /// <summary>
        /// transforme le serviteur selon ces attributs
        /// </summary>
        public void Transformation()
        {
            if(bCharge == true)
            {
                bPeutAttaquer = true;
            }

            if(bProvocation == true)
            {
                /*A venir*/
            }
        }

        public override string ToString()
        {
            return iAttaque + " " + iPointDeVie + " " + bPeutAttaquer + " " + bProvocation + " " + bCharge;
        }
    }
}
