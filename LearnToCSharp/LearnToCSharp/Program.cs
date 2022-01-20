using System;

namespace LearnToCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 2147483647;

            Console.WriteLine(number);
            
            byte a = 255;
            Console.WriteLine(a);

            uint x = 4294967295;
            Console.WriteLine(x);

            double c = 25.5655;
            Console.WriteLine(c);

            char f = 'a';
            Console.WriteLine(f);

            var textual = "This is string value";
            Console.WriteLine(textual);

            var digital = 56546;
            Console.WriteLine("This is digital value, ",digital);
        }
    }
}
