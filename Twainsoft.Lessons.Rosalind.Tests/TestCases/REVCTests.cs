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
            var dna = new DNA("AAAACCCGGT");
            var expectedDNA = new DNA("ACCGGGTTTT");

            // Act
            var resultDNA = dna.ReverseComplementDNA();

            // Assert
            Assert.AreEqual<DNA>(expectedDNA, resultDNA);
        }
    }
}
