using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._11
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите значение x: ");
            double x;

            while (!double.TryParse(Console.ReadLine(), out x))
            {
                Console.Write("Некорректный ввод. Пожалуйста, введите числовое значение x: ");
            }

            double result = CalculateFunction(x);
            Console.WriteLine($"f({x}) = {result}");
        }

        static double CalculateFunction(double x)
        {
            double sinValue = Math.Sin(x);

            if (sinValue < -0.5)
            {
                return sinValue;
            }
            else if (sinValue <= 0.5)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}

