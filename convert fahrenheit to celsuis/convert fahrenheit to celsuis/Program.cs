using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert_fahrenheit_to_celsuis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double C, F;
            Console.WriteLine("Enter The value of tempreture expreesd in fahrenheit ");
            F = Convert.ToDouble(Console.ReadLine());

            C = 5* (F - 32)/9;

            Console.WriteLine("The value of tempreture which convert in celsuis = {0}" ,C);   
           
            Console.ReadKey();
        }
    }
}
