using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem4c_
{
    internal class maximum
    {
        public static void Main(string[] args)
        {
            double no1, no2, no3;

            Console.WriteLine("Enter First Number: ");
            no1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second Number: ");
            no2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Third Number: ");
            no3 = Convert.ToDouble(Console.ReadLine());


            if (no1 > no2 && no1 > no3)
            {
                Console.WriteLine("no1 is maximum");
            }
            else if (no2 > no1 && no2 > no3)
            {

                Console.WriteLine("no2 is maximum");
            }
            else
            {


                Console.WriteLine("no3 is maximum");
            }
        
        
        
        }
    }
}
