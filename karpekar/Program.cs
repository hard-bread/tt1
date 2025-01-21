using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace karpekar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Числа, удовлетворяющие условию функции Капрекара: ");
            for (int j = 100; j <= 999999999; j++)
            {
                Kaprekar(j);
            }
        }

        public static void Kaprekar(int n)
        {
            char[] number = n.ToString().ToCharArray();

            Array.Sort(number);
            string minNumber = new string(number);
            Array.Reverse(number);
            string maxNumber = new string(number);

            int difference = int.Parse(maxNumber) - int.Parse(minNumber);
            if (n == difference)
            {
                Console.Write(n + " ");
            }
        }
    }
}

