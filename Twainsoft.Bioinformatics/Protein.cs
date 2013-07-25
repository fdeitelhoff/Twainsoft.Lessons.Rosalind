namespace Twainsoft.Bioinformatics
{
    public class Protein
    {
        public string Symbols { get; private set; }

        public Protein(string symbols)
        {
            Symbols = symbols;
        }

        public override bool Equals(object obj)
        {
            var dna = obj as Protein;

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
