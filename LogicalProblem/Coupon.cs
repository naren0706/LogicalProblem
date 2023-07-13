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
            string result = "";
            while (input > 0)
            {
                int r = random.Next(0, TOTAL_LENGTH);
                result += randomValues[r];
                input--;
            }
            Console.WriteLine(result);

        }
    }
}
