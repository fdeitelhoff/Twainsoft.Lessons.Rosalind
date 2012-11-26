using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Twainsoft.Bioinformatics.Format
{
    public class Fasta
    {
        public List<FastaEntry> ReadEntries(string file)
        {
            var entries = new List<FastaEntry>();

            var text = File.ReadAllText(file, Encoding.Default);

            var regex = new Regex(@">(?<Label>\w+)(\s*)(?<Sequence>[A-Za-z\s]+)", RegexOptions.Multiline);
            var matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                entries.Add(new FastaEntry(match.Groups["Label"].Value, 
                    new DNA(match.Groups["Sequence"].Value.Replace(Environment.NewLine, ""))));
            }

            return entries;
        }
    }
}
