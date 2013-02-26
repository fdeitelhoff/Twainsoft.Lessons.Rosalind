using NUnit.Framework;
using Twainsoft.Bioinformatics;

namespace Twainsoft.Lessons.Rosalind.Tests.TestCases
{
    [TestFixture]
    public class RevcTests
    {
        [Test]
        public void ReversedDnaTest()
        {
            // Arrange
            var dna = new Dna("AAAACCCGGT");
            var expectedDna = new Dna("ACCGGGTTTT");

            // Act
            var resultDna = dna.ReverseComplementDna();

            // Assert
            Assert.That(expectedDna, Is.EqualTo(resultDna));
        }
    }
}
