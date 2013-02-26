using System.Collections.Generic;
using NUnit.Framework;
using Twainsoft.Bioinformatics;

namespace Twainsoft.Lessons.Rosalind.Tests.TestCases
{
    [TestFixture]
    public class DnaTests
    {
        [Test]
        public void NucleotidesCountTest()
        {
            // Arrange
            var dna = new Dna("AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC");
            var expectedResult = new Dictionary<char, int>
                { 
                { 'A', 20 }, { 'C', 12 }, { 'G', 17 }, { 'T', 21 }
            };

            // Act
            var actualResult = dna.NucleotidesCount();

            // Assert
            Assert.That(expectedResult, Is.EqualTo(actualResult));
        }

        [Test]
        public void HammingDistanceTest()
        {
            // Arrange
            var dna = new Dna("GAGCCTACTAACGGGAT");
            var mutatedDna = new Dna("CATCGTAATGACGGCCT");
            const int expectedMutationCount = 7;

            // Act
            var mutationCount = dna.HammingDistance(mutatedDna);

            // Assert
            Assert.That(expectedMutationCount, Is.EqualTo(mutationCount));
        }
    }
}
