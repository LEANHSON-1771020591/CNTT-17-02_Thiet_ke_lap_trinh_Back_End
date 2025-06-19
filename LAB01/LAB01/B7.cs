using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class B7
    {
        public static void Bai7()
        {
            int n;
            Console.WriteLine("Nhập vào một năm để kiểm tra");
            n = int.Parse(Console.ReadLine());
            if(n % 4 == 0 && n % 100 != 0 || n % 400 == 0 )
            {
                Console.WriteLine($"{n} là năm nhuận");
            }
            else
            {
                Console.WriteLine($"{n} không phải là năm nhuận");
            }   
        }
    }
}
