using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your name");

            string name = Console.ReadLine();

            bool nameContainsL = name.Contains("l");
            Console.WriteLine("Name contains l " + nameContainsL);

            Console.WriteLine("Hey " + name);

            //Makes console stay open
            Console.ReadLine();
        }
    }
}
