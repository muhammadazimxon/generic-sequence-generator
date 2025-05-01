namespace GenericSequenceGenerator
{
    public abstract class SequenceGenerator<T> : ISequenceGenerator<T>
    {
        protected SequenceGenerator(T first, T second)
        {
            this.Previous = first;
            this.Current = second;
            this.Count = 2;
        }

        public T Previous { get; protected set; }

        public T Current { get; protected set; }

        public int Count { get; private set; }

        public T Next => this.GetNext();

        public abstract T GetNext();

        protected void UpdateState(T newCurrent)
        {
            this.Previous = this.Current;
            this.Current = newCurrent;
            this.Count++;
        }
    }
}
