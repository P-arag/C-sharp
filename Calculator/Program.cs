using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first operand:- ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\nEnter the second operand:- ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEnter the operator:- ");
            char myOperator = Convert.ToChar(Console.ReadLine());

            if (myOperator == '+')
            {
                Console.WriteLine("The Sum is:- " + (a + b));
            }
            else if (myOperator == '-')
            {
                Console.WriteLine("The Difference is:- " + (a - b));
            }
            else if (myOperator == '*')
            {
                Console.WriteLine("The Product is:- " + (a * b));
            }
            else if (myOperator == '/')
            {
                Console.WriteLine("The Quotient is:- " + (a / b));
            }

            Console.ReadKey();

        }
    }
}
