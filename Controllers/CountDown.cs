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

                int RestSeconds = (int)totalSeconds % 60;

                int Minutes = (int)totalSeconds / 60;
                int RestMinutes = Minutes % 60;

                int Hours = (int)Minutes / 60;
                int RestHours = Hours % 24;

                int Days = (int)Hours / 24;

                HandleTimer(Days, RestHours, RestMinutes, RestSeconds);
            }
        }

        private static void HandleTimer(int days, int hours, int minutes, int secnds)
        {
            Console.Clear();
            Console.WriteLine("Ctrl + C para encerrar a aplicação!");
            Console.WriteLine();
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-");
            Console.WriteLine($" D:{days} H:{hours} M:{minutes} S:{secnds}");
            Console.WriteLine("-=-=-=-=-=-=-=-=-=-=-");

            Thread.Sleep(1000);
        }

        public static void StartPerson()
        {
            Console.Clear();
            Console.WriteLine("StopWacht Person");
        }
    }
}
