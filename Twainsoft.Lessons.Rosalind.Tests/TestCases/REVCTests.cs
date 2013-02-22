using Microsoft.VisualStudio.TestTools.UnitTesting;
using Twainsoft.Bioinformatics;

namespace Twainsoft.Lessons.Rosalind.Tests.TestCases
{
    [TestClass]
    public class RevcTests
    {
        [TestMethod]
        public void ReversedDnaTest()
        {
            // Arrange
            var dna = new Dna("AAAACCCGGT");
            var expectedDna = new Dna("ACCGGGTTTT");

            // Act
            var resultDna = dna.ReverseComplementDna();

            // Assert
            Assert.AreEqual(expectedDna, resultDna);
        }
    }
}
