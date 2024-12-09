using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace o6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество сотрудников n:");
            int n = int.Parse(Console.ReadLine());

            double[,] salaries = new double[n, 3];
            int[] maxSalaryMonth = new int[n];
            double[] maxSalaryInMonths = new double[3];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Введите зарплату сотрудника {i + 1} за 3 месяца:");
                Console.WriteLine("ВВЕДИТЕ 3 ЗНАЧЕНИЯ ЧЕРЕЗ ENTER");
                for (int j = 0; j < 3; j++)
                {
                    salaries[i, j] = double.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < n; i++)
            {
                double maxSalary = salaries[i, 0];
                int monthIndex = 0;
                for (int j = 1; j < 3; j++)
                {
                    if (salaries[i, j] > maxSalary)
                    {
                        maxSalary = salaries[i, j];
                        monthIndex = j;
                    }
                }
                maxSalaryMonth[i] = monthIndex;
            }

            for (int j = 0; j < 3; j++)
            {
                double maxSalary = salaries[0, j];

                int employeeIndex = 0;
                for (int i = 0; i < n; i++)
                {
                    if (salaries[i, j] > maxSalary)
                    {
                        maxSalary = salaries[i, j];
                        employeeIndex = i;
                    }
                }
                maxSalaryInMonths[j] = maxSalary;
                Console.WriteLine($"Самая высокая зарплата в месяце {j + 1}: Сотрудник {employeeIndex + 1}, Зарплата: {maxSalary}");
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Сотрудник {i + 1} получал самую высокую зарплату в месяце {maxSalaryMonth[i] + 1}");
            }
        }
    }
}
