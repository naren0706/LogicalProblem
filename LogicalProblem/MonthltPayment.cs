namespace LogicalProblems
{
    internal class MonthltPayment
    {
        internal static void GetAmount()
        {
            Console.Write(" Input the principal : ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Input the years : ");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Input the percent interest compounded : ");
            int r = Convert.ToInt32(Console.ReadLine());
            int n = 12 * y;
            double output = (p * r) / (1 - (Math.Pow((1+r),-n)) );
            Console.WriteLine("The output is :"+output);
        }
    }
}