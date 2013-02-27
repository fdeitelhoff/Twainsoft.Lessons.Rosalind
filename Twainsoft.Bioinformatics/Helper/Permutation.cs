using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Twainsoft.Bioinformatics.Helper
{
    public static class Permutation
    {
        public static IEnumerable<IEnumerable<T>> Permute<T>(this IList<T> v)
        {
            ICollection<IList<T>> result = new List<IList<T>>();

            Permute(v, v.Count, result);

            return result;
        }

        private static void Permute<T>(IList<T> v, int n, ICollection<IList<T>> result)
        {
            if (n == 1)
            {
                result.Add(new List<T>(v));
            }
            else
            {
                for (var i = 0; i < n; i++)
                {
                    Permute(v, n - 1, result);
                    Swap(v, n % 2 == 1 ? 0 : i, n - 1);
                }
            }
        }

        private static void Swap<T>(IList<T> v, int i, int j)
        {
            var t = v[i];
            v[i] = v[j];
            v[j] = t;
        }

        public static IEnumerable<IList<char>> CombineWithRepetitions(this IEnumerable<char> input, int take)
        {
            ICollection<IList<char>> output = new Collection<IList<char>>();
            IList<char> item = new char[take];

            CombineWithRepetitions(output, input, item, 0);

            return output;
        }

        private static void CombineWithRepetitions(ICollection<IList<char>> output, IEnumerable<char> input, IList<char> item, int count)
        {
            if (count < item.Count)
            {
                var enumerable = input as IList<char> ?? input.ToList();
                foreach (var symbol in enumerable)
                {
                    item[count] = symbol;
                    CombineWithRepetitions(output, enumerable, item, count + 1);
                }
            }
            else
            {
                output.Add(new List<char>(item));
            }
        }
    }
}
