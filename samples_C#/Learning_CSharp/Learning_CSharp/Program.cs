using System;

namespace Learning_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstInt = 5;
            var secondInt = 6; //Signed int, default
            int bigestInt = int.MaxValue;
            uint bigestPositiveInt = uint.MaxValue;

            Console.WriteLine(bigestInt + " " + bigestPositiveInt);
        }
    }
}
