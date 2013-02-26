using System;
using NUnit.Framework;
using Twainsoft.Bioinformatics.Format;

namespace Twainsoft.Lessons.Rosalind.Tests.TestCases
{
    [TestFixture]
    public class GcTests
    {
        [Test]
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
            Assert.That(entryCount, Is.EqualTo(entries.Count));
            Assert.That(expectedGcRatio, Is.EqualTo(highestGcRatio));
            Assert.That(expectedFastaLabel, Is.EqualTo(highestFastaLabel));
        }
    }
}
