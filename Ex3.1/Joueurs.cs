using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3._1
{
    public class Joueur
    {
        //Propriétés
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Numero { get; set; }
        public string Position { get; set; }
        public int NombreDeButs { get; set; }
        public int NombreDeParties { get; set; }

        /// <summary>
        /// Constructeur par paramètres
        /// </summary>
        /// <param name="nom">Nom du joueur</param>
        /// <param name="prenom">Prénom du joueur</param>
        /// <param name="numero">Numéro dans l'équipe</param>
        /// <param name="position">Position dans l'équipe</param>
        /// <param name="nombreDeButs">Nombre du buts</param>
        /// <param name="nombreDeParties">Nombre de parties jouées</param>
        public Joueur(string nom, string prenom, int numero, string position, int nombreDeButs, int nombreDeParties)
        {
            Nom = nom;
            Prenom = prenom;
            Numero = numero;
            Position = position;
            NombreDeButs = nombreDeButs;
            NombreDeParties = nombreDeParties;
        }

        // Deuxième constructeur
        public Joueur() { }

        /// <summary>
        /// Méthode Equals pour comparer deux joueurs
        /// </summary>
        /// <param name="joueur2">joueur à comparer</param>
        /// <returns>vrai si tous les attributs sont égaux</returns>
        public bool Equals(Joueur joueur2)
        {
            if( Nom == joueur2.Nom &&
                Prenom == joueur2.Prenom &&
                Numero == joueur2.Numero &&
                Position == joueur2.Position &&
                NombreDeButs == joueur2.NombreDeButs &&
                NombreDeParties == joueur2.NombreDeParties)
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        // Méthode Copie pour retourner une copie de l'objet
        public Joueur Copie()
        {
            Joueur joueur2 = new Joueur(Nom, Prenom, Numero, Position, NombreDeButs, NombreDeParties);
            return joueur2;
        }

        // Méthode ToString pour afficher les informations du joueur
        public override string ToString()
        {
            return $"Nom: {Nom}, Prénom: {Prenom}, Numéro: {Numero}, Position: {Position}, " +
                   $"Nombre de buts: {NombreDeButs}, Nombre de parties: {NombreDeParties}";
        }
    }

}
