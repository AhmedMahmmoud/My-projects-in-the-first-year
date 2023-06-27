using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math.sqrt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             for (int i = 0; i < 10 ; i++)
             {
                 Console.WriteLine("Welcome to loop");

             }*/
            Console.WriteLine("enter the first number");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("enter the second number");
            int z = int.Parse(Console.ReadLine());

            for (int num = x; num >= z; num--)
            {
                Console.WriteLine(Math.Sqrt(num));
            }

            Console.ReadLine();

        }
    }
}
}
