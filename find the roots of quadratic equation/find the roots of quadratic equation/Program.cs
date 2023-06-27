using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace find_the_roots_of_quadratic_equation
{
    internal class Program
    {
        static void Main(string[] args)
        {    
            //a *Math.pow(x,2)+b*x+c
            double a,b,c, d,x1,x2;
            Console.WriteLine("Enter the value of a,b and c");
            a =double.Parse(Console.ReadLine());
            b =double.Parse(Console.ReadLine());
            c =double.Parse(Console.ReadLine());
            if (a != 0)
            {
                d = b * b - 4 * a * c;
            }
            else
            {
                Console.WriteLine("Quadratic equation not poosible");
            }
            d = b * b - 4 * a * c;
            if (d >= 0)
            {
                d = Math.Sqrt(d);
                x1 = (-b + d) / (2 * a);
                x2 = (-b - d) / (2 * a);
                Console.WriteLine("x1=" + x1);
                Console.WriteLine("x2=" + x2);
            }
            else {
                Console.WriteLine("Root not possible ");   
            }
            Console.ReadLine();
        }
    }
}
