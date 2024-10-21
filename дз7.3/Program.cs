using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз7._3
{
    internal class Program
    {
        static void Main()
        {
            string whitePosition, blackPosition, movePosition;

            Console.WriteLine("Введите позицию белого коня (например, e4): ");
            whitePosition = Console.ReadLine();

            Console.WriteLine("Введите позицию черного ферзя (например, d5): ");
            blackPosition = Console.ReadLine();


            // Проверка на корректность позиций
            if (!IsValidPosition(whitePosition) || !IsValidPosition(blackPosition) || whitePosition == blackPosition)
            {
                Console.WriteLine("Некорректные позиции фигур.");
                return;
            }

            bool IsValidPosition(string position)
            {
                return position.Length == 2 &&
                       position[0] >= 'a' && position[0] <= 'h' &&
                       position[1] >= '1' && position[1] <= '8';
            }
            Console.WriteLine("Введите позицию, куда хотите сходить белым конем (например, d5): ");
            movePosition = Console.ReadLine();
        }
    }
}
