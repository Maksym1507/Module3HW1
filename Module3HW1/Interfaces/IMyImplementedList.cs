using System.Collections.Generic;

namespace Module3HW1.Interfaces
{
    public interface IMyImplementedList<T> : IEnumerable<T>
    {
        public int Capacity { get; }

        public int Count { get; }

        public void Add(T item);

        public void AddRange(T[] collection);

        public bool Remove(T item);

        public void RemoveAt(int index);

        public void Sort();
    }
}
