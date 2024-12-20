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
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            SummaRows(array);
        }

        static void SummaRows(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            for (int row = 0; row < rows; row++)
            {
                int sum = 0;
                for (int col = 0; col < cols; col++)
                {
                    if (array[row, col] % 2 == 0)
                    {
                        sum += array[row, col];
                    }
                }
                Console.WriteLine($"Сумма четных элементов строки {row}: {sum}");
            }
        }
    }
}
