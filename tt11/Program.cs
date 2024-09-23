using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Буря");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Буря мглою небо кроет");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Вихри снежные крутя");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("То как зверь она завоет");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("То заплачет как дитя");

            Console.ResetColor();
            
            Console.ReadKey();
        }
    }
}
