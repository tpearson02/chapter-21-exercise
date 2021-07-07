using System;

namespace Technology
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer1 = new Computer(54609, "Apple", "iMac", 256, "Silver");
            Computer computer2 = new Computer(54608, "Apple", "iMac", 126, "Black");
            computer1.GetDeviceInfo();
            computer1.Upgrade();
            computer1.NewUpgrade();
            Console.WriteLine("------------");

            Laptop laptop1 = new Laptop(44609, "Apple", "Macbook Air", 64, "Gold", 8);
            Laptop laptop2 = new Laptop(44610, "Apple", "Macbook Pro", 128, "Black", 16);
            laptop1.GetDeviceInfo();
            Console.WriteLine("------------");

            SmartPhone smartphone1 = new SmartPhone(66708, "Apple", "IPhone", 11, 128, "Green", 1080);
            SmartPhone smartphone2 = new SmartPhone(66709, "Apple", "IPhone", 12, 256, "Gold", 1080);
            smartphone1.GetDeviceInfo();
            Console.WriteLine("------------");
        }
    }
}
