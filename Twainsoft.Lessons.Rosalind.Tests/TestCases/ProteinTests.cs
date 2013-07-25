using NUnit.Framework;
using Twainsoft.Bioinformatics;

namespace Twainsoft.Lessons.Rosalind.Tests.TestCases
{
    [TestFixture]
    public class ProteinTests
    {
        [Test]
        public void ProtTest()
        {
            // Arrange
            var rna = new Rna("AUGGCCAUGGCGCCCAGAACUGAGAUCAAUAGUACCCGUAUUAACGGGUGA");
            var expectedProtein = new Protein("MAMAPRTEINSTRING");

            // Act
            var protein = rna.EncodeProtein();

            // Assert
            Assert.That(protein, Is.EqualTo(expectedProtein));
        }
    }
}
