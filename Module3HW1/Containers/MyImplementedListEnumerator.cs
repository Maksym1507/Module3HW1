using System;
using System.Collections;
using System.Collections.Generic;

namespace Module3HW1
{
    public class MyImplementedListEnumerator<T> : IEnumerator<T>
    {
        public MyImplementedListEnumerator(T[] list, int count)
        {
            List = list;
            Count = count;
        }

        public int Count { get; }

        public T Current
        {
            get
            {
                return List[Position];
            }
        }

        object IEnumerator.Current => throw new NotImplementedException();

        private T[] List { get; }

        private int Position { get; set; } = -1;

        public void Dispose()
        {
        }

        public bool MoveNext()
        {
            if (Position < Count - 1)
            {
                Position++;
                return true;
            }

            return false;
        }

        public void Reset()
        {
            Position = -1;
        }
    }
}
