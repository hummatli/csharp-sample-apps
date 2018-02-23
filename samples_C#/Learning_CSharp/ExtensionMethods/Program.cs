using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var word = "Hello World!, Hi developere of the world";
            var count = word.WordCount();
            Console.WriteLine("Word Count " + count);
        }
    }
}
