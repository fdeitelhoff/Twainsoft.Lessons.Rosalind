using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Twainsoft.Bioinformatics.DNA
{
    public static class DNAExtensions
    {
        /// <summary>
        /// Takes a DNA string (alphabet with symbols A, C, G and T) and count the symbols.
        /// </summary>
        /// <param name="dna">The DNA string.</param>
        /// <returns>A dictionary with the symbol count per nucleotide.</returns>
        public static Dictionary<char, int> NucleotidesCount(this string dna)
        {
            var nucleotidesCount = new Dictionary<char, int>(4)
            {
                {'A', 0}, {'C', 0}, {'G', 0}, {'T', 0}
            };

            foreach (var symbol in dna.Trim())
            {
                nucleotidesCount[symbol]++;
            }

            return nucleotidesCount;
        }

        /// <summary>
        /// Takes a DNA String (alphabet with symbols A, C, G and T) and returns a RNA string (replaces T with U).
        /// </summary>
        /// <param name="dna">The DNA string.</param>
        /// <returns>A RNA string with the symbols A, C, G and U.</returns>
        public static string TranscribeRNA(this string dna)
        {
            return dna.Trim().Replace('T', 'U');
        }

        /// <summary>
        /// Calculates the reverse complement of a dna string (reverse the given string and take the complement of each symbol (A <=> T, C <=> G).
        /// </summary>
        /// <param name="dna">The DNA string.</param>
        /// <returns>A dna string in the reverse complement representation.</returns>
        public static string ReverseComplementDNA(this string dna)
        {
            var reversedDNA = new StringBuilder(dna.Length);
            var nucleotidComplements = new Dictionary<char, char>()
            {
                {'A', 'T'}, {'T', 'A'}, {'C', 'G'}, {'G', 'C'}
            };

            dna = dna.Trim();

            for (int i = dna.Length - 1; i >= 0; i--)
            {
                reversedDNA.Append(nucleotidComplements[dna[i]]);
            }

            return reversedDNA.ToString();
        }
    }
}
