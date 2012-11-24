using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Twainsoft.Bioinformatics.DNA;

namespace Twainsoft.Lessons.Rosalind.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var dna = File.ReadAllText(@"Data\DNA\rosalind_dna.txt");

            Dictionary<char, int> nucleotidesCount = dna.NucleotidesCount();

            Console.Write(String.Format("{0} {1} {2} {3}", nucleotidesCount['A'],
                nucleotidesCount['C'], nucleotidesCount['G'], nucleotidesCount['T']));
            Console.ReadLine();
        }
    }
}
