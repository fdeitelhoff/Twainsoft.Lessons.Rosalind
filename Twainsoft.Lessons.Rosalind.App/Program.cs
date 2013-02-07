using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twainsoft.Bioinformatics;
using Twainsoft.Bioinformatics.Format;

namespace Twainsoft.Lessons.Rosalind.App
{
    class Program
    {
        static void Main(string[] args)
        { 
            // The DNA problem.
            //var dna = File.ReadAllText(@"Data\DNA\rosalind_dna.txt");

            //Dictionary<char, int> nucleotidesCount = dna.NucleotidesCount();

            //Console.Write(String.Format("{0} {1} {2} {3}", nucleotidesCount['A'],
            //    nucleotidesCount['C'], nucleotidesCount['G'], nucleotidesCount['T']));
            //Console.ReadLine();

            // The RNA problem. 
            //var dna = File.ReadAllText(@"Data\RNA\rosalind_rna.txt");

            //var rna = dna.TranscribeRNA();
             
            //Console.WriteLine(rna);
            //SaveResult(@"Results\rosalind_rna_results.txt", rna);
            //Console.ReadLine();

            // The revc problem.
            //var dna = new DNA(File.ReadAllText(@"Data\REVC\rosalind_revc.txt"));

            //var reverseComplement = dna.ReverseComplementDNA();

            //Console.WriteLine(reverseComplement);
            //SaveResult(@"Results\rosalind_revc_results.txt", reverseComplement.Symbols);

            // The GC problem.
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

            highestGCRatio = Math.Round(highestGCRatio * 100, 6);

            var result = String.Format("{0}\n{1}%", highestFastaLabel, highestGCRatio).Replace(',', '.');
            Console.WriteLine(result);
            SaveResult(@"Results\rosalind_gc_results.txt", result);

            Console.ReadLine();
        }

        static void SaveResult(string path, string result)
        {
            File.WriteAllText(path, result, Encoding.Default);
            Console.WriteLine(String.Format("Result saved to '{0}'!", path));
        }
    }
}
