using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arthmatic_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arthmatic Operators

            double sum,sub,mul,div,mod;
            Console.WriteLine("Enter the first number");
            double x = double.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter the second number");
            double y = double.Parse(Console.ReadLine());

            sum =x+y;
            Console.WriteLine("The summation is : " + sum);

             sub = x-y;
            Console.WriteLine(" The subtraction is :" +sub);

             mul = x*y;
            Console.WriteLine(" The multiplcation is "+mul);

             div = x/y;
            Console.WriteLine("The division is :" + div);

             mod = x % y ;
            Console.WriteLine("The moudlos is :" + mod);

            double inc = (++x) ;
            Console.WriteLine("The increment is :" +inc);

            double dec = (--y) ;
            Console.WriteLine("The decrement is :" +dec);

            Console.ReadKey();                                                                    



        }

    }
}
