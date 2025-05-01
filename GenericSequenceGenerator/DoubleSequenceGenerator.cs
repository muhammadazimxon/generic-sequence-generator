namespace GenericSequenceGenerator
{
    public class DoubleSequenceGenerator : SequenceGenerator<double>
    {
        public DoubleSequenceGenerator()
            : base(1.0, 2.0)
        {
        }

        public DoubleSequenceGenerator(double first, double second)
            : base(first, second)
        {
        }

        public override double GetNext()
        {
            double next = this.Current + (this.Previous / this.Current);
            this.UpdateState(next);
            return next;
        }
    }
}
