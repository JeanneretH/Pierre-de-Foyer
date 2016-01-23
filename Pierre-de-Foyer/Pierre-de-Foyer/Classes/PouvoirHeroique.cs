using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pierre_de_Foyer.Classes
{
    class PouvoirHeroique
    {
        //propriétés
        public int iCoutMana { get; set; } = 2;
        public string strNom { get; private set; } = "";
        public string strDescription { get; private set; } = "";

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="nom">nom du pouvoir heroique</param>
        /// <param name="description">description du pouvoir heroique</param>
        public PouvoirHeroique(string nom, string description)
        {
            strNom = nom;
            strDescription = description;
        }

        /// <summary>
        /// Pour l'instant le pouvoir heroique est 'inflige 2 points de dégats'
        /// </summary>
        /// <param name="serviteur">il faut préciser le serviteur en question</param>
        public void Action(Serviteur serviteur)
        {
            serviteur.PrendreDesDegats(2);
        }

        /// <summary>
        /// Pour l'instant le pouvoir heroique est 'inflige 2 points de dégats'
        /// </summary>
        /// <param name="serviteur">il faut préciser le serviteur en question</param>
        public void Action(Hero hero)
        {
            hero.PrendreDesDegats(2);
        }
    }
}
