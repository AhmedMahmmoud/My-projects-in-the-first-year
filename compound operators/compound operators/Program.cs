using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace compound_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
              int x = 30;


            x += 10;
            Console.WriteLine(" Add assignment :"+x);

            x -= 5;
            Console.WriteLine(" sub assignment:" +x);

            x /= 10;
            Console.WriteLine(" div assignment:" +x);

            x *= 3;
            Console.WriteLine(" mul assignment :" + x);

            x %=5;
            Console.WriteLine(" mod assignment:" + x);

            x &= 10;
            Console.WriteLine(" Bitwise operator :" +x);

            x ^= 12;
            Console.WriteLine(" Bitwise XOR:" +x);

            x >>= 3;
            Console.WriteLine(" Right shift assignment :" + x);

            x <<= 2;
            Console.WriteLine(" Left shift assignment :" + x);

            Console.ReadKey();
        }
    }
}
