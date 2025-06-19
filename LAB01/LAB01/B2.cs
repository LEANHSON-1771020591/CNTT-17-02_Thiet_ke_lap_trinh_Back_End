namespace LAB01
{
    internal partial class MainClass
    {
        class B2
        {
            public static void Bai2()
            {
                float length, width;
                Console.WriteLine("Nhập chiều dài hình chữ nhật:");
                length = float.Parse(Console.ReadLine());
                Console.WriteLine("Nhập chiều rộng hình chữ nhật:");
                width = float.Parse(Console.ReadLine());
                float area = length * width;
                Console.WriteLine($"Diện tích hình chữ nhật là {area}");
            }
        }
    }
}
