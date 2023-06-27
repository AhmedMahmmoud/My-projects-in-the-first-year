using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool result;
            // Relational Operators

            Console.WriteLine("Enter the first number");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            double y = double.Parse(Console.ReadLine());

            result = (x == y);
            Console.WriteLine("Equal to operator" + "\t" + result);

            result = (x > y);
            Console.WriteLine("Gretar than operators" + "\t" + result);

            result = (x < y);
            Console.WriteLine("Lesser than opertor " + "\t" + result);

            result = (x != y);
            Console.WriteLine("Not equal to operator " + "\t" + result);

            Console.WriteLine("press enter key to exit...");

            Console.ReadKey();
        }
    }
}
