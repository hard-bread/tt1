using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace массив
{
    using System;
    using System.Linq;

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите целое число n (<= 20): ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Введите вещественное число лямбда: ");
            double lambda = double.Parse(Console.ReadLine());

            double[] array = FillArray(n, lambda);
            Console.WriteLine("Исходный массив:");
            PrintArray(array);

            double[] cumSumArray = CumulativeSum(array);
            Console.WriteLine("Массив после замены каждого элемента на сумму всех предшествующих элементов:");
            PrintArray(cumSumArray);

            double sumAbsDiff = SumOfAbsoluteDifferences(array);
            Console.WriteLine($"Сумма абсолютных разностей между последовательными элементами: {sumAbsDiff:F3}");

            double[] diffWithLambda = DifferencesWithNumber(array, lambda);
            Console.WriteLine("Разности между элементами массива и числом лямбда:");
            PrintArray(diffWithLambda);
        }

        static double[] FillArray(int n, double lambda)
        {
            double[] arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Math.Pow(lambda, i* Math.Exp(-lambda) / Factorial(i));
            }
            return arr;
        }

        static void PrintArray(double[] arr)
        {
            Console.WriteLine(string.Join(" ", arr.Select(x => x.ToString("F3"))));
        }

        static double[] CumulativeSum(double[] arr)
        {
            double[] result = new double[arr.Length];
            result[0] = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                result[i] = result[i - 1] + arr[i];
            }
            return result;
        }

        static double SumOfAbsoluteDifferences(double[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                sum += Math.Abs(arr[i + 1] - arr[i]);
            }
            return sum;
        }

        static double[] DifferencesWithNumber(double[] arr, double a)
        {
            return arr.Select(x => x - a).ToArray();
        }

        static long Factorial(int n)
        {
            if (n == 0) return 1;
            long result = 1;
            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }
            return result;
        }
    }
}