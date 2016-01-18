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
        protected int iId = 0;
        protected int iMana = 0;
        protected string strDescription = "";
        protected string strHeros = "";
        protected string strNom = "";
        protected bool bAttaquable = true;

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        /// <param name="mana">coût de la carte</param>
        /// <param name="description">description de la carte</param>
        /// <param name="hero">hero auquel appartient la carte</param>
        /// <param name="attaquable">true si la carte est attaquable, false si elle ne l'est pas</param>
        public Carte()
        {
            //this.Size = new Size()
            //this.Image = pr
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
