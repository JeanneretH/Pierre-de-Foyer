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
            tbxMotDePasse.Location = new Point(btnInscription.Location.X, btnInscription.Location.Y - tbxMotDePasse.Height - 6);
            lblMotDePasse.Location = new Point(tbxMotDePasse.Location.X, tbxMotDePasse.Location.Y - lblMotDePasse.Height - 2);
            tbxNom.Location = new Point(lblMotDePasse.Location.X, lblMotDePasse.Location.Y - tbxNom.Height - 6);
            lblNom.Location = new Point(tbxNom.Location.X, tbxNom.Location.Y - lblNom.Height - 2);
            btnRetourMenu.Location = new Point(btnInscription.Location.X, btnInscription.Location.Y + btnInscription.Height + 6);
        }


        /// <summary>
        /// On teste pour savoir si le compte peut être créé (on teste si tous les chmaps sont remplis et si le nom n'existe pas encore)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCompte_Click(object sender, EventArgs e)
        {
                if (String.IsNullOrEmpty(tbxMotDePasse.Text) || String.IsNullOrEmpty(tbxNom.Text))
                {
                    MessageBox.Show("Vous devez remplir l'intégralité des champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbxMotDePasse.Clear();
                }
                else
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
        }

        /// <summary>
        /// on regarde si le compte est déjà utilisé ou non, et si non on l'inscrit et on confirme
        /// </summary>
        /// <returns>true si le compte n'existe pas, et false si un compte à ce nom existe déjà</returns>
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
