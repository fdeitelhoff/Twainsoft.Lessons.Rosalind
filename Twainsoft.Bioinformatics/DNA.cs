using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twainsoft.Bioinformatics
{
    public class DNA
    {
        public string Symbols { get; private set; }

        public static IDictionary<char, char> NucleotidComplements = new Dictionary<char, char>()
        {
            {'A', 'T'}, {'T', 'A'}, {'C', 'G'}, {'G', 'C'}
        };

        public DNA(string symbols)
        {
            Symbols = symbols.Trim();

            var nucleotidComplements = new Dictionary<char, char>()
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

        public RNA TranscribeRNA()
        {
            return new RNA(Symbols.Replace('T', 'U'));
        }

        public DNA ReverseComplementDNA()
        {
            var reversedDNA = new StringBuilder(Symbols.Length);

            for (int i = Symbols.Length - 1; i >= 0; i--)
            {
                reversedDNA.Append(NucleotidComplements[Symbols[i]]);
            }

            return new DNA(reversedDNA.ToString());
        }

        public override bool Equals(object obj)
        {
            DNA dna = obj as DNA;

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
            return Symbols.ToString();
        }
    }
}
