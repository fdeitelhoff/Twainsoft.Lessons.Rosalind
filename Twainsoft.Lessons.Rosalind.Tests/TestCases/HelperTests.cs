using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Twainsoft.Bioinformatics.Helper;

namespace Twainsoft.Lessons.Rosalind.Tests.TestCases
{
    [TestFixture]
    public class HelperTests
    {
        [Test]
        public void PermutationTest()
        {
            // Arrange
            var permutate = new List<int> {1, 2, 3};
            var exptectedPermutations = new List<List<int>>
                {
                    new List<int> {1, 2, 3},
                    new List<int> {1, 3, 2},
                    new List<int> {2, 1, 3},
                    new List<int> {2, 3, 1},
                    new List<int> {3, 1, 2},
                    new List<int> {3, 2, 1}
                };
            const int expectedPermutationCount = 6;
            
            // Act
            var permutations = permutate.Permute();

            // Assert
            var enumerable = permutations as IEnumerable<int>[] ?? permutations.ToArray();
            Assert.That(expectedPermutationCount, Is.EqualTo(enumerable.Length));
            Assert.That(exptectedPermutations, Is.EquivalentTo(enumerable));
        }
    }
}
