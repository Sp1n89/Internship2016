using System;

namespace GenericsAndCollections.GenericsExamples
{
    public class GenericStack<T> where T : class
    {
        public const int MaxSize = 50;

        private int Index { get; set; }

        private readonly T[] _items;

        public GenericStack()
        {
            _items = new T[MaxSize];
            Index = 0;
        }

        public void Push(T item)
        {
            if (Index >= MaxSize)
            {
                throw new InvalidOperationException("Stack is full!");
            }

            _items[Index] = item;
            Index++;
        }

        public T Pop()
        {
            Index--;
            if (Index >= 0)
            {
                return _items[Index];
            }

            Index = 0;
            throw new InvalidOperationException("Stack is empty!");
        }
    }
}