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

        public T Next
        {
            get
            {
                T next = this.GetNext();
                this.Previous = this.Current;
                this.Current = next;
                this.Count += 1;
                return next;
            }
        }

        public abstract T GetNext();
    }
}
