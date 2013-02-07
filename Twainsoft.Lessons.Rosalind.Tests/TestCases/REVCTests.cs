using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Twainsoft.Bioinformatics;

namespace Twainsoft.Lessons.Rosalind.TestCases
{
    [TestClass]
    public class REVCTests
    {
        [TestMethod]
        public void ReversedDNATest()
        {
            // Arrange
            var dna = new Dna("AAAACCCGGT");
            var expectedDNA = new Dna("ACCGGGTTTT");

            // Act
            var resultDNA = dna.ReverseComplementDna();

            // Assert
            Assert.AreEqual<Dna>(expectedDNA, resultDNA);
        }
    }
}
