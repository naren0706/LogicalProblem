using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class PrimeNumber
    {
        public static void IsPrime()
        {
            Console.WriteLine("Enter a number to find prime or not ");
            int input = Convert.ToInt32(Console.ReadLine());
            bool flag = true;
            for(int i = 2; i <= Convert.ToInt32(Math.Sqrt(input))+1; i++)
            {
                if(input%i == 0)
                {
                    flag = false;
                    break;
                }
                
            }
            if(flag)
            {
                Console.WriteLine("Prime Number");
            }
            else 
            {
                Console.WriteLine("Not a prime number");
            }
        }
    }
}
