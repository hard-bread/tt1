using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace домашка777._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки (x, y):");
            Console.Write("x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            bool isInRegion = IsPointInRegion(x, y);
            Console.WriteLine(isInRegion ? "True" : "False");
        }
        static bool IsPointInRegion(double x, double y)
        {
            if (x >= -3 && x <= -1)
            {
                return true;
            }
            else
            {
                return y >= -2;
            }
        }
    }
}
