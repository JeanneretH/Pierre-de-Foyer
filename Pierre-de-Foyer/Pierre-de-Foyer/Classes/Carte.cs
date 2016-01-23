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
    class Carte:PictureBox
    {
        //on va voir cette syntaxe dans le 226b
        protected int iId { get; set; }
        protected int iMana { get; set; }
        protected string strDescription { get; set; }
        protected string strHeros { get; set; }
        protected string strNom { get; set; }
        protected bool bAttaquable { get; set; }


        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Carte()
        {

        }


        /// <summary>
        /// Permettra de jouer la carte
        /// </summary>
        public void Jouer()
        {

        }

        /// <summary>
        /// Permettra de defausser la carte
        /// </summary>
        public void Deffauser()
        {

        }

        public override string ToString()
        {
            return iId + " " + iMana + " " + strDescription + " " + strHeros + " " + bAttaquable;
        }
    }
}
