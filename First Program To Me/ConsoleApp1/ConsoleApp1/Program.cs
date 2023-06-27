using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The first program to me and states on Arthmatic Operators

            Console.WriteLine("Enter the first number");
           double x = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            double y = double.Parse(Console.ReadLine());

            Console.WriteLine("\n");    
            double sum =( x + y ); 
            Console.WriteLine(sum);
            
            double sub = x - y;
            Console.WriteLine(sub);

            double mul = x * y;
            Console.WriteLine(mul);

            double div = x / y;
            Console.WriteLine(div);

            
            Console.ReadLine();

        }
    }
}
