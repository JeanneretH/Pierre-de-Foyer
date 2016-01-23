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
    class Arme : Carte
    {
        public int iDurabilite { get; private set; } = 0;
        public int iAttaque { get; private set; } = 0;

        public Arme(int id, int mana, string description, string heros, string nom, Image imageCarte, int durabilite, int attaque)
        {
            iId = id;
            iMana = mana;
            strDescription = description;
            strHeros = heros;
            bAttaquable = false;
            _imageCarte = imageCarte;
            iDurabilite = durabilite;
            iAttaque = attaque;
        }

        public void Attaquer()
        {
            if (iDurabilite >= 2)
            {
                iDurabilite -= 1;
            }
            else
            {
                Detruire();
            }
            
        }

        public int GainAttaque(int gainAttaque)
        {
            this.iAttaque += gainAttaque;
            return iAttaque;
        }

        public int GainDurabilite(int gainDurabilite)
        {
            this.iDurabilite += gainDurabilite;
            return iDurabilite;
        }

        public int PerteDurabilite(int perteDurabilite)
        {
            this.iDurabilite = perteDurabilite;
            return iDurabilite;
        }

        public void Detruire()
        {
            this.Enabled = false;
        }

        public override string ToString()
        {
            return iDurabilite + " " + iAttaque;
        }
    }
}
