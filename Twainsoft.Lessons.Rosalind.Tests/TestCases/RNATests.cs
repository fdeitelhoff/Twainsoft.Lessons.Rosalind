using NUnit.Framework;
using Twainsoft.Bioinformatics;

namespace Twainsoft.Lessons.Rosalind.Tests.TestCases
{
    [TestFixture]
    public class RnaTests
    {
        [Test]
        public void TranscribeRnaTest()
        {
            // Arrange
            var dna = new Dna("GATGGAACTTGACTACGTAAATT");
            var expectedRna = new Rna("GAUGGAACUUGACUACGUAAAUU");

            // Act
            var resultRna = dna.TranscribeRna();

            // Assert
            Assert.That(expectedRna, Is.EqualTo(resultRna));
        }
    }
}
