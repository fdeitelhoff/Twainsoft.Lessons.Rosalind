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
            var dna = new DNA("GATGGAACTTGACTACGTAAATT");
            var expectedRNA = new RNA("GAUGGAACUUGACUACGUAAAUU");

            // Act
            var resultRNA = dna.TranscribeRNA();

            // Assert
            Assert.AreEqual<RNA>(expectedRNA, resultRNA);
        }
    }
}
