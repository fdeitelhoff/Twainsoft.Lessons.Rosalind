using System.Collections.Generic;
using System.Text;

namespace Twainsoft.Bioinformatics
{
    public class Rna
    {
        public string Symbols { get; private set; }
        private Dictionary<string, string> CodonTable { get; set; }

        public Rna(string symbols)
        {
            Symbols = symbols.Trim();

            CodonTable = new Dictionary<string, string>();
            CodonTable.Add("UUU", "F");
            CodonTable.Add("CUU", "L");
            CodonTable.Add("AUU", "I");
            CodonTable.Add("GUU", "V");
            CodonTable.Add("UUC", "F");
            CodonTable.Add("CUC", "L");
            CodonTable.Add("AUC", "I");
            CodonTable.Add("GUC", "V");
            CodonTable.Add("UUA", "L");
            CodonTable.Add("CUA", "L");
            CodonTable.Add("AUA", "I");
            CodonTable.Add("GUA", "V");
            CodonTable.Add("UUG", "L");
            CodonTable.Add("CUG", "L");
            CodonTable.Add("AUG", "M");
            CodonTable.Add("GUG", "V");
            CodonTable.Add("UCU", "S");
            CodonTable.Add("CCU", "P");
            CodonTable.Add("ACU", "T");
            CodonTable.Add("GCU", "A");
            CodonTable.Add("UCC", "S");
            CodonTable.Add("CCC", "P");
            CodonTable.Add("ACC", "T");
            CodonTable.Add("GCC", "A");
            CodonTable.Add("UCA", "S");
            CodonTable.Add("CCA", "P");
            CodonTable.Add("ACA", "T");
            CodonTable.Add("GCA", "A");
            CodonTable.Add("UCG", "S");
            CodonTable.Add("CCG", "P");
            CodonTable.Add("ACG", "T");
            CodonTable.Add("GCG", "A");
            CodonTable.Add("UAU", "Y");
            CodonTable.Add("CAU", "H");
            CodonTable.Add("AAU", "N");
            CodonTable.Add("GAU", "D");
            CodonTable.Add("UAC", "Y");
            CodonTable.Add("CAC", "H");
            CodonTable.Add("AAC", "N");
            CodonTable.Add("GAC", "D");
            CodonTable.Add("UAA", "Stop");
            CodonTable.Add("CAA", "Q");
            CodonTable.Add("AAA", "K");
            CodonTable.Add("GAA", "E");
            CodonTable.Add("UAG", "Stop");
            CodonTable.Add("CAG", "Q");
            CodonTable.Add("AAG", "K");
            CodonTable.Add("GAG", "E");
            CodonTable.Add("UGU", "C");
            CodonTable.Add("CGU", "R");
            CodonTable.Add("AGU", "S");
            CodonTable.Add("GGU", "G");
            CodonTable.Add("UGC", "C");
            CodonTable.Add("CGC", "R");
            CodonTable.Add("AGC", "S");
            CodonTable.Add("GGC", "G");
            CodonTable.Add("UGA", "Stop");
            CodonTable.Add("CGA", "R");
            CodonTable.Add("AGA", "R");
            CodonTable.Add("GGA", "G");
            CodonTable.Add("UGG", "W");
            CodonTable.Add("CGG", "R");
            CodonTable.Add("AGG", "R");
            CodonTable.Add("GGG", "G");
        }

        public Protein EncodeProtein()
        {
            var proteinSymbols = new StringBuilder();

            for (var i = 0; i < Symbols.Length; i+=3)
            {
                if (CodonTable.ContainsKey(Symbols.Substring(i, 3)))
                {
                    var symbol = CodonTable[Symbols.Substring(i, 3)];

                    // Hard stop (cancel loop)?
                    if (symbol != "Stop")
                    {
                        proteinSymbols.Append(symbol);
                    }
                }
            }

            return new Protein(proteinSymbols.ToString());
        }

        public override bool Equals(object obj)
        {
            var rna = obj as Rna;

            if (rna == null)
            {
                return false;
            }

            return rna.Symbols == Symbols;
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
