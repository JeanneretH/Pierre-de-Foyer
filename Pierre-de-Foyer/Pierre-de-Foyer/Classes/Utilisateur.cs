using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pierre_de_Foyer.Classes
{
    class Utilisateur
    {
        //Objets
        private String strNom = "";
        private Hero HeroUtilisateur;

        //Constructeurs
        public Utilisateur(string nom)
        {
            this.strNom = nom;
        }

        public Hero getHeroFromUser()
        {
            List<Carte> DefaultDeck = new List<Carte>();
            switch(strNom)
            {
                case "Yohann":
                    {
                        for (int i = 0; i < 30; i++)
                        {
                            Serviteur Card = new Serviteur(1, 1, "Salut c'est lama", "Je savais pas quoi mettre", "Lamacorne", Properties.Resources.Lamacorne_Temporaire, 1, 1, true, true);
                            DefaultDeck.Add(Card);
                        }
                        HeroUtilisateur = new Hero("Yohann", 30, 0, null, DefaultDeck, null);
                    }
                    break;
                case "Sacha":
                    {
                        for (int i = 0; i < 30; i++)
                        {
                            Serviteur Card = new Serviteur(1, 1, "Salut c'est lama", "Je savais pas quoi mettre", "Lamacorne", Properties.Resources.Lamacorne_Temporaire, 1, 1, true, true);
                            DefaultDeck.Add(Card);
                        }
                        HeroUtilisateur = new Hero("Sacha", 30, 0, null, DefaultDeck, null);
                    }
                    break;
                case "Vincent":
                    {
                        for (int i = 0; i < 30; i++)
                        {
                            Serviteur Card = new Serviteur(1, 1, "Salut c'est lama", "Je savais pas quoi mettre", "Lamacorne", Properties.Resources.Lamacorne_Temporaire, 1, 1, true, true);
                            DefaultDeck.Add(Card);
                        }
                        HeroUtilisateur = new Hero("Vincent", 30, 0, null, DefaultDeck, null);
                    }
                    break;
                case "Hugo":
                    {
                        for (int i = 0; i < 30; i++)
                        {
                            Serviteur Card = new Serviteur(1, 1, "Salut c'est lama", "Je savais pas quoi mettre", "Lamacorne", Properties.Resources.Lamacorne_Temporaire, 1, 1, true, true);
                            DefaultDeck.Add(Card);
                        }
                        HeroUtilisateur = new Hero("Hugo", 30, 0, null, DefaultDeck, null);
                    }
                    break;
                case "Janis":
                    {
                        for (int i = 0; i < 30; i++)
                        {
                            Serviteur Card = new Serviteur(1, 1, "Salut c'est lama", "Je savais pas quoi mettre", "Lamacorne", Properties.Resources.Lamacorne_Temporaire, 1, 1, true, true);
                            DefaultDeck.Add(Card);
                        }
                        HeroUtilisateur = new Hero("Janis", 30, 0, null, DefaultDeck, null);
                    }
                    break;
                case "Romain":
                    {
                        for (int i = 0; i < 30; i++)
                        {
                            Serviteur Card = new Serviteur(1, 1, "Salut c'est lama", "Je savais pas quoi mettre", "Lamacorne", Properties.Resources.Lamacorne_Temporaire, 1, 1, true, true);
                            DefaultDeck.Add(Card);
                        }
                        HeroUtilisateur = new Hero("Romain", 30, 0, null, DefaultDeck, null);
                    }
                    break;
                default:
                    {
                        for (int i = 0; i < 30; i++)
                        {
                            Serviteur Card = new Serviteur(1, 1, "Salut c'est lama", "Je savais pas quoi mettre", "Lamacorne", Properties.Resources.Lamacorne_Temporaire, 1, 1, true, true);
                            DefaultDeck.Add(Card);
                        }
                        HeroUtilisateur = new Hero("Default", 30, 0, null, DefaultDeck, null);
                    }
                    break;
            }
            return HeroUtilisateur;
        }
    }
}
