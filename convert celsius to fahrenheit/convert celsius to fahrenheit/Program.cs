using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace convert_celsius_to_fahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Celsius Temperature");
            double Celsius = double.Parse(Console.ReadLine());

            double Fahrenhiet = 9.0 * (Celsius + 32) / 5.0;
            Console.WriteLine("the temerature of fahrenheit = " + Fahrenhiet + "\tdegrees Fahrenheit");

            //using if else
            /*if (F >= 90)
            {
                Console.WriteLine("heat warning");
            }
            else
            {
                Console.WriteLine("there is no extreme heat");
            }
            */
            //using conditional operator
            /*
            string res;
            res = (Fahrenhiet >= 90) ? "really hot out there" : "there is no extreme heat";
            Console.WriteLine("\n");
            Console.WriteLine(res);
            */
            //using nested if else

            /* if (Fahrenhiet >= 90)
             {
                 Console.WriteLine("heat warning");
             }
             else if (Fahrenhiet < 90 && Fahrenhiet >= 80)
             {
                 Console.WriteLine("it is warm , but there is no extreme heat ");
             }
             else if (Fahrenhiet < 80 && Fahrenhiet >= 70)
             {
                 Console.WriteLine("The temperature is pleasent and suggest a picnic");
             }
             else
             { 
             Console.WriteLine("a suggestion to have a jacket");}*/



            //using switch  

            int condition = (int)Fahrenhiet / 10;
            Console.WriteLine("it is in the " + condition + "0's.");
            switch (condition)
            {
                case 10:
                    Console.WriteLine("it is hot , stay inside !");
                    break;
                case 9:
                    Console.WriteLine("it is really hot out there ");
                    break ;
                case 8:
                    Console.WriteLine("it is warm , but no exteame here");
                    break;
                case 7:
                        Console.WriteLine("it is very pleasent today");
                    break;
                    default:
                    Console.WriteLine("take a jacket");
                    break;
            }
                Console.ReadKey();
       
        }
    }
}
