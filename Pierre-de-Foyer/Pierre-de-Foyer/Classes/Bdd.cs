using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Pierre_de_Foyer.Classes
{
    class Bdd
    {
        /* private MySqlConnection connexion;

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
             connexion = new MySqlConnection("SERVER=127.0.0.1; DATABASE=mli; UID=root; PASSWORD=");//permet de se connecter à la base de données
         }

         /// <summary>
         /// Permet d'afficher les données de la BDD
         /// </summary>
         /// <returns>retourne les données en question</returns>
         public string AffichageDeDonnée()
         {
             connexion.Open();// Ouverture de la connexion SQL

             MySqlCommand Commande = new MySqlCommand("SELECT * FROM Serviteur WHERE Nom='Millouse'", connexion);
             MySqlDataReader SDR = Commande.ExecuteReader();

             while (SDR.Read())
             {
                 return Convert.ToString(SDR);
             }

             return "";    
         }
         */
    }
}
