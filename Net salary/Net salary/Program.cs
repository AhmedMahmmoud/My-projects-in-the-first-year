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
            double tax, salary, Net_salary;
            Console.WriteLine("Enter The Salary");
            salary = double.Parse(Console.ReadLine());

            if (salary >= 1000)
            {
                tax = 0.05 * salary;
                Console.WriteLine("tax is "+tax);
            }

            else if (salary < 1000 && salary >= 500)
            {
                tax = 0.02 * salary;
                Console.WriteLine("tax  = "+ tax);
            }
            else
                tax = 0.0; 

            Net_salary = salary - tax;
            Console.WriteLine("Net_Salary="+Net_salary);

            Console.ReadKey();
        
        }
    }
}
