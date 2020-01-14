namespace WasteRecycling
{
    public class PaperGarbage : Garbage
    {
        public bool Squeezed { set; get; }

        public PaperGarbage(string name, bool squeezed) : base(name)
        {
            Name = name;
            Squeezed = squeezed;

        }

        public void Squeeze()
        {
            Squeezed = true;
        }
    }
}
