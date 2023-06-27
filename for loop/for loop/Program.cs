using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int y = 0;
            for (int i = 0; i < 10; i++)
            {
                y += i;

                Console.WriteLine(y);
            }
            //Console.WriteLine(y); 
            Console.ReadLine();
        }
    }
}
