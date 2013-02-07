using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Twainsoft.Bioinformatics.Format
{
    public class Fasta
    {
        private Regex FastaFormatRegex { get; set; }

        public Fasta()
        {
            FastaFormatRegex = new Regex(@">(?<Label>\w+)(\s*)(?<Sequence>[A-Za-z\s]+)", RegexOptions.Multiline);
        }

        public List<FastaEntry> ReadEntries(string file)
        {
            var text = File.ReadAllText(file, Encoding.Default);

            var matches = FastaFormatRegex.Matches(text);

            return (from Match match in matches select new FastaEntry(match.Groups["Label"].Value, 
                new Dna(match.Groups["Sequence"].Value.Replace(Environment.NewLine, "")))).ToList();
        }
    }
}
