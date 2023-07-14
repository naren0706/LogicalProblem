using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblem
{
    internal class Coupon
    {
        const int TOTAL_LENGTH = 36;
        static Random random = new Random();
        public static void GetCoupon()
        {
            char[] randomValues = "qwertyuiopasdfghjklzxcvbnm1234567890".ToCharArray();
            Console.WriteLine("Enter number of values in the coupon");
            int input = Convert.ToInt32(Console.ReadLine());
            string[] resultArray = new string[input];
            string result = "";
            int index = 0;
            while (input > 0)
            {
                int length = random.Next(7, 15);
                while (length > 0)
                {
                    int r = random.Next(0, TOTAL_LENGTH);
                    result += randomValues[r];
                    length--;
                }
            input--;
            resultArray[index++] = result;
                result = "";
    
            }

            foreach (var item in resultArray)
            {
                Console.WriteLine(item);
            }

        }
    }
}
