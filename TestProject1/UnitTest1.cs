using Ex3._1;
namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void TestConstructeur1()
        {
            //Arrange
            string Nom = "Léo";
            //Act
            Joueur j = new Joueur(Nom, "Nessi", 10, "Avant", 10, 100);
            //Assert
            Assert.Equal(Nom, j.Nom);
            Assert.Equal("Nessi", j.Prenom);
            //...
        }
    }
}