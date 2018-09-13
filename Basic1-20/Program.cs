using System;

namespace Basic1_20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise 2
            Console.WriteLine(2 + 2);

            //Excercise 5
            Console.WriteLine("First number:");
            var firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Second number:");
            var secondNumber = int.Parse(Console.ReadLine());

            int temp = firstNumber;

            firstNumber = secondNumber;
            secondNumber = temp;

            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + firstNumber);
            Console.Write("\nSecond Number : " + secondNumber);

            Console.WriteLine("");

            //Excercise 12
            Console.WriteLine("Enter a digit: ");
            var num = int.Parse(Console.ReadLine());

            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);
            Console.Write(" ");
            Console.Write(num);

            Console.WriteLine();

            Console.Write(num);
            Console.Write(num);
            Console.Write(num);
            Console.WriteLine(num);

            Console.WriteLine();

            //Excercise 15
            Console.WriteLine(removeChar("w3resource", 1));
            Console.WriteLine(removeChar("w3resource", 9));
            Console.WriteLine(removeChar("w3resource", 0));

            //Excercise 17
            Console.WriteLine("Write a word:");

            var firstLetterAtFrontAndBack = Console.ReadLine();
            if (firstLetterAtFrontAndBack.Length > 1)
            {
                var firstLetter = firstLetterAtFrontAndBack.Substring(0, 1);
                Console.WriteLine(firstLetter + firstLetterAtFrontAndBack + firstLetter);
            }

            Console.ReadLine();
        }

        //Part of excercise 15
        public static string removeChar(string str, int n)
        {
            return str.Remove(n, 1);
        }
    }
}
