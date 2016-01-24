using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Pierre_de_Foyer
{
    public partial class Inscription : Form
    {
        public Inscription()
        {
            InitializeComponent();
        }

        private void Inscription_Load(object sender, EventArgs e)
        {
            //Placement des objets
            btnInscription.Location = new Point(this.Width / 2 - btnInscription.Width / 2, this.Height / 2 - btnInscription.Height);
        }

        private void NewCompte_Click(object sender, EventArgs e)
        {
            if (InscriptionCompte())
            {
                
            }
            else
            {
                MessageBox.Show("Le nom de compte est déjà utilisé", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tbxMotDePasse.Clear();
            }

        }

        /// <summary>
        /// on regarde si le compte est déjà utilisé ou non, et si non on l'inscrit et on confirme
        /// </summary>
        /// <returns>true si le compte a été créé, et false si un compte à ce nom existe déjà</returns>
        private bool InscriptionCompte()
        {
            string strCompte = tbxNom.Text;

            using (StreamReader sr = File.OpenText("Compte.txt"))
            {
                string strTxt;
                
                while ((strTxt = sr.ReadLine()) != null)
                {
                    string[] tableau = strTxt.Split(';');
                    if (tableau[0] == strCompte)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void RetourMenu_Click(object sender, EventArgs e)
        {
            Form connection = new Connection();
            connection.Show();
            this.Visible = false;
        }

    }
}
