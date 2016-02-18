using System;

namespace GenericsAndCollections
{
    public static class NullableTypesExample
    {
        public static void Show()
        {
            int? i = 10;
            double? d1 = 3.14;
            bool? flag = DateTime.Now.Millisecond % 2 == 0 ? (bool?)null : true;
            char? letter = 'a';

            Console.WriteLine(i);
            Console.WriteLine(d1);

            if (flag.HasValue)
            {
                Console.WriteLine(flag);
            }

            Console.WriteLine(letter);
        }
    }
}