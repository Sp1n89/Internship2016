using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading;

namespace EncodingDisposalGarbageCollection
{
    internal class Program
    {
        private static void Main(string[] args)
        {
//            StringBuilder sb = new StringBuilder("Good morning");
//            sb.AppendLine();
//            sb.Append("hello");
//            sb.AppendLine();
//            sb.AppendFormat("{0}", "AMDARIS");
//            sb.Insert(4, "TEST INSERT");
//            sb.Remove(0, 4);
//            sb.Replace("AMDARIS", "ALL");
//            string str = sb.ToString();
//
//            Console.WriteLine(str);


//            for(var i = 0; i < 128; i++)
//                Console.WriteLine(string.Format("{0} - {1}", i, (char)i));

//            string s = "0123456789";
//
//            byte[] bytes = Encoding.UTF8.GetBytes(s);
//            Console.WriteLine(bytes.Length);
//
//            byte[] b2 = Encoding.Convert(Encoding.UTF8, Encoding.UTF32, bytes);
//
//            string result = Encoding.UTF32.GetString(b2);
//            Console.WriteLine(result);

//            TimeSpan t = TimeSpan.FromDays(1);
            
//            Console.WriteLine(t.Hours);

//            DateTime dt = new DateTime(2016, 2, 15);
//            Console.WriteLine(dt);
//
//            DateTime now = DateTime.Now;
//            DateTime utc = DateTime.UtcNow;
//            DateTime today = DateTime.Today;
//
//            Console.WriteLine(now);
//            Console.WriteLine(utc);
//            Console.WriteLine(today);
//
//            // Add
//            DateTime before2days = now.Add(TimeSpan.FromDays(2));
//            Console.WriteLine(before2days);

//            DateTimeOffset offset = new DateTimeOffset(2016, 3, 2, 11, 30, 10, TimeSpan.FromHours(2));
//            Console.WriteLine(offset);

//            DateTime dt = DateTime.Now;
//            Console.WriteLine(dt.Kind);
//            DateTime.SpecifyKind(dt, DateTimeKind.Unspecified);
//
//            DateTimeOffset nowOffset = new DateTimeOffset(dt);
//            Console.WriteLine("DateTime:" + dt); 
//            Console.WriteLine("DateTimeOffset:" + nowOffset); 

//            TimeZone zone = TimeZone.CurrentTimeZone;
//            Console.WriteLine(zone.StandardName);
//            Console.WriteLine(zone.DaylightName);
//
//            CultureInfo invariant = CultureInfo.InvariantCulture;
//            Console.WriteLine(50.ToString("C", invariant));
//
//            Console.WriteLine(DateTime.Now.ToString(invariant));

//            Console.WriteLine(123456789.6565.ToString("n1"));

            using (FileStream f = new FileStream("test.txt", FileMode.Open))
            {
                var s = "test string";
                var bytes = Encoding.ASCII.GetBytes(s);
                var bytesCount = Encoding.ASCII.GetByteCount(s);

                f.Write(bytes, 0, bytesCount);
                f.Flush();
//                f.Dispose();
            }

            Console.ReadLine();
        }
    }
}
