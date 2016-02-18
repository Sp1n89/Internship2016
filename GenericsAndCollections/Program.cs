using System;
using System.Collections.Generic;
using GenericsAndCollections.GenericsExamples;

namespace GenericsAndCollections
{
    internal class Person
    {
        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public string Firstname { get; set; }

        public string Lastname { get; set; }
        
        public override int GetHashCode()
        {
            return (Firstname + ";" + Lastname).GetHashCode();
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            
            Dictionary<Person, int> marks = new Dictionary<Person, int>();

            var p1 = new Person("John", "Doe");

            var p2 = new Person("Tommy", "Toe");

            marks.Add(p1, 10);
            marks.Add(p2, 5);

            p1.Lastname = "UPDATED";

            Console.WriteLine(marks[p1]);


            Console.ReadLine();
        }
    }
}
