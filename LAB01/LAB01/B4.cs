namespace LAB01
{
    internal partial class MainClass
    {
        class B4
        {
            public static void Bai4()
            {
                int n;
                Console.WriteLine("Nhập vào một số nguyên");
                n = int.Parse(Console.ReadLine());
                if (n % 2 == 0)
                {
                    Console.WriteLine($"Số {n} là số chẵn");
                }
                else
                {
                    Console.WriteLine($"Số {n} là số lẻ");
                }
            }
        }
    }
}
