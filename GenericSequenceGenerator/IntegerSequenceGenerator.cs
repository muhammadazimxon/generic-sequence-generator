namespace GenericSequenceGenerator
{
    public class IntegerSequenceGenerator : SequenceGenerator<int>
    {
        public IntegerSequenceGenerator()
            : base(1, 2)
        {
        }

        public IntegerSequenceGenerator(int first, int second)
            : base(first, second)
        {
        }

        public override int GetNext()
        {
            int next = (6 * this.Current) - (8 * this.Previous);
            this.UpdateState(next);
            return next;
        }
    }
}
