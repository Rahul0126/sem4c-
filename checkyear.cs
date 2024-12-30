using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem4c_
{
    internal class checkyear
    {
        public static void Main(string[] args)
        {

            double year;

            Console.WriteLine("enter the year to check");
            year = Convert.ToDouble(Console.ReadLine());

            if (year % 4 == 0 || year %400 == 0)
            {
                Console.WriteLine("the year" + year + "is Leap year");
            }
            else {

                Console.WriteLine("the year"  + year +  "is not Leap year");
            }
        }
    }
}