namespace WasteRecycling
{
    public class PaperGarbage : Garbage
    {
        string Name { set; get; }
        bool Squeezed { set; get; }

        public PaperGarbage(string name, bool squeezed)
        {
            Name = name;
            Squeezed = squeezed;

        }

        void Squeeze()
        {
            Squeezed = true;
        }
    }
}
