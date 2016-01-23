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
        public int iAttaque { get; set; } = 0;
        public int iVie { get; set; } = 0;
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
        public Serviteur(int id, int mana, string description, string heros, string nom, bool attaquable,Image imageCarte, int attaque, int vie, bool peutAttaquer, bool provocation, bool charge)
        {
            iId = id;
            iMana = mana;
            strDescription = description;
            strHeros = heros;
            bAttaquable = attaquable;
            _imageCarte = imageCarte;
            iAttaque = attaque;
            iVie = vie;
            bPeutAttaquer = peutAttaquer;
            bProvocation = provocation;
            bCharge = charge;
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
                /**/
            }
        }
    }
}
