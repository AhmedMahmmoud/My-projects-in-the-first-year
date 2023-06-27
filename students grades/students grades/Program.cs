using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace students_grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double degree;
            Console.WriteLine("Enter The Degree");
            degree = double.Parse(Console.ReadLine());

            if (degree > 85)
                Console.WriteLine("Excellent");

            else if (degree < 85 && degree >= 75)
                Console.WriteLine("Very Good");

            else if (degree < 75 && degree >= 65)
                Console.WriteLine("Good");

            else if (degree < 65 && degree >= 50)
                Console.WriteLine("Pass");

            else
                Console.WriteLine("Fail");

            Console.ReadKey();

        }

    }
}
