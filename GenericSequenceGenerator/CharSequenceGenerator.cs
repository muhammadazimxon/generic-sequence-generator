namespace GenericSequenceGenerator
{
    public class CharSequenceGenerator : SequenceGenerator<char>
    {
        public CharSequenceGenerator()
            : base('A', 'B')
        {
        }

        public CharSequenceGenerator(char first, char second)
            : base(first, second)
        {
        }

        public override char GetNext()
        {
            int offsetPrev = this.Previous - 'A';
            int offsetCurr = this.Current - 'A';
            return (char)(((offsetPrev + offsetCurr) % 26) + 'A');
        }
    }
}
