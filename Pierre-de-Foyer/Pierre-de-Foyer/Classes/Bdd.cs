using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
/*using System.Configuration;
using MySql.Data.MySqlClient;*/

namespace Pierre_de_Foyer.Classes
{
    class Bdd
    {
        /*
        private MySqlConnection connexion;

         /// <summary>
         /// Constructeur par défaut
         /// </summary>
         public Bdd()
         {
             InitConnexion();
         }

        /// <summary>
        /// Méthode pour initialiser la connexion avec la BDD
        /// </summary>
        private void InitConnexion()
        {
            connexion = new MySqlConnection("server=localhost;user=root;database=pierredefoyer;port=3306;password=;");//permet de se connecter à la base de données
        }

        /// <summary>
        /// Permet de récupérer les serviteurs de la BDD
        /// </summary>
        /// <returns>retourne la liste de tous les serviteurs</returns>
        public List<Serviteur> LoadServiteurs()
        {
            connexion.Open();// Ouverture de la connexion SQL
            List<Serviteur> serviteurs = new List<Serviteur>();

            MySqlCommand Commande = new MySqlCommand("SELECT * FROM Serviteur", connexion);
            MySqlDataReader SDR = Commande.ExecuteReader();

            while (SDR.Read())
            {
                Serviteur serviteur = new Serviteur(Convert.ToInt32(SDR["Id"]), Convert.ToInt32(SDR["Mana"]), Convert.ToString(SDR["Description"]), Convert.ToString(SDR["Heros"]), Convert.ToString(SDR["Nom"]), Properties.Resources.AileDeMort, Convert.ToInt32(SDR["Attaque"]), Convert.ToInt32(SDR["PointDeVie"]), Convert.ToBoolean(SDR["Provocation"]), Convert.ToBoolean(SDR["Charge"]));
                serviteurs.Add(serviteur);
            }

            connexion.Close();
            return serviteurs;
        }

        /// <summary>
        /// Permet de récupérer les sorts de la BDD
        /// </summary>
        /// <returns>retourne la liste de tous les sorts</returns>
        public List<Sort> LoadSorts()
        {
            connexion.Open();// Ouverture de la connexion SQL
            List<Sort> sorts = new List<Sort>();

            MySqlCommand Commande = new MySqlCommand("SELECT * FROM Sort", connexion);
            MySqlDataReader SDR = Commande.ExecuteReader();

            while (SDR.Read())
            {
                Sort sort = new Sort(Convert.ToInt32(SDR["Id"]), Convert.ToInt32(SDR["Mana"]), Convert.ToString(SDR["Description"]), Convert.ToString(SDR["Heros"]), Convert.ToString(SDR["Nom"]), Properties.Resources.CarteHuit_Temporaire);
                sorts.Add(sort);
            }

            connexion.Close();
            return sorts;
        }

        /// <summary>
        /// Permet de récupérer les armes de la BDD
        /// </summary>
        /// <returns>retourne la liste de tous les armes</returns>
        public List<Arme> LoadArmes()
        {
            connexion.Open();// Ouverture de la connexion SQL
            List<Arme> armes = new List<Arme>();

            MySqlCommand Commande = new MySqlCommand("SELECT * FROM Arme", connexion);
            MySqlDataReader SDR = Commande.ExecuteReader();

            while (SDR.Read())
            {
                Arme arme = new Arme(Convert.ToInt32(SDR["Id"]), Convert.ToInt32(SDR["Mana"]), Convert.ToString(SDR["Description"]), Convert.ToString(SDR["Heros"]), Convert.ToString(SDR["Nom"]), null , Convert.ToInt32(SDR["Durabilite"]), Convert.ToInt32(SDR["Attaque"]));
                armes.Add(arme);
            }

            connexion.Close();
            return armes;

        }
        }

        /// <summary>
        /// methode test
        /// </summary>
        public PictureBox Test()
        {
            connexion.Open();// Ouverture de la connexion SQL

            PictureBox pbxTest = new PictureBox();

            MySqlCommand Commande = new MySqlCommand("SELECT * FROM Serviteur", connexion);
            MySqlDataAdapter Da = new MySqlDataAdapter(Commande);
            DataTable Dt = new DataTable();

            Da.Fill(Dt);
            byte[] img = (byte[])Dt.Rows[0][9];
            MemoryStream Ms = new MemoryStream(img);

            pbxTest.Image = Image.FromStream(Ms);
            Da.Dispose();
            connexion.Close();

            return pbxTest;
        }*/
    }
}
