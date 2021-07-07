using System;
namespace Technology
{
    public class AbstractEntity
    {
        public int ModelID { get; set; }
        public AbstractEntity(int modelID)
        {
            this.ModelID = 24501;
        }
        public virtual int DeviceModelId()
        {
            this.ModelID += 1;
            return this.ModelID;
        }
    }
}
