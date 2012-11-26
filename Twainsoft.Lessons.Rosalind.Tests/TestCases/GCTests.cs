using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Twainsoft.Lessons.Rosalind.Tests.TestCases.GC
{
    [TestClass]
    public class GCContentTests
    {
        [TestMethod]
        [DeploymentItem(@"Data\GC\GC_SampleDataSet.txt")]
        public void GCTests()
        {
            // Arrange
            var dna = File.ReadAllText(@"Data\GC\GC_SampleDataSet.txt");

            // Act

            // Assert
        }
    }
}
