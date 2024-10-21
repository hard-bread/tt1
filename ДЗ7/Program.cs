using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите m");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите n");
            int n = Convert.ToInt32(Console.ReadLine());

            bool proverka = (m % 2 == 0) ^ (n % 2 == 0);

            Console.WriteLine(proverka);

            Console.ReadKey();
        }
    }
}
