using System;

namespace GenericsAndCollections.GenericsExamples
{
    public class Stack
    {
        public const int MaxSize = 50;

        private int Index { get; set; }

        private readonly object[] _items;

        public Stack()
        {
            _items = new object[MaxSize];
            Index = 0;
        }

        public void Push(object item)
        {
            if (Index >= MaxSize)
            {
                throw new InvalidOperationException("Stack is full!");
            }

            _items[Index] = item;
            Index++;
        }

        public object Pop()
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