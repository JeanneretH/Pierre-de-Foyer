using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pierre_de_Foyer.Classes
{
    class Hero
    {
        private string strNom;
        private int iPointVie;
        private int iAttaque;
        private PouvoirHeroique _pouvoirHeroique;
        private List<Carte> _cartes = new List<Carte>();

        public void Attaquer()
        {

        }

        public void PrendreDegats()
        {

        }

        public int getPointDeVie()
        {
            return iPointVie;
        }

        public int getAttaque()
        {
            return iAttaque;
        }

        public void PiocherCartes()
        {

        }

        public PouvoirHeroique getPouvoirHeroique()
        {
            return _pouvoirHeroique;
        }
    }
}
