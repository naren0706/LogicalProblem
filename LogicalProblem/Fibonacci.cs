using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    class Fibonacci
    {
        public static void Fib()
        {
            Console.WriteLine("Enter the value for creating fib");
            int input = Convert.ToInt32(Console.ReadLine());
            int term1 = 0,term2 = 1;
            Console.Write(term1+" "+term2+" ");
            for (int i = 0; i < input; i++)
            {
                int term3 = term1 + term2;
                Console.Write(term3+" ");
                term1 = term2;
                term2 = term3;


            }
        }
    }
}
