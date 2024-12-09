using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace о1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите действительное число x:");
            double x = double.Parse(Console.ReadLine());

            double sum = 0.0;

            for (int i = 0; i <= n; i++)
            {
                sum += (double)(i + 1) / (i + 2) * Math.Pow(x, i);
            }

            Console.WriteLine($"Сумма: {sum}");
        }
    }
}
