using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите значение x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double result = CalculateFunction(x);
            Console.WriteLine($"f(x) = {result}");
        }

        static double CalculateFunction(double x)
        {
            return (2 * Math.Cos(1 / (x * x + 2))) / (x * x * x + 1);
        }
    }

}
