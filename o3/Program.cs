using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a (1 < a < 1,5): ");
            Console.WriteLine("Например, 1,2. ДРОБНАЯ ЧАСТЬ ОТДЕЛЕТСЯ ЗАПЯТОЙ, А НЕ ТОЧКОЙ");
            double a = double.Parse(Console.ReadLine());
            int n = 1;

            while (1 + 1.0 / n >= a)
            {
                Console.WriteLine(n); n++;
            }
        }
    }
}