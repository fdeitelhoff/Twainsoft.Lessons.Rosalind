using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Twainsoft.Bioinformatics
{
    public class Dna
    {
        private string Symbols { get; set; }
        private IDictionary<char, char> NucleotidComplements { get; set; }

        public Dna(string symbols)
        {
            Symbols = symbols.Trim();

            NucleotidComplements = new Dictionary<char, char>
                {
                {'A', 'T'}, {'T', 'A'}, {'C', 'G'}, {'G', 'C'}
            };
        }

        public Dictionary<char, int> NucleotidesCount()
        {
            var nucleotidesCount = new Dictionary<char, int>(4)
            {
                {'A', 0}, {'C', 0}, {'G', 0}, {'T', 0}
            };

            foreach (var symbol in Symbols)
            {
                nucleotidesCount[symbol]++;
            }

            return nucleotidesCount;
        }

        public Rna TranscribeRna()
        {
            return new Rna(Symbols.Replace('T', 'U'));
        }

        public Dna ReverseComplementDna()
        {
            var reversedDna = new StringBuilder(Symbols.Length);

            for (var i = Symbols.Length - 1; i >= 0; i--)
            {
                reversedDna.Append(NucleotidComplements[Symbols[i]]);
            }

            return new Dna(reversedDna.ToString());
        }

        public decimal CalculateGcRatio()
        {
            var regex = new Regex("[G|C]");
            var matches = regex.Matches(Symbols);

            return (decimal)matches.Count / Symbols.Length;
        }

        public override bool Equals(object obj)
        {
            var dna = obj as Dna;

            if (dna == null)
            {
                return false;
            }

            return dna.Symbols == Symbols;
        }

        public override int GetHashCode()
        {
            return Symbols.GetHashCode();
        }

        public override string ToString()
        {
            return Symbols;
        }
    }
}
