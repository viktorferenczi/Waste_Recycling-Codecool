using System;

namespace WasteRecycling
{
    public class PlasticGarbage : Garbage
    {
        public bool Cleaned { get; set; }


        public PlasticGarbage(string name, bool cleaned) : base(name)
        {
            Name = name;
            Cleaned = cleaned;
        }

        public override string ToString()
        {
            return base.ToString() + $"{Environment.NewLine}Cleaned: {Cleaned}";
        }

        public void Clean()
        {
            Cleaned = true;
        }
    }
}
