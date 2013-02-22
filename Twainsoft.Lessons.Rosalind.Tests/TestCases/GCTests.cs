using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Twainsoft.Bioinformatics.Format;

namespace Twainsoft.Lessons.Rosalind.Tests.TestCases
{
    [TestClass]
    public class GcTests
    {
        [TestMethod]
        [DeploymentItem(@"Data\GC\GC_SampleDataSet.txt", @"Data\GC")]
        public void GcContentTests()
        {
            // Arrange
            var fasta = new Fasta();
            const int entryCount = 3;
            var highestGcRatio = 0m;
            const decimal expectedGcRatio = 60.919540m;
            var highestFastaLabel = "";
            const string expectedFastaLabel = "Rosalind_0808";

            // Act
            var entries = fasta.ReadEntries(@"Data\GC\GC_SampleDataSet.txt");
            foreach (var entry in entries)
            {
                var ratio = entry.Dna.CalculateGcRatio();
                if (ratio > highestGcRatio)
                {
                    highestGcRatio = ratio;
                    highestFastaLabel = entry.Label;
                }
            }

            highestGcRatio = Math.Round(highestGcRatio * 100, 6);

            // Assert
            Assert.AreEqual<int>(entryCount, entries.Count);
            Assert.AreEqual<decimal>(expectedGcRatio, highestGcRatio);
            Assert.AreEqual<string>(expectedFastaLabel, highestFastaLabel);
        }
    }
}
