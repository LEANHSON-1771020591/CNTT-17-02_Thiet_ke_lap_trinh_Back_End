using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class B9
    {
        public static void Bai9()
        {
            int n;
            Console.WriteLine("Nhập số n");
            n = int.Parse(Console.ReadLine());
            int gt = n * n;
            Console.WriteLine($"giai thừa của n là {gt}");
        }
    }
}
