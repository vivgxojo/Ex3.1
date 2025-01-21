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

        // Premier constructeur
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

        // Méthode Equals pour comparer deux joueurs
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
