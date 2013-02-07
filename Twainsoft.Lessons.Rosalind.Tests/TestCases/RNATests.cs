using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Twainsoft.Bioinformatics;

namespace Twainsoft.Lessons.Rosalind.TestCases
{
    [TestClass]
    public class RNATests
    {
        [TestMethod]
        public void TranscribeRNATest()
        {
            // Arrange
            var dna = new Dna("GATGGAACTTGACTACGTAAATT");
            var expectedRNA = new Rna("GAUGGAACUUGACUACGUAAAUU");

            // Act
            var resultRNA = dna.TranscribeRna();

            // Assert
            Assert.AreEqual<Rna>(expectedRNA, resultRNA);
        }
    }
}
