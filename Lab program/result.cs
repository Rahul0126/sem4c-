using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem4c_
{
    internal class result
    {
        public static void Main(string[] args)
        {

            double sub1, sub2, sub3, sub4, sub5, total, avg;

            Console.WriteLine("Enter the marks of sub1:");
            sub1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the marks of sub2:");
            sub2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the marks of sub3:");
            sub3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the marks of sub4:");
            sub4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the marks of sub5:");
            sub5 = Convert.ToDouble(Console.ReadLine());

            total = (sub1 + sub2 + sub3 + sub4 + sub5);

            Console.WriteLine("total is: " + total);

            avg = total / 5;

            if (avg > 95)
            {

                Console.WriteLine("congratulations! you're above distinction");
            }
            else if (avg > 80)
            {

                Console.WriteLine("you're Distinction");
            }

            else if (avg > 60)
            {
                Console.WriteLine("you're first class");
            }
            else if (avg > 33){

                Console.WriteLine("you're second class");
            }
            else
            {

                Console.WriteLine("you're failed");
            }

        }


    }
}
