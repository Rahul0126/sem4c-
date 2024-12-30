using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem4c_
{
    internal class divisible
    {
        public static void Main(string[] args)
        {

            double num1;

            Console.WriteLine("Enter the Number: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            if (num1 / 3 == 0)
            {

                Console.WriteLine("The number can devide by 3");
            }
            else if (num1 / 5 == 0)
            {
                Console.WriteLine("the number can devide by 5");
            }
            else
            {
                Console.WriteLine("the number cannot devide by 3&5");
            }

        }
    }
}


