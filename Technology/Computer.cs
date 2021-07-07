using System;
namespace Technology
{
    public class Computer:AbstractEntity
    {
        public string Brand { get; set; }
        public string Version { get; set; }
        public double StorageCapacity { get; set; }
        public string Color { get; set; }

        public Computer(int modelID)
            :base(modelID)
        { 
        }
        public Computer(int modelID, string brand, string version, double storageCapacity, string color)
            :base(modelID)
        {
            
            this.Brand = brand;
            this.StorageCapacity = storageCapacity;
            this.Color = color;
            this.Version = version;
        }
        public void GetDeviceInfo()
        {
            Console.WriteLine($"This is a {this.Version} made by {this.Brand}, in the color {this.Color}, with {this.StorageCapacity} gbs.");
        }
        public double Upgrade()
        {
            this.StorageCapacity -= 5.7;

            return this.StorageCapacity;

        }
        public void NewUpgrade()
        {
            Console.WriteLine($"Upgrade complete. You now have {this.StorageCapacity} gbs of storage.");
        }
    }

}
