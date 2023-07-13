using LogicalProblem;
using System;
namespace LogicalProblems
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the input :");
            Console.WriteLine("1.Fibonacci series\n 2. PerfectNumber\n 3.PrimeNUmber");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {    
                case 1:
                    Fibonacci.Fib();
                    break;
                case 2:
                    PerfectNumber.IsPerfect();
                    break;
                case 3:
                    PrimeNumber.IsPrime();
                    break;
                default:
                    break;

            }
        }
    }
}