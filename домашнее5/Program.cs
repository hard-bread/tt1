using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace домашнее5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double y = Func(3, 5)*Func(3, 7)*Func(5, 5);

            Console.WriteLine("x = " + Math.Round(y, 3));

            Console.ReadKey();
        }
        static double Func(double a, double b)
        {
            return (Math.Sin(a) + Math.Sqrt(a)) / (Math.Cos(b) + Math.Sqrt(b));
        }
    }
}

