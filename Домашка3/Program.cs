using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Домашка3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите 4-значное число: ");
            int number = int.Parse(Console.ReadLine());
            if (number < 1000 || number > 9999)
            
            Console.WriteLine("Введенное число: " + number);
            int originalNumber = number;
            int reversedNumber = 0;
            while (number > 0)
            {
                int digit = number % 10;
                reversedNumber = reversedNumber * 10 + digit;
                number /= 10;
            }
            Console.WriteLine("Обратное число: " + reversedNumber);
        }
    }
}
