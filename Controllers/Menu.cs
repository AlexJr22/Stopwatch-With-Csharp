using System;

namespace Stopwatch_With_Csharp.Controllers
{
    public class Menu
    {
        public static void Show()
        {
            Console.Clear();

            Console.WriteLine("*=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=*");
            for (var lines = 0; lines < 9; lines++)
                Console.WriteLine("|                                 |");
            Console.WriteLine("*=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=*");

            HandleOptions();
            ReadOptions();
        }

        private static void HandleOptions()
        {
            Console.SetCursorPosition(9, 1);
            Console.Write("ESCOLHA UMA OPÇÃO");
            Console.SetCursorPosition(1, 2);
            Console.WriteLine("=================================");

            Console.SetCursorPosition(2, 4);
            Console.WriteLine("[1] - Próximo ano");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("[2] - Data personalizada");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("[0] - Sair");
        }

        private static void ReadOptions()
        {
            Console.SetCursorPosition(2, 8);
            Console.Write("OPÇÃO: ");
            short Option;
            try
            {
                Option = Convert.ToInt16(Console.ReadLine());
            }
            catch
            {
                Option = 0;
            }
        }
    }
}
