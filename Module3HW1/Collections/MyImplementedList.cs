using System;
using System.Collections;
using System.Collections.Generic;
using Module3HW1.Interfaces;

namespace Module3HW1.Collections
{
    public class MyImplementedList<T> : IMyImplementedList<T>
    {
        public int Capacity { get; set; }

        public int Count { get; set; }

        private T[] List { get; set; } = Array.Empty<T>();

        public void Add(T item)
        {
            if (Count == Capacity)
            {
                IncreaseCapacity();
            }

            List[Count] = item;
            Count++;
        }

        public void AddRange(T[] collection)
        {
            for (int i = 0; i < collection.Length; i++)
            {
                if (Count == Capacity)
                {
                    IncreaseCapacity();
                }

                List[Count] = collection[i];
                Count++;
            }
        }

        public bool Remove(T item)
        {
            bool deletionState = true;

            int index = Array.IndexOf(List, item);

            if (index != -1)
            {
                RemoveAt(index);
            }
            else
            {
                deletionState = false;
            }

            return deletionState;
        }

        public void RemoveAt(int index)
        {
            if (index >= Count || index < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            Count--;

            int oldListIndex = 0;

            for (int i = 0; i < Count; i++)
            {
                if (i != index)
                {
                    List[i] = List[oldListIndex];
                }
                else
                {
                    List[i] = List[++oldListIndex];
                }

                oldListIndex++;
            }
        }

        public void Sort()
        {
            Array.Sort(List, 0, Count);
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return new MyImplementedListEnumerator<T>(List, Count);
        }

        public void IncreaseCapacity()
        {
            if (Capacity == 0)
            {
                Capacity = 4;
            }
            else
            {
                Capacity *= 2;
            }

            T[] newList = new T[Capacity];

            for (int i = 0; i < List.Length; i++)
            {
                newList[i] = List[i];
            }

            List = newList;
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
