namespace LogicalProblems
{
    internal class DayOfDate
    {
        internal static void getDay()
        {
            Console.Write(" Input the Day : ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Input the Month : ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Input the Year : ");
            int year = Convert.ToInt32(Console.ReadLine());

            DateTime ss = new DateTime(date, month, year);

            Console.WriteLine(ss.DayOfWeek);
        }
    }
}