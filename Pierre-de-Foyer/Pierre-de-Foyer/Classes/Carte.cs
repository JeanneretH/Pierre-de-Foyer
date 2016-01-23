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
    class Carte:PictureBox
    {
        //propriétés
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
        /// <param name="deck">il faut passer une liste de carte</param>
        public void Jouer(List<Carte> deck)
        {
            deck.Add(this);
        }

        /// <summary>
        /// Permettra de defausser la carte
        /// </summary>
        public void Deffauser()
        {
            this.Enabled = false;
        }

        public override string ToString()
        {
            return iId + " " + iMana + " " + strDescription + " " + strHeros + " " + strNom + " " + bAttaquable + " " + Convert.ToString(_imageCarte);
        }
    }
}
