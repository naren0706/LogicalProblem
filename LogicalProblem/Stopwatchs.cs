using System;

namespace LogicalProblems
{
    public class Stopwatchs
    {

        const string START = "start", STOP = "stop";
        public static void GetTime() 
        {
            DateTime timeSpan1 = DateTime.Now;
            Console.WriteLine("Enter start to run the stop watch");
            string input = Console.ReadLine();

            if (input.ToLower().Equals(START))
            {
                int hour = timeSpan1.Hour;
                int min1 = timeSpan1.Minute;
                int sec1 = timeSpan1.Second;
                int millisec1 = timeSpan1.Millisecond;
                Console.WriteLine("Enter Stop to end the stop watch");
                DateTime timeSpan = DateTime.Now;
                string endInput = Console.ReadLine();
                if (endInput.ToLower().Equals(STOP))
                {
                    int hour2 = timeSpan.Hour;
                    int min2 = timeSpan.Minute;
                    int sec2 = timeSpan.Second;
                    int millisec2 = timeSpan.Millisecond;

                    Console.WriteLine((hour2 - hour) + ":" +(min2-min1)+":"+(sec2-sec1)+":"+(millisec2-millisec1));
                }
            }
        }            
    }
}