using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class B10
    {
        public static void Bai10()
        {
            int n;
            Console.WriteLine("Nhập số n");
            n = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (n <= 1)
            {
                isPrime = false;
            }
            else if (n == 2)
            {
                isPrime = true;
            }
            else if (n % 2 == 0)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 3; i <= Math.Sqrt(n); i += 2)
                {
                    if (n % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{n} là số nguyên tố");
            }
            else
            {
                Console.WriteLine($"{n} không phải là số nguyên tố");
            }
        }
    }
}
