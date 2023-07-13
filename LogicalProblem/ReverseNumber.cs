using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class ReverseNumber
    {
        public static void Reverse()
        {
            Console.WriteLine("Enter the number to reverse");
            int input = Convert.ToInt32(Console.ReadLine());
            int temp = input;
            int result = 0;
            while(temp > 0) 
            {
                int last = temp % 10;
                temp=temp / 10;
                result = (result*10)+last;

            }
            Console.WriteLine(result);
        }
    }
}
