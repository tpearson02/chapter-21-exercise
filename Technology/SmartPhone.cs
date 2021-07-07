using System;
namespace Technology
{
    public class SmartPhone: Computer
    {
        public int ModelNum { get; set; }
        public int FaceTimeHours { get; set; }
        public SmartPhone(int modelID, string brand, string version, int modelNum, double storageCapacity, string color, int faceTimeHours)
            :base(modelID, brand, version, storageCapacity, color)
        {
            this.ModelNum = modelNum;
            this.FaceTimeHours = faceTimeHours;
        }
        public void ThisPhone()
        {
            Console.WriteLine($"This is a {this.ModelID} with {this.FaceTimeHours} video chat hours.");
            if (ModelNum > 10)
            {
                Console.WriteLine("Nice Phone!");
            }
        }
        public override int DeviceModelId()
        {
            this.ModelID = ModelNum;
            return this.ModelID;
        }
    }
}
