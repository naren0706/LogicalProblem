namespace LogicalProblems
{
    internal class MonthltPayment
    {
        internal static void GetAmount()
        {
            Console.Write(" Input the principal : ");
            Double p = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Input the years : ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write(" Input the percent interest compounded : ");
            decimal R = Convert.ToDecimal(Console.ReadLine());            
            
            double r = Convert.ToDouble(Decimal.Divide(R, Convert.ToDecimal(1200)));  // r = R/(1200)
            double n = Convert.ToDouble(12) * y; // n = 12*y

            double divident = p * r;
            double divisor =1- Math.Pow(1 + r, -n);
            double result = divident/divisor;
            Console.WriteLine(result);


        }
    }
}