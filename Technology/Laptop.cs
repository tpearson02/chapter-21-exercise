using System;
namespace Technology
{
    public class Laptop : Computer
    {
        public int Ram { get; set; }
        public Laptop( int modelID, string brand, string version, double storageCapacity, string color, int Ram)
            :base(modelID, brand, version, storageCapacity, color)
        {
            this.Ram = Ram;
        }
        public void ThisLaptop()
        {
            Console.WriteLine($"This laptop has {this.Ram} gbs.");
            if (Ram < 16)
            {
                Console.WriteLine("You may want to upgrade you ram");
            }
        }
    }
}
