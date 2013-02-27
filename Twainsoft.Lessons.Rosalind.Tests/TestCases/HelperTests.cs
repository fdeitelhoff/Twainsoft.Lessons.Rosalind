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

        [Test]
        public void LexfTest()
        {
            // Arrange
            var symbols = new List<char> { 'T', 'A', 'G', 'C' };
            const int take = 2;
            const int exptectedCombinationCount = 16;
            var exptectedCombinations = new List<List<char>>
                {
                    new List<char> {'T', 'T'},
                    new List<char> {'T', 'A'},
                    new List<char> {'T', 'G'},
                    new List<char> {'T', 'C'},
                    new List<char> {'A', 'T'},
                    new List<char> {'A', 'A'},
                    new List<char> {'A', 'G'},
                    new List<char> {'A', 'C'},
                    new List<char> {'G', 'T'},
                    new List<char> {'G', 'A'},
                    new List<char> {'G', 'G'},
                    new List<char> {'G', 'C'},
                    new List<char> {'C', 'T'},
                    new List<char> {'C', 'A'},
                    new List<char> {'C', 'G'},
                    new List<char> {'C', 'C'}
                };

            // Act
            var combinations = symbols.CombineWithRepetitions(take).ToList();

            // Assert
            Assert.That(exptectedCombinationCount, Is.EqualTo(combinations.Count()));
            Assert.That(exptectedCombinations, Is.EquivalentTo(combinations));
        }
    }
}
