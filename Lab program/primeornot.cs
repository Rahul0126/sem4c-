using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem4c_
{
    internal class primeornot
    {
        static void Main()
        {
            int number = 30;
            bool isPrimeNumber = IsPrime(number);

            if (isPrimeNumber)
            {
                Console.WriteLine($"{number} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{number} is not a prime number.");
            }
        }

        static bool IsPrime(int n)
        {
            
            if (n < 2)
            {
                return false;
            }

            
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }

}


   