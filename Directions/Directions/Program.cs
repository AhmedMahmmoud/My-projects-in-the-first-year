using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type direction");
            string s = Convert.ToString(Console.ReadLine());
            int y;
            switch (s)
            {
                case "Right":
                case "right":
                    y = 1;
                    break;
                case "left":
                    y = 2;
                    break;
                case "Up":
                    y = 3;
                    break;
                case "Down":
                    y = 4;
                    break;
                default:
                    y = 0;
                    break;
            }
            Console.WriteLine("y=" + y);
            Console.ReadLine();
        }
    }
}
