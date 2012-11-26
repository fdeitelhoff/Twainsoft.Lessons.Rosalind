using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Twainsoft.Bioinformatics.Format;

namespace Twainsoft.Lessons.Rosalind.Tests.TestCases.GC
{
    [TestClass]
    public class GCContentTests
    {
        [TestMethod]
        [DeploymentItem(@"Data\GC\GC_SampleDataSet.txt", @"Data\GC")]
        public void GCTests()
        {
            // Arrange
            var fasta = new Fasta();
            var entryCount = 3;
            var highestGCRatio = 0m;
            var expectedGCRatio = 60.919540m;
            var highestFastaLabel = "";
            var expectedFastaLabel = "Rosalind_0808";

            // Act
            var entries = fasta.ReadEntries(@"Data\GC\GC_SampleDataSet.txt");
            foreach (var entry in entries)
            {
                var ratio = entry.DNA.CalculateGCRatio();
                if (ratio > highestGCRatio)
                {
                    highestGCRatio = ratio;
                    highestFastaLabel = entry.Label;
                }
            }

            highestGCRatio = Math.Round(highestGCRatio * 100, 6);

            // Assert
            Assert.AreEqual<int>(entryCount, entries.Count);
            Assert.AreEqual<decimal>(expectedGCRatio, highestGCRatio);
            Assert.AreEqual<string>(expectedFastaLabel, highestFastaLabel);
        }
    }
}
