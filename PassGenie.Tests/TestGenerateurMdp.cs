using PassGenie.Classes;
namespace PassGenie.Tests
{
    [TestClass]
    public class TestGenerateurMdp
    {
        MotDePasse v = new MotDePasse();

        // --- Tests pour la longueur ---
        [TestMethod] // retourne faux si le mdp est court 
        public void MdpEstCourt()
        {
            bool res = v.ContientLongueurSuffisante("aze");
            Assert.IsFalse(res);
        }

        [TestMethod] // retourne vrai si le mdp est long 
        public void MdpEstLong()
        {
            bool res = v.ContientLongueurSuffisante("azeaze");
            Assert.IsTrue(res);
        }


        // --- Tests pour les majuscules ---
        [TestMethod] // Retourne faux si le mdp ne contient pas un majuscule 
        public void MdpContientPasMaj()
        {
            bool res = v.ContientMajuscule("aze");
            Assert.IsFalse(res);
        }

        [TestMethod] // Retourne vrai si le mdp contient d'au moins un majuscule 
        public void MdpContientMaj()
        {
            bool res = v.ContientMajuscule("Aze");
            Assert.IsTrue(res);
        }

        // --- Tests pour les chiffres ---
        [TestMethod] // retourne faux si le mdp ne contient acun chiffre
        public void MdpContientPasChiffre()
        {
            bool res = v.ContientChiffre("aze");
            Assert.IsFalse(res);
        }

        [TestMethod] // retourne vrai si le mdp contient au moins d'un chiffre
        public void MdpContientChiffre()
        {
            bool res = v.ContientChiffre("aze123");
            Assert.IsTrue(res);
        }

        // --- Tests pour les symboles ---
        [TestMethod] // retourne faux si le mdp contient aucun symbole
        public void MdpContientPasSymbole()
        {
            bool res = v.ContientSymbole("aze123");
            Assert.IsFalse(res);
        }

        [TestMethod] // retourne vrai si le mdp contient au moins d'un symbole
        public void MdpContientSymbole()
        {
            bool res = v.ContientSymbole("@ze");
            Assert.IsTrue(res);
        }

        // --- Tests pour les mots connus ---
        [TestMethod] // retourne vrai si le mdp contient le mot connu dans le dictionnaire
        public void MdpContientMotConnu()
        {
            bool res = v.dictMotsConnus("azerty");
            Assert.IsTrue(res);
        }

        [TestMethod] // retourne faux si le mdp ne contient pas le mot connu dans le dictionnaire
        public void MdpContientPasMotConnu()
        {
            bool res = v.dictMotsConnus("84dzadfiozef");
            Assert.IsFalse(res);
        }
    }
}