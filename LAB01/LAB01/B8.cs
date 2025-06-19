using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01
{
    internal class B8
    {
        public static void Bai8()
        {
            for(int i = 0; i <= 10; i++) {
               for(int j = 0;j <= 10;j++)
                {
                    Console.WriteLine($"{i} x {j} = {i * j}");
                }
            }
    }
}
}

