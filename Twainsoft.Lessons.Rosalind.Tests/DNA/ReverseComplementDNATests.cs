using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Twainsoft.Bioinformatics.DNA;

namespace Twainsoft.Lessons.Rosalind.Tests.DNA
{
    [TestClass]
    public class ReverseComplementDNATests
    {
        [TestMethod]
        public void ReversedDNATest()
        {
            // Arrange
            var dna = "AAAACCCGGT";
            var expectedDNA = "ACCGGGTTTT";

            // Act
            var resultDNA = dna.ReverseComplementDNA();

            // Assert
            Assert.AreEqual<string>(expectedDNA, resultDNA);
        }
    }
}
