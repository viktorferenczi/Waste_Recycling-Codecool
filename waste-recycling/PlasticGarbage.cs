namespace WasteRecycling
{
    public class PlasticGarbage : Garbage
    {
        public bool Cleaned { set; get; }


        public PlasticGarbage(string name, bool cleaned)
        {
            Name = name;
            Cleaned = cleaned;
        }

        void Clean()
        {
            Cleaned = true;
        }
    }
}
