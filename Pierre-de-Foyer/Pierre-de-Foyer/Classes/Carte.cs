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
        public int iId { get; protected set; } = 0;
        public int iMana { get; set; } = 0;
        public string strDescription { get; protected set; } = "";
        public string strHeros { get; protected set; } = "";
        public string strNom { get; protected set; } = "";
        public bool bAttaquable { get; set; } = false;
        public Image _imageCarte;


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
