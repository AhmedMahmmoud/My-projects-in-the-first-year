using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_if_else
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 1, y = 2;
            if (x > y)
            {
                Console.WriteLine(x);
            }
            else if (y < x)
            {
                Console.WriteLine(y);
            }
            Console.ReadLine();
        }
    }
}
