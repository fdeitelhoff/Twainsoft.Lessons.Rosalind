using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Twainsoft.Bioinformatics.DNA;
using System.IO;

namespace Twainsoft.Lessons.Rosalind.Tests.DNA
{
    [TestClass]
    public class CountingNucleotidesTests
    {
        [TestMethod]
        public void SampleDatasetTest()
        {
            // Arrange
            string dna = "AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC";
            Dictionary<char, int> expectedResult = new Dictionary<char, int>() 
            { 
                { 'A', 20 },
                { 'C', 12 },
                { 'G', 17 },
                { 'T', 21 }
            };

            // Act
            Dictionary<char, int> actualResult = dna.NucleotidesCount();

            // Assert
            CollectionAssert.AreEqual(expectedResult, actualResult);
        }
    }
}
