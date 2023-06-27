using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* This program calculate the radius of the circle */

            double radius, area;
           
            Console.WriteLine("Enter The Radius");
            radius=double.Parse(Console.ReadLine());

            area = Math.PI *radius * radius ;
            Console.WriteLine( "The area of the circle = {0}" ,area);

            Console.ReadKey();
            
        }
    }
}
