using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace шахматы
{
    class Program
    {
        static void Main()
        {
            // Ввод координат белого коня и черного ферзя
            Console.Write("Введите координаты белого коня (например, a1): ");
            string knightPosition = Console.ReadLine();

            Console.Write("Введите координаты черного ферзя (например, a1): ");
            string queenPosition = Console.ReadLine();

            // Проверка корректности позиций фигур
            if (!IsValidPosition(knightPosition) || !IsValidPosition(queenPosition))
            {
                Console.WriteLine("Координаты должны быть в пределах a1-h8 и не совпадать.");
                return;
            }

            if (knightPosition == queenPosition)
            {
                Console.WriteLine("Фигуры не могут стоять на одной клетке.");
                return;
            }

            // Проверка на возможность атаки
            if (CanAttackByKnight(knightPosition, queenPosition))
            {
                Console.WriteLine("Белый конь может атаковать черного ферзя.");
            }
            else
            {
                Console.WriteLine("Белый конь не может атаковать черного ферзя.");
            }

            if (CanAttackByQueen(queenPosition, knightPosition))
            {
                Console.WriteLine("Белый конь может быть атакован черным ферзем.");
            }
            else
            {
                Console.WriteLine("Белый конь не может быть атакован черным ферзем.");
            }

            // Ввод предполагаемого хода белого коня
            Console.Write("Введите координаты предполагаемого хода белого коня: ");
            string knightMove = Console.ReadLine();

            if (IsValidPosition(knightMove) && knightMove != queenPosition)
            {
                if (CanAttackByQueen(queenPosition, knightMove))
                {
                    Console.WriteLine("После хода на " + knightMove + " белый конь будет под атакой черного ферзя.");
                }
                else
                {
                    Console.WriteLine("После хода на " + knightMove + " белый конь не будет под атакой черного ферзя.");
                }
            }
            else
            {
                Console.WriteLine("Координаты предполагаемого хода неверны или совпадают с координатами черного ферзя.");
            }
        }

        static bool IsValidPosition(string position)
        {
            if (position.Length != 2) return false;
            char column = position[0];
            char row = position[1];
            return column >= 'a' && column <= 'h' && row >= '1' && row <= '8';
        }

        static bool CanAttackByKnight(string knightPosition, string queenPosition)
        {
            (int kx, int ky) = PositionToCoordinates(knightPosition);
            (int qx, int qy) = PositionToCoordinates(queenPosition);

            int[,] knightMoves = new int[,]
            {
                {-2, -1}, {-2, 1}, {2, -1}, {2, 1}, // Два вверх
                {-1, -2}, {-1, 2}, {1, -2}, {1, 2}  // Два вбок
            };

            for (int i = 0; i < knightMoves.GetLength(0); i++)
            {
                int moveX = knightMoves[i, 0];
                int moveY = knightMoves[i, 1];

                if (kx + moveX == qx && ky + moveY == qy)
                {

                    return true;
                }
            }
            return false;
        }

        static bool CanAttackByQueen(string queenPosition, string knightPosition)
        {
            (int qx, int qy) = PositionToCoordinates(queenPosition);
            (int kx, int ky) = PositionToCoordinates(knightPosition);

            // Условие для проверки атаки ферзя
            return qx == kx || qy == ky || Math.Abs(qx - kx) == Math.Abs(qy - ky);
        }

        static (int, int) PositionToCoordinates(string position)
        {
            char column = position[0];
            char row = position[1];
            int x = column - 'a' + 1;
            int y = row - '1' + 1;
            return (x, y);
        }
    }
}