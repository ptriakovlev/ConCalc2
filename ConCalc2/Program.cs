using System;

namespace ConCalc2
{
    class Program
    {
        public static void Main()
        {
            string expr;

            Calculator.Library.Calculator p = new Calculator.Library.Calculator();

            Console.WriteLine("Enter an empty expression to stop.");

            for (; ; )
            {
                Console.Write("Enter expression: ");
                expr = Console.ReadLine();
                if (expr == "") break;
                Console.WriteLine("Result: " + p.Evaluate(expr));
            }
        }
    }
}
