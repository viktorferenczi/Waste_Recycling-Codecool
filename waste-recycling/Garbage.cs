namespace WasteRecycling
{
    public class Garbage
    {
        public string Name { get; set; }

        public Garbage(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }
}
