using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Twainsoft.Bioinformatics;

namespace Twainsoft.Lessons.Rosalind.Tests.TestCases
{
    [TestClass]
    public class DnaTests
    {
        [TestMethod]
        public void NucleotidesCountTest()
        {
            // Arrange
            var dna = new Dna("AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC");
            var expectedResult = new Dictionary<char, int>() 
            { 
                { 'A', 20 }, { 'C', 12 }, { 'G', 17 }, { 'T', 21 }
            };

            // Act
            var actualResult = dna.NucleotidesCount();

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void HammingDistanceTest()
        {
            // Arrange
            var dna = new Dna("GAGCCTACTAACGGGAT");
            var mutatedDna = new Dna("CATCGTAATGACGGCCT");
            const int expectedMutationCount = 7;

            // Act
            var mutationCount = dna.HammingDistance(mutatedDna);

            // Assert
            Assert.AreEqual(expectedMutationCount, mutationCount);
        }
    }
}
