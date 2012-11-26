using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using Twainsoft.Bioinformatics;

namespace Twainsoft.Lessons.Rosalind.TestCases
{
    [TestClass]
    public class DNATests
    {
        [TestMethod]
        public void NucleotidesCountTest()
        {
            // Arrange
            var dna = new DNA("AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC");
            var expectedResult = new Dictionary<char, int>() 
            { 
                { 'A', 20 }, { 'C', 12 }, { 'G', 17 }, { 'T', 21 }
            };

            // Act
            var actualResult = dna.NucleotidesCount();

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
