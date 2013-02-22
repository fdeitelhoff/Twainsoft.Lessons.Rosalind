using Microsoft.VisualStudio.TestTools.UnitTesting;
using Twainsoft.Bioinformatics;

namespace Twainsoft.Lessons.Rosalind.Tests.TestCases
{
    [TestClass]
    public class RnaTests
    {
        [TestMethod]
        public void TranscribeRnaTest()
        {
            // Arrange
            var dna = new Dna("GATGGAACTTGACTACGTAAATT");
            var expectedRna = new Rna("GAUGGAACUUGACUACGUAAAUU");

            // Act
            var resultRna = dna.TranscribeRna();

            // Assert
            Assert.AreEqual(expectedRna, resultRna);
        }
    }
}
