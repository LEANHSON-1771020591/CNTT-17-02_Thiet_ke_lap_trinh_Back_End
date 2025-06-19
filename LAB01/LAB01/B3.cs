namespace LAB01
{
    internal partial class MainClass
    {
        class B3
        {
            public static void Bai3()
            {
                float C, F;
                Console.WriteLine("Nhập nhiệt độ C:");
                C = float.Parse(Console.ReadLine());
                F = (C * 9 / 5) + 32;
                Console.WriteLine($"Nhiệt độ F là {F}");

            }
        }
    }
}
