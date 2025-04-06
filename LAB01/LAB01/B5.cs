using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class B5
    {
        public static void Bai5()
        {
            float a, b, tich, tong;
            Console.WriteLine("Nhập số đầu tiên");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhập số thứ hai");
            b = float.Parse(Console.ReadLine());
            tong = a + b;
            tich = a * b;
            Console.WriteLine($"Tổng của hai số là {tong}");
            Console.WriteLine($"Tích của hai số là {tich}");
        }

        
    }
}
