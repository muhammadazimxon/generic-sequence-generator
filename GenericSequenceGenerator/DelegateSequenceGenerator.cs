namespace GenericSequenceGenerator
{
    public delegate T SequenceRule<T>(T prev, T curr);

    public class DelegateSequenceGenerator<T> : SequenceGenerator<T>
    {
        private readonly SequenceRule<T> rule;

        public DelegateSequenceGenerator(T first, T second, SequenceRule<T> rule)
            : base(first, second)
        {
            this.rule = rule;
        }

        public override T GetNext()
        {
            return this.rule(this.Previous, this.Current);
        }
    }
}
