using System;

namespace Stopwatch_With_Csharp.Controllers
{
    public class CountDown
    {
        public static void StartDefault()
        {
            Console.Clear();
            while (true)
            {
                DateTime now = DateTime.Now;
                DateTime nextYear = new DateTime((now.Year + 1), 01, 01);

                TimeSpan Diff = nextYear - now;
                long totalSeconds = (long)Diff.TotalSeconds;

                int Seconds = (int)totalSeconds % 60;

                int Minutes = (int)totalSeconds / 60;
                int ResMinutes = (int)(totalSeconds / 60) % 60;

                int Hours = (int)Minutes / 60;
                int RestHours = (int)(Minutes / 60) % 24;

                int Days = (int)Hours / 24;

                Console.Clear();
                Console.WriteLine("Ctrl + C para encerrar a aplicação!");
                Console.WriteLine();
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-");
                Console.WriteLine($" D:{Days} H:{RestHours} M:{ResMinutes} S:{Seconds}");
                Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-");

                Thread.Sleep(1000);
            }
        }

        public static void StartPerson()
        {
            Console.Clear();
            Console.WriteLine("StopWacht Person");
        }
    }
}
