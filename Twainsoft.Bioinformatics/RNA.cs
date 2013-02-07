namespace Twainsoft.Bioinformatics
{
    public class Rna
    {
        private string Symbols { get; set; }

        public Rna(string symbols)
        {
            Symbols = symbols;
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
