using PassGenie.Classes;
namespace PassGenie.Tests
{
    [TestClass]
    public class TestGenerateurMdp
    {
        [TestMethod]
        public void EstMotDePasseFort_DoitRetournerFauxSiTropCourt()
        {
            // Arrange
            var verificateur = new MotDePasse();
            string motDePasse = "torp!";

            // Act
            bool resultat = verificateur.EstMotDePasseFort(motDePasse);

            // Assert
            Assert.IsFalse(resultat);
        }

        [TestMethod]
        public void EstMotDePasseFort_DoitRetournerVraiSiMotDePasseFort()
        {
            // Arrange
            var verificateur = new MotDePasse();
            string motDePasse = "MotDePasseFort1!";

            // Act
            bool resultat = verificateur.EstMotDePasseFort(motDePasse);

            // Assert
            Assert.IsTrue(resultat);
        }

        [TestMethod]
        public void EstMotDePasseFort_DoitRetournerFauxSiSequenceInterdite()
        {
            // Arrange
            var verificateur = new MotDePasse();
            string motDePasse = "abcdef123456!";

            // Act
            bool resultat = verificateur.EstMotDePasseFort(motDePasse);

            // Assert
            Assert.IsFalse(resultat);
        }
    }
}