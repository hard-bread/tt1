using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "клавиатура";
            var word1 = s
            .Remove(5)
            .Remove(2, 2)
            .Remove(0, 1);

            word1 += s.Substring(6);
            Console.WriteLine(word1);

            var word2 = s
            .Remove(0, 5)
            .Remove(3);

            Console.WriteLine(word2);

            Console.ReadKey();
        }
    }
}
