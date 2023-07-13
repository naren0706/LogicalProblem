using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    class PerfectNumber
    {
        public static void IsPerfect()
        {
            Console.WriteLine("Enter the number ");
            int input = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = 1; i < Convert.ToInt32(Math.Sqrt(input)); i++)
            {
                if (input % i == 0)
                {
                    sum += i + Convert.ToInt32(input / i);
                }
            }
            if(input==sum-input)
            {
                Console.WriteLine("it is a Perfect number ");
            }
            else { 
                Console.WriteLine("It is not a perfect number");
            }
        }
    }
}
