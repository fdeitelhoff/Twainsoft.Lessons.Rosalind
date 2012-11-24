using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Twainsoft.Bioinformatics.DNA;

namespace Twainsoft.Lessons.Rosalind.Tests.DNA
{
    [TestClass]
    public class TranscribeRNATests
    {
        [TestMethod]
        public void TranscribeRNATest()
        {
            // Arrange
            var dna = "GATGGAACTTGACTACGTAAATT";
            var expectedRNA = "GAUGGAACUUGACUACGUAAAUU";

            // Act
            var resultRNA = dna.TranscribeRNA();

            // Assert
            Assert.AreEqual<string>(expectedRNA, resultRNA);
        }
    }
}
