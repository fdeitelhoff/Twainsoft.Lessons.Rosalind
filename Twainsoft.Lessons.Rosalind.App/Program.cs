using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using Twainsoft.Bioinformatics;
using Twainsoft.Bioinformatics.Format;
using Twainsoft.Bioinformatics.Helper;

namespace Twainsoft.Lessons.Rosalind.App
{
    static class Program
    {
        static void Main()
        {
            // The DNA problem.
            SolveDna();

            // The RNA problem. 
            SolveRna();

            // The revc problem.
            SolveRevc();

            // Solve the GC problem.
            SolveGc();

            // Solve the HAMM problem.
            SolveHamm();

            // Solve the PERM problem.
            SolvePerm();

            Console.ReadLine();
        }

        /// <summary>
        /// Solves the PERM problem (http://rosalind.info/problems/perm/).
        /// </summary>
        private static void SolvePerm()
        {
            var number = Convert.ToInt32(File.ReadAllText(@"Data\PERM\rosalind_perm.txt").Trim());
            var toPermutate = new List<int>();
            for (var i = 1; i <= number; i++)
            {
                toPermutate.Add(i);
            }

            var permutations = toPermutate.Permute();

            var enumerable = permutations as IList<IEnumerable<int>> ?? permutations.ToList();
            var result = new StringBuilder();
            result.AppendLine(enumerable.Count.ToString(CultureInfo.InvariantCulture));

            foreach (var permutation in enumerable)
            {
                result.AppendLine(String.Join(" ", permutation));
            }

            SaveResult(@"Results\rosalind_perm_results.txt", result.ToString());
        }

        /// <summary>
        /// Solves the HAMM problem (http://rosalind.info/problems/hamm/).
        /// </summary>
        private static void SolveHamm()
        {
            var lines = File.ReadAllLines(@"Data\HAMM\rosalind_hamm.txt");
            var firstDna = new Dna(lines[0].Trim());
            var secondDna = new Dna(lines[1].Trim());

            var hammingDistance = firstDna.HammingDistance(secondDna);

            SaveResult(@"Results\rosalind_hamm_results.txt", hammingDistance.ToString(CultureInfo.InvariantCulture));
        }

        private static void SolveDna()
        {
            var dna = new Dna(File.ReadAllText(@"Data\DNA\rosalind_dna.txt"));

            var nucleotidesCount = dna.NucleotidesCount();

            var result = String.Format("{0} {1} {2} {3}", nucleotidesCount['A'],
                                       nucleotidesCount['C'], nucleotidesCount['G'], nucleotidesCount['T']);

            SaveResult(@"Results\rosalind_dna_results.txt", result);
        }

        /// <summary>
        /// Solves the RNA problem (http://rosalind.info/problems/rna/).
        /// </summary>
        private static void SolveRna()
        {
            var dna = new Dna(File.ReadAllText(@"Data\RNA\rosalind_rna.txt"));

            var rna = dna.TranscribeRna();

            SaveResult(@"Results\rosalind_rna_results.txt", rna.Symbols);
        }

        /// <summary>
        /// Solves the REVC problem (http://rosalind.info/problems/revc/).
        /// </summary>
        private static void SolveRevc()
        {
            var dna = new Dna(File.ReadAllText(@"Data\REVC\rosalind_revc.txt"));

            var reverseComplement = dna.ReverseComplementDna();

            SaveResult(@"Results\rosalind_revc_results.txt", reverseComplement.Symbols);
        }

        /// <summary>
        /// Solves the GC problem (http://rosalind.info/problems/gc/).
        /// </summary>
        private static void SolveGc()
        {
            var fasta = new Fasta();
            var entries = fasta.ReadEntries(@"Data\GC\rosalind_gc.txt");
            var highestGCRatio = 0m;
            var highestFastaLabel = "";

            foreach (var entry in entries)
            {
                var ratio = entry.Dna.CalculateGcRatio();
                if (ratio > highestGCRatio)
                {
                    highestGCRatio = ratio;
                    highestFastaLabel = entry.Label;
                }
            }

            highestGCRatio = Math.Round(highestGCRatio*100, 6);

            var result = String.Format("{0}\n{1}%", highestFastaLabel, highestGCRatio).Replace(',', '.');
            SaveResult(@"Results\rosalind_gc_results.txt", result);
        }

        static void SaveResult(string path, string result)
        {
            Console.WriteLine("The result is {0}", result);

            File.WriteAllText(path, result, Encoding.Default);
            Console.WriteLine("Result saved to '{0}'!", path);
            Console.WriteLine();
        }
    }
}
