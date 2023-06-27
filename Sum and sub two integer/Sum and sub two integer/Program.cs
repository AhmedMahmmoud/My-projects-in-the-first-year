using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_and_sub_two_integer
{
        internal class Program
        {
            static void Main(string[] args)
            {
                int sum = 15;

                Console.WriteLine("select the sum or sub , 1 or -1 ");
                int summ = int.Parse(Console.ReadLine());
                if (summ > 0)
                {
                    Console.WriteLine(sum);
                }
                else
                {
                    int sub = 10;
                    Console.WriteLine(sub);
                }
                Console.ReadLine();
            }
        }
}
