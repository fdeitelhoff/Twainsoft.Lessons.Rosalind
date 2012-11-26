using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twainsoft.Bioinformatics
{
    public class RNA
    {
        public string Symbols { get; private set; }

        public RNA(string symbols)
        {
            Symbols = symbols;
        }

        public override bool Equals(object obj)
        {
            RNA rna = obj as RNA;

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
            return Symbols.ToString();
        }
    }
}
