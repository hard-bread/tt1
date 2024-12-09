using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace о5
{
    internal class Program
    {
        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        static void Main()
        {
            Console.WriteLine("Введите первое натуральное число:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе натуральное число:");
            int b = int.Parse(Console.ReadLine());

            int gcd = GCD(a, b);
            Console.WriteLine($"Наибольший общий делитель: {gcd}");
        }
    }
}
