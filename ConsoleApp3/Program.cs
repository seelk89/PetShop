using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Error somewhere
            Console.WriteLine("String to parse to int: ");
            string inputString = Console.ReadLine();
            int inputAsInt;

            while (int.TryParse(inputString, out inputAsInt));
            {
                Console.WriteLine("Thats not an int, try again: ");
                inputString = Console.ReadLine();
            }

            Console.WriteLine(inputAsInt);

            Console.ReadLine();
        }
    }
}
