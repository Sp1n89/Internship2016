using System;
using System.Collections.Generic;
using DesignPatterns.Observer.Example2;
using DesignPatterns.Observer.Example3;
using DesignPatterns.Strategy;
using DesignPatterns.TemplateMethod;
using DesignPatterns.Visitor.Example2;

namespace DesignPatterns
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Observer Example 1

            //var subject = new Subject();
            //var ob1 = new Observer("Observer_1", subject);
            //var ob2 = new Observer("Observer_2", subject);

            //subject.Attach(ob1);
            //subject.Attach(ob2);

            //subject.State = "UPDATED!!!";

            #endregion

            #region Observer Example 2

            //            var youtubeChannel = new YouTubeChannel();
            //            var youtubeClient = new Client("Rami");
            //            var admin = new ChannelAdmin("John");
            //
            //            youtubeChannel.Subscribe(youtubeClient);
            //            youtubeChannel.Subscribe(admin);
            //
            //            youtubeChannel.LastVideo = "C# Design Patterns";

            #endregion

            #region Observer Example 3

            //                        var blog = new Blog();
            //                        var admin = new BlogAdmin(blog);
            //                        var client = new BlogSubscriber(blog);
            //            
            //                        blog.State = "new state";

            #endregion

            #region Strategy

            //            var sortedList = new SortedList();
            //            sortedList.Add("John Doe");
            //            sortedList.Add("Tommy Toe");
            //            sortedList.Add("John Smith");
            //
            //            sortedList.SetSortStrategy(new QuickSort());
            //            sortedList.Sort();
            //
            //            Console.WriteLine(sortedList);

            #endregion

            #region Template Method

            //            Device mobile = new MobilePhone();
            //            Device laptop = new Laptop();
            //
            //            mobile.SendEmail("client_1@mail.com", "client_2@mail.com", "Hello", "How are you?");
            //            laptop.SendEmail("client_2@mail.com", "client_1@mail.com", "Good", "Good. Thank you!");

            #endregion

            #region Count Visitor

            //            var c = new VisitorClient();
            //            Console.WriteLine("1. Count Visitor");
            //            var countVisitor = new CountVisitor();
            //            countVisitor.CountElements(c.ObjectStructure);
            //            Console.WriteLine("Number of elements is: {0}", countVisitor.Count);
            //            Console.WriteLine();

            #endregion

            #region Display Names Visitor

            // Console.WriteLine("2. Display Names Visitor");
            // var displayNameVisitor = new DisplayNameVisitor();
            // displayNameVisitor.DisplayElementsNames(client.ObjectStructure);
            // Console.WriteLine("Elements are: {0}", displayNameVisitor.Output);
            // Console.WriteLine();

            #endregion

            #region Visitor Example 2

            var book = new Book("C# Design Patterns", 25);
            var fruit = new Fruit("Oranges", 6, 3);
//            var items = new List<IItem>();
//            items.Add(book);
//            items.Add(fruit);

            var priceVisitor = new PriceCalculatorVisitor();
            book.Accept(priceVisitor);
            fruit.Accept(priceVisitor);

            Console.WriteLine(priceVisitor.Total);

            #endregion



            Console.ReadLine();
        }
    }
}
