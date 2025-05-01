namespace GenericSequenceGenerator
{
    public class FibonacciSequenceGenerator : SequenceGenerator<int>
    {
        public FibonacciSequenceGenerator()
            : base(0, 1)
        {
        }

        public FibonacciSequenceGenerator(int first, int second)
            : base(first, second)
        {
        }

        public override int GetNext()
        {
            return this.Previous + this.Current;
        }
    }
}
