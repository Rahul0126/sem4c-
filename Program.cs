using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem4c_
{
     class Program
    {
        static void Main(string[] args)
        {
            double num;

            Console.WriteLine("Enter the Number:");
            num=Convert.ToDouble(Console.ReadLine());

            if (num == 0)
            {

                Console.WriteLine("The Number is Zero");


            }
            else if (num < 0)
            {
                Console.WriteLine("The number is Negative");
            }
            else {

                Console.WriteLine("The number is positive");
            }
          

            Console.ReadKey();
        }
       
    }
}
