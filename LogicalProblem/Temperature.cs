namespace LogicalProblems
{
    internal class Temperature
    {
        internal static void ConvertTemp()
        {
            Console.WriteLine("1.celcius to Fahrenheit:\n2.Fahrenheit to celcius:");
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice==1)
            {
                Console.WriteLine("Enter the value of celcius");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(input*(9/5)+32);
            }
            if(choice==2)
            {
                Console.WriteLine("Enter the valu of Fahrenheit");
                int input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine((input-32)*(5/9));
            }
        }
    }
}