using System;

namespace ConditionalStatements1_25
{
    class Program
    {
        static void Main(string[] args)
        {
            //Excercise 2
            var isEvenOrOdd = int.Parse(Console.ReadLine());
            if (isEvenOrOdd % 2 == 0)
            {
                Console.WriteLine("number is even");
            }
            else
            {
                Console.WriteLine("number is odd");
            }

            //Exercise 8
            Console.Write("Input the 1st number :");
            var num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            var num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            var num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n\n");

            //Excercise 14
            Console.Write("Input side 1 of triangle: ");
            var sideA = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 2 of triangle: ");
            var sideB = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input side 3 of triangle: ");
            var sideC = Convert.ToInt32(Console.ReadLine());



            if (sideA == sideB && sideB == sideC)
            {
                Console.Write("This is an equilateral triangle.\n");
            }
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                Console.Write("This is an isosceles triangle.\n");
            }
            else
            {
                Console.Write("This is a scalene triangle.\n");
            }

            //Excercise 18
            double chg, surchg = 0, gramt, netamt;

            Console.Write("Input Customer ID :");
            var cusId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the name of the customer :");
            var cusName = Console.ReadLine();
            Console.Write("Input the unit consumed by the customer : ");
            var consumedU = Convert.ToInt32(Console.ReadLine());

            if (consumedU < 200)
                chg = 1.20;
            else if (consumedU >= 200 && consumedU < 400)
                chg = 1.50;
            else if (consumedU >= 400 && consumedU < 600)
                chg = 1.80;
            else
                chg = 2.00;

            gramt = consumedU * chg;
            if (gramt > 300)
                surchg = gramt * 15 / 100.0;
            netamt = gramt + surchg;
            if (netamt < 100)
                netamt = 100;

            Console.Write("\nElectricity Bill\n");
            Console.Write("Customer IDNO                       :{0}\n", cusId);
            Console.Write("Customer Name                       :{0}\n", cusName);
            Console.Write("unit Consumed                       :{0}\n", consumedU);
            Console.Write("Amount Charges @Rs. {0}  per unit :{1}\n", chg, gramt);
            Console.Write("Surchage Amount                     :{0}\n", surchg);
            Console.Write("Net Amount Paid By the Customer     :{0}\n", netamt);

            //Excercise 24
            int choice, radius, length, width, buttom, height;
            double area = 0;

            Console.Write("Input 1 for area of circle\n");
            Console.Write("Input 2 for area of rectangle\n");
            Console.Write("Input 3 for area of triangle\n");
            Console.Write("Input your choice : ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Input radius of the circle : ");
                    radius = Convert.ToInt32(Console.ReadLine());
                    area = 3.14 * radius * radius;
                    break;
                case 2:
                    Console.Write("Input length  of the rectangle : ");
                    length = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input  width of the rectangle : ");
                    width = Convert.ToInt32(Console.ReadLine());
                    area = length * width;
                    break;
                case 3:
                    Console.Write("Input the base of the triangle :");
                    buttom = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input the hight of the triangle :");
                    height = Convert.ToInt32(Console.ReadLine());
                    area = .5 * buttom * height;
                    break;
            }
            Console.Write("The area is : {0}\n", area);

            Console.ReadLine();
        }
    }
}
