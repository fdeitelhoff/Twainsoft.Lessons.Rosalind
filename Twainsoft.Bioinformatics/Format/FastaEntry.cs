using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Twainsoft.Bioinformatics.Format
{
    public class FastaEntry
    {
        public string Label { get; private set; }
        public DNA DNA { get; private set; }

        public FastaEntry(string label, DNA dna)
        {
            Label = label;
            DNA = dna;
        }
    }
}
