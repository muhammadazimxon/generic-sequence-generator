namespace GenericSequenceGenerator
{
    public class DelegateSequenceGenerator<T> : SequenceGenerator<T>
    {
        private readonly Func<T, T, T> nextElementRule;

        public DelegateSequenceGenerator(T first, T second, Func<T, T, T> rule)
            : base(first, second)
        {
            this.nextElementRule = rule;
        }

        public override T GetNext()
        {
            var next = this.nextElementRule(this.Previous, this.Current);
            this.UpdateState(next);
            return this.Current;
        }
    }
}
