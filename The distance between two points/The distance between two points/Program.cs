using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_distance_between_two_points
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance;
            Console.WriteLine(" enter the coordinate (x1,x2)");
            double x1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine(" enter the coordinate (y1,y2)");
            double y1 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("The distance between two poients" + distance);

            Console.ReadLine();

        }
    }
}
