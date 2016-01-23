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
    class Serviteur:Carte
    {
        //on va voir ca dans le 226b
        public int iAttaque { get; set; }
        public int iVie { get; set; }
        public bool bPeutAttaquer { get; set; }
        public bool bProvocation { get; set; }
        public bool bCharge { get; set; }


        /// <summary>
        /// Constructeur par défaut de la classe serviteur
        /// </summary>
        /// <param name="id">id de la carte</param>
        /// <param name="mana">cout en mana de la carte</param>
        /// <param name="description">description de la carte</param>
        /// <param name="heros">hero a qui appartient la carte</param>
        /// <param name="nom">nom de la carte</param>
        /// <param name="attaquable">mettre à 'true' si la carte peut attaquer, mettre à 'false' si la carte ne peut pas attaquer</param>
        /// <param name="attaque">nombre de point d'attaque</param>
        /// <param name="vie">nombre de point de vie</param>
        /// <param name="peutAttaquer">'true' si le heros peut attaquer</param>
        /// <param name="provocation">'true' si la carte est une provocation</param>
        /// <param name="charge">'true' si la carte a charge</param>
        public Serviteur(int id, int mana, string description, string heros, string nom, bool attaquable, int attaque, int vie, bool peutAttaquer, bool provocation, bool charge)
        {
            iId = id;
            iMana = mana;
            strDescription = description;
            strHeros = heros;
            bAttaquable = attaquable;
            iAttaque = attaque;
            iVie = vie;
            bPeutAttaquer = peutAttaquer;
            bProvocation = provocation;
            bCharge = charge;
        }
    }
}
