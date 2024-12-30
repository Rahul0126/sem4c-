using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem4c_
{
    internal class evenodd
    {
        public static void Main(string[] args)
        {

            double no;

            Console.WriteLine("Enter the number:");

            no = Convert.ToDouble(Console.ReadLine());

            if (no % 2 == 0) {

                Console.WriteLine("the number is even");
            }
            else
            {
                Console.WriteLine("the number is odd");
            }

            

        }
    }
}
