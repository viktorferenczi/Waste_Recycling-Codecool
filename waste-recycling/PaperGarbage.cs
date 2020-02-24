using System;

namespace WasteRecycling
{
    public class PaperGarbage : Garbage
    {
        public bool Squeezed { get; set; }

        public PaperGarbage(string name, bool squeezed) : base(name)
        {
            Name = name;
            Squeezed = squeezed;

        }

        public override string ToString()
        {
            return base.ToString() + $"{Environment.NewLine}Squeezed: {Squeezed}";
        }

        public void Squeeze()
        {
            Squeezed = true;
        }
    }
}
