using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class B6
    {
        public static void Bai6()
        {
            float n;
            Console.WriteLine("Nhập một số để kiểm tra");
            n = float.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine($"{n} là số dương");
            }
            else if (n < 0)
            {
                Console.WriteLine($"{n} là số âm");
            }
            else
            {
                Console.WriteLine($"{n} là số không");
            }
        }
    }
}
