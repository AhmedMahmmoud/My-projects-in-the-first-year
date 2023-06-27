using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace for_and_while_and_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int fact = 1;
            for(int i=1;i<=6;i++)
            {
                fact = fact * i;
                Console.WriteLine(fact);
            }
            */

            /*int fact = 1;
            int i = 1;
            do
            {
                fact *= i;

                i++;
            } while (i <= 6); //semi colllllllen 
            Console.WriteLine(fact);*/

            /* for(int i = 1; i<=10;i+=2)
             {
                 Console.WriteLine(i);
             }*/
            
            int n;
            int sum = 0;
            double avarege;
            for (int i = 1 ; i <= 10 ;i++)
                {
                n = int.Parse(Console.ReadLine());
                sum = (sum + n);
            }
             avarege = sum / 10;
            Console.WriteLine( "avarege equal \t" +avarege);
            Console.WriteLine("sum equal \t "+sum);
            Console.ReadKey();
        }
    }
}
