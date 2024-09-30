using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace домашка2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите длину стороны квадрата: ");
            double side = Convert.ToDouble(Console.ReadLine());

            double perimeter = 4 * side;
            double area = side * side;

            Console.WriteLine("Сторона квадрата: " + side);
            Console.WriteLine("Периметр квадрата: " + perimeter);
            Console.WriteLine("Площадь квадрата: " + area);

            Console.ReadKey();
        }
    }
}
