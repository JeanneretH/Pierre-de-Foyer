using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pierre_de_Foyer.Classes
{
    class Arme : Carte
    {
        private int iDurabilite;
        private int iAttaque;

        public Arme(int attaque, int durabilite)
        {
            bAttaquable = false;
            this.iDurabilite = durabilite;
            this.iAttaque = attaque;
        }

        public void Attaquer()
        {
            
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

        public int getAttaque()
        {
            return iAttaque;
        }

        public int getDurabilite()
        {
            return iDurabilite;
        }

        public override string ToString()
        {
            return iDurabilite + " " + iAttaque;
        }
    }
}
