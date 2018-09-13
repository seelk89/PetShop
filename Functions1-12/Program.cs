using System;

namespace Functions1_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise 4
            var lineToCheck = Console.ReadLine();
            Console.WriteLine(NumberOfSpaces(lineToCheck));

            //Excercise 5
            int[] intArray = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Number {0}", i);
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(SumOfArray(intArray));

            //Excercise 8
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Fibonacci series of " + n + " numbers is :");

            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibo(i) + "  ");
            }
            Console.WriteLine();

            //Excercise 11
            Console.WriteLine("Number to factorial");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(Factorial(number));

            //Excercise 12
            Console.WriteLine("Number for Fibonacci sequence");
            var num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Fibonacci of {0} th term  is {1}", num, Fib(num));

            Console.ReadLine();
        }

        //Part of excercise 4
        public static int NumberOfSpaces(string lineToCheck)
        {
            int count = 0;

            for (int i = 0; i < lineToCheck.Length; i++)
            {
                var spaceCheck = lineToCheck.Substring(i, 1);
                if (spaceCheck == " ")
                {
                    count++;
                }
            }

            return count;
        }

        //Part of excercise 5
        public static int SumOfArray(int[] intArray)
        {
            int sum = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                sum += intArray[i];
            }

            return sum;
        }

        //Part of excercise 8
        public static int Fibo(int nno)
        {
            int num1 = 0;
            int num2 = 1;

            for (int i = 0; i < nno; i++)
            {
                int temp = num1;
                num1 = num2;
                num2 = temp + num2;
            }

            return num1;
        }

        //Part of excercise 11
        static decimal Factorial(int n1)
        {
            // The bottom of the recursion
            if (n1 == 0)
            {
                return 1;
            }

            // Recursive call: the method calls itself
            else
            {
                return n1 * Factorial(n1 - 1);
            }
        }

        //Part of excercise 12
        public static int Fib(int n1)
        {
            //if ( (n1 == 1) || (number == 2) )
            if (n1 <= 2)
                return 1;
            else
                return Fib(n1 - 1) + Fib(n1 - 2);
        }
    }
}
