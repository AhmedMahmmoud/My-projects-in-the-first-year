using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 10;
            /*bool a = true, result;
            result=(x <= y)&&(x>10);
            Console.WriteLine("And operator:" +result);

            result = (x >= y) || (x < 5);
            Console.WriteLine("Or Operator :" +result);

            result = !a;
            Console.WriteLine("Not Operator :"+result);*/

            int result = (x & y);
            Console.WriteLine("Bitwise And : " +result);
             
            result = (x | y);
            Console.WriteLine("Bitwise Or : " + result);

            result = (x ^ y);
            Console.WriteLine("Bitwise Xor :" + result);

            result = ~x ;
            Console.WriteLine("Bitwise complement :" +result);

            result = x << 2;
            Console.WriteLine("Bitwise Left shift :"+result);


            result = x>> 2;
            Console.WriteLine("Bitwise Right shift :"+ result );
   
            Console.ReadKey();

        }
    }
}
