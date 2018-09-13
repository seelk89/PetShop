using System;

namespace DataTypes1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise 2
            Console.WriteLine("Number:");
            var number = int.Parse(Console.ReadLine());

            Console.WriteLine("Width:");
            var width = int.Parse(Console.ReadLine());

            var height = width;

            for (int i = 0; i < height ; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(number);
                }

                Console.WriteLine();
                width--;
            }

            //Excercise 3
            var username = "";
            var password = "";

            var attempts = 0;
            var success = 0;

            do
            {
                Console.Write("Username: ");
                username = Console.ReadLine();

                Console.Write("Password: ");
                password = Console.ReadLine();

                if (username == "username" && password == "password")
                {
                    success = 1;
                }
                else
                {
                    attempts++;
                }
            } while ((username != "username" || password != "password") && (attempts != 3));
            {
                if (success == 0)
                {
                    Console.Write("Failure");
                }
                
                if (success == 1)
                {
                    Console.Write("Success");
                }
            }

            //Excercise 4
            int x, y;
            char operation;

            Console.Write("Input first number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input operation: ");
            operation = Convert.ToChar(Console.ReadLine());

            Console.Write("Input second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            //Calculations done here based on operation char
            if (operation == '+')
                Console.WriteLine("{0} + {1} = {2}", x, y, x + y);

            else if (operation == '-')
                Console.WriteLine("{0} - {1} = {2}", x, y, x - y);

            else if ((operation == 'x') || (operation == '*'))
                Console.WriteLine("{0} * {1} = {2}", x, y, x * y);

            else if (operation == '/')
                Console.WriteLine("{0} / {1} = {2}", x, y, x / y);

            else
                Console.WriteLine("Wrong Character");

            Console.ReadLine();
        }
    }
}
