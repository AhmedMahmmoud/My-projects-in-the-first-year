using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Net_salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This program is programed by sequential structure and is programed by me baby ^_^ 

            double  Net_salary,salary,tax,tax_ratio;

            Console.WriteLine(" Please enter the salary");
             salary = double.Parse(Console.ReadLine());

            Console.WriteLine("please enter the tax ratio");
             tax_ratio = double.Parse(Console.ReadLine());


             tax = salary * tax_ratio;
             Net_salary= salary - tax;

            Console.WriteLine("The Net_salary =" + Net_salary);

            Console.ReadLine();
        }
    }
}
