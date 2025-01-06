using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem4c_
{
    internal class licence
    {
        public static void Main(string[] args)
        {

            double num;

            Console.Write("Enter the Age:");
            num=Convert .ToDouble(Console.ReadLine());

            if (num > 18)
            {
                Console.WriteLine("you can vote!");
            }
            else {

                Console.WriteLine("you can't vote");
            }
        
        
        }
    }
}
