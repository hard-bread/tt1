using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = "клавиатура";
            var word1 = s.Remove(0, 4)
                         .Remove(2, 2);
            word1 = s.Substring(6, 1) + word1;

            Console.WriteLine(word1);

            var word2 = s
                .Remove(1, 6)
                .Remove(3, 1);

            char[] charArray = word2.ToCharArray();
            Array.Reverse(charArray);
            string reversedWord2 = new string(charArray);

            reversedWord2 = reversedWord2 + s.Substring(2, 1);

            Console.WriteLine(reversedWord2);

            Console.ReadKey();
        }
    }
}
