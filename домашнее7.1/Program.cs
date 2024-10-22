using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace домашнее7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число m:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе целое число n:");
            int n = Convert.ToInt32(Console.ReadLine());
            bool onlyOneEven = (m % 2 == 0) ^ (n % 2 == 0);

            Console.WriteLine(onlyOneEven);
        }
    }
}