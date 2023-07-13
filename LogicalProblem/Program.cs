using LogicalProblem;
using System;
namespace LogicalProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input :");
            Console.WriteLine("1.Fibonacci series\n 2. PerfectNumber");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {    
                case 1:
                    Fibonacci.Fib();
                    break;
                case 2:
                    PerfectNumber.IsPerfect();
                    break;
                default:
                    break;

            }
        }
    }
}