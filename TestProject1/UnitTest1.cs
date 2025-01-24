using Ex3._1;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestConstructeur1()
        {
            //Arrange
            string Nom = "L�o";
            //Act
            Joueur j = new Joueur(Nom, "Nessi", 10, "Avant", 10, 100);
            //Assert
            Assert.Equal(Nom, j.Nom);
            Assert.Equal("Nessi", j.Prenom);
            //...
        }

        [Fact]
        public void Constructeur_Complet_CreationCorrecte()
        {
            // Arrange
            string nom = "Ronaldo";
            string prenom = "Cristiano";
            int numero = 7;
            string position = "Attaquant";
            int nombreDeButs = 820;
            int nombreDeParties = 1100;

            // Act
            Joueur joueur = new Joueur(nom, prenom, numero, position, nombreDeButs, nombreDeParties);

            // Assert
            Assert.Equal(nom, joueur.Nom);
            Assert.Equal(prenom, joueur.Prenom);
            Assert.Equal(numero, joueur.Numero);
            Assert.Equal(position, joueur.Position);
            Assert.Equal(nombreDeButs, joueur.NombreDeButs);
            Assert.Equal(nombreDeParties, joueur.NombreDeParties);
        }

        [Fact]
        public void Constructeur_Simple_CreationAvecValeursParDefaut()
        {
            // Arrange

            // Act
            Joueur joueur = new Joueur();

            // Assert
            Assert.Equal(null, joueur.Nom);// Valeur par d�faut pour les string
            Assert.Null(joueur.Prenom);
            Assert.Equal(0, joueur.Numero);// Valeur par d�faut pour les nombres
            Assert.Equal(null, joueur.Position);
            Assert.Equal(0, joueur.NombreDeButs); 
            Assert.Equal(0, joueur.NombreDeParties); 
        }

        [Fact]
        public void Equals_JoueursIdentiques_RetourneTrue()
        {
            // Arrange
            Joueur joueur1 = new Joueur("Ronaldo", "Cristiano", 7, "Attaquant", 820, 1100);
            Joueur joueur2 = new Joueur("Ronaldo", "Cristiano", 7, "Attaquant", 820, 1100);

            // Act
            bool sontEgaux = joueur1.Equals(joueur2);

            // Assert
            Assert.True(sontEgaux); //M�me chose que Assert.Equal(true, sontEgaux);
        }

        [Fact]
        public void Equals_JoueursDifferents_RetourneFalse()
        {
            // Arrange
            Joueur joueur1 = new Joueur("Ronaldo", "Cristiano", 7, "Attaquant", 820, 1100);
            Joueur joueur2 = new Joueur("Messi", "Lionel", 10, "Attaquant", 800, 1000);

            // Act
            bool sontEgaux = joueur1.Equals(joueur2);

            // Assert
            Assert.False(sontEgaux);
        }

        [Fact]
        public void Copie_RetourneNouvelleInstanceIdentique()
        {
            // Arrange
            Joueur joueurOriginal = new Joueur("Ronaldo", "Cristiano", 7, "Attaquant", 820, 1100);

            // Act
            Joueur joueurCopie = joueurOriginal.Copie();

            // Assert
            Assert.NotSame(joueurOriginal, joueurCopie); // V�rifie que ce sont deux instances diff�rentes
            Assert.True(joueurOriginal.Equals(joueurCopie)); // V�rifie que les donn�es sont identiques

            Joueur joueur3 = joueurOriginal;
            Assert.Same(joueurOriginal, joueur3); //Comparer les r�f�rences
            Assert.Equal(joueurOriginal, joueur3);
        }

        [Fact]
        public void ToString_RetourneRepresentationTextuelleCorrecte()
        {
            // Arrange
            Joueur joueur = new Joueur("Ronaldo", "Cristiano", 7, "Attaquant", 820, 1100);

            // Act
            string representation = joueur.ToString();

            // Assert
            Assert.Equal(
                "Nom: Ronaldo, Pr�nom: Cristiano, Num�ro: 7, Position: Attaquant, Nombre de buts: 820, Nombre de parties: 1100",
                representation
            );
        }
        
    }
}