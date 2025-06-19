namespace LAB01
{
    internal partial class MainClass
    {
        class B1
        {
            public static void Bai1()
            {
                string name, age;
                Console.WriteLine("Nhập tên của bạn:");
                name = Console.ReadLine();
                Console.WriteLine("Nhập tuổi của bạn:");
                age = Console.ReadLine();
                Console.WriteLine($"Xin chào {name}, bạn {age} tuổi!");
            }
        }
    }
}
