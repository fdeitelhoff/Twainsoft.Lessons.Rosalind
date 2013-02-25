using System.Collections.Generic;
using System.Linq;

namespace Twainsoft.Bioinformatics.Helper
{
    public static class Permutation
    {
        public static IEnumerable<IEnumerable<T>> Permutate<T>(IEnumerable<T> list, out int permutationCount)
        {
            IEnumerable<IEnumerable<T>> emptyProduct = new[] { Enumerable.Empty<T>() };
            var permutations = list.Aggregate(
              emptyProduct,
              (accumulator, sequence) =>
                from accseq in accumulator
                from item in sequence
                select accseq.Concat(new object[] { item }));

            permutationCount = permutations.Count();

            return permutations;
        }
    }
}
