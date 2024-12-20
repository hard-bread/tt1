using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array = { 
                { 1, 2, 3 },
                { 44, 5, 6 },
                { 7, 8, 9 } };
            CheckColumnOrder(array);
        }
        static void CheckColumnOrder(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            for (int col = 0; col < cols; col++)
            {
                for (int row = 1; row < rows; row++)
                {
                    if (array[row, col] < array[row - 1, col])
                    {
                        Console.WriteLine($"Порядок нарушен: строка {row}, столбец {col}");
                        return;
                    }
                }
            }
            Console.WriteLine("Столбцы массива упорядочены по возрастанию.");
        }
    }
}
