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
        private int iAttaque = 0;
        private int iVie = 0;
        private bool bProvocation = false;
        private bool bCharge = false;
        private bool bCriDeGuerre = false;
        private bool bRaleAgonie = false;


        public Serviteur(int attaque, int vie, bool provocation, bool charge, bool criDeGuerre, bool raleAgonie)
        {
            
        }
    }
}
