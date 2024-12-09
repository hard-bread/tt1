using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите натуральное число n:");
            int n = int.Parse(Console.ReadLine());
            double product = 1.0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите число a_{i + 1}:");
                double a = double.Parse(Console.ReadLine());
                product *= a;
            }

            Console.WriteLine($"Произведение: {product}");
        }
    }
}
