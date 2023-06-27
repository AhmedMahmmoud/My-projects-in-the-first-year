using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compare_three_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // compare between Three numbers which one of them smallest than other numbers

            Console.WriteLine("Enter The First Number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Second Nember");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter The Third Number");
            int z = int.Parse(Console.ReadLine());

            int small = x;
            if (y < small)
                small = y;

            if (z < small)
                small = z;

            Console.WriteLine("smallest is {0}", small);

            Console.ReadKey();
        }
    }
}
