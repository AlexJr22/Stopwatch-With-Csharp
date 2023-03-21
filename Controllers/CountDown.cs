using System;

namespace Stopwatch_With_Csharp.Controllers
{
    public class CountDown
    {
        private static void CalculateTime()
        {
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

        private static void CalculateTime(int days, int month, int year)
        {
            while (true)
            {
                DateTime now = DateTime.Now;
                DateTime nextYear = new DateTime(year, month, days);

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

        public static void StartDefault()
        {
            Console.Clear();

            CalculateTime();
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

            Console.WriteLine("*=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=*");
            for (var lines = 0; lines < 7; lines++)
                Console.WriteLine("|                                 |");
            Console.WriteLine("*=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=*");

            Console.SetCursorPosition(9, 1);
            Console.Write("DIGITE UMA DATA");
            Console.SetCursorPosition(1, 2);
            Console.WriteLine("=================================");

            Console.SetCursorPosition(2, 4);
            Console.Write("DIA: ");
            short PersonDay = Convert.ToInt16(Console.ReadLine());

            Console.SetCursorPosition(2, 5);
            Console.Write("MÊS: ");
            short PersonMonth = Convert.ToInt16(Console.ReadLine());

            Console.SetCursorPosition(2, 6);
            Console.Write("ANO: ");
            short PersonYear = Convert.ToInt16(Console.ReadLine());

            CalculateTimePerson(PersonDay, PersonMonth, PersonYear);
        }

        private static void CalculateTimePerson(int days, int month, int year)
        {
            Console.Clear();
            if (year < DateTime.Now.Year)
                year = (short)DateTime.Now.Year;

            if (month > 12)
                month = 12;

            if (month < 1)
                month = 1;

            int DaysInMonth = DateTime.DaysInMonth(year, month);
            if (days > DaysInMonth)
                days = DaysInMonth;

            CalculateTime(days, month, year);
        }
    }
}
