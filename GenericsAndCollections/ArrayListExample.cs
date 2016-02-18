using System;
using System.Collections;

namespace GenericsAndCollections
{
    public static class ArrayListExample 
    {
        public static void Show()
        {
            var arrayList = new ArrayList { "Hello", "World", "!", 15 };
            arrayList.Add(2);

            foreach (var item in arrayList)
            {
                Console.Write(" " + item);
            }
        }
    }
}