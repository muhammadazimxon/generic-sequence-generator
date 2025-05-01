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
            char next = (char)(((this.Current + this.Previous) % 26) + 65);
            this.UpdateState(next);
            return next;
        }
    }
}
