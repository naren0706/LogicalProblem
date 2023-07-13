using LogicalProblem;
using System;
namespace LogicalProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input :");
            Console.WriteLine("1.Fibonacci series");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {    
                case 1:
                    Fibonacci.Fib();
                    break;
                default:
                    break;

            }
        }
    }
}