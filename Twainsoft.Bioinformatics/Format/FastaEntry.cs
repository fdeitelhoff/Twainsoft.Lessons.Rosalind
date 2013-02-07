namespace Twainsoft.Bioinformatics.Format
{
    public class FastaEntry
    {
        public string Label { get; private set; }
        public Dna Dna { get; private set; }

        public FastaEntry(string label, Dna dna)
        {
            Label = label;
            Dna = dna;
        }
    }
}
