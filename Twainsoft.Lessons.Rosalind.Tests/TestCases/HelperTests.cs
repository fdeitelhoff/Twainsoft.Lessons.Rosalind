using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Twainsoft.Bioinformatics.Helper;

namespace Twainsoft.Lessons.Rosalind.Tests.TestCases
{
    [TestClass]
    public class HelperTests
    {
        [TestMethod]
        public void PermutationTest()
        {
            // Arrange
            const int n = 3;
            var permutate = new List<int>();
            var permutationCount = 0;
            const int expectedPermutationCount = 6;
            
            // Act
            for (var i = 1; i < n; i++)
            {
                permutate.Add(i);
            }

            var permutations = Permutation.Permutate(permutate, out permutationCount);

            // Assert
            Assert.AreEqual(expectedPermutationCount, permutationCount);
        }
    }
}
