using System;
using System.IO;
using System.Text;

namespace EncodingDisposalGarbageCollection
{
    public class EncodingExamples
    {
        public static void Show1()
        {
            const string str = "01234565789";

            var utf8Bytes = Encoding.UTF8.GetBytes(str);
            var utf16Bytes = Encoding.Unicode.GetBytes(str);
            var utf32Bytes = Encoding.UTF32.GetBytes(str);

            Console.WriteLine(utf8Bytes.Length);    // 10, 1 byte each char
            Console.WriteLine(utf16Bytes.Length);   // 20, 2 bytes each char
            Console.WriteLine(utf32Bytes.Length);   // 40, 4 bytes each char

            var original1 = Encoding.UTF8.GetString(utf8Bytes);
            var original2 = Encoding.Unicode.GetString(utf16Bytes);
            var original3 = Encoding.UTF32.GetString(utf32Bytes);

            Console.WriteLine(original1);   // 01234565789
            Console.WriteLine(original2);   // 01234565789
            Console.WriteLine(original3);   // 01234565789
        }

        public static void Show2()
        {
            const string unicodeStr = "This string contains the Unicode character Pi (\u03a0)";

            // Create two different encodings.
            var ascii = Encoding.ASCII;
            var unicode = Encoding.Unicode;
            
            // Convert the string into a byte array.
            var unicodeBytes = unicode.GetBytes(unicodeStr);

            // Perform the conversion from one encoding to the other.
            var asciiBytes = Encoding.Convert(unicode, ascii, unicodeBytes);

            // Convert the new byte[] into a string.
            var asciiString = ascii.GetString(asciiBytes);

            // Display the strings created before and after the conversion
            Console.WriteLine("Original string: {0}", unicodeStr);
            Console.WriteLine("ASCII converted string: {0}", asciiString);
        }

        public static void Show3()
        {
            var path = Path.GetFullPath(@"..\..\myFile.txt");

            var fs = new FileStream(path, FileMode.Open);
            
            const string str = "Hello world!";
            var bytes = Encoding.ASCII.GetBytes(str);
            var bytesCount = Encoding.ASCII.GetByteCount(str);

            fs.Write(bytes, 0, bytesCount);
            fs.Flush();
        }
    }
}