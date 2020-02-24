namespace WasteRecycling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // We create the garbage objects that appear in the script.
            Garbage[] rottenTomatoes = new Garbage[3];
            for (int i = 0; i < 3; i++)
            {
                rottenTomatoes[i] = new Garbage("rotten tomato nr." + (i + 1));
            }

            // Then we create the plastic milk jug.
            PlasticGarbage milkJug = new PlasticGarbage("plastic milk jug", false);

            /*
                Note that on the leftside the type is Garbage, but on the right it's PlasticGarbage.
                We can do this, because PlasticGarbage extends Garbage, which in simple terms
                means that every plastic garbage is garbage, but not every garbage is plastic garbage.
            */

            // We create the dustbin where the garbages will be thrown.
            Dustbin dustbin = new Dustbin("Jenny's handsome");

            // Showing the contents of the dustbin for the sake of seeing something on the terminal :)
            dustbin.DisplayContents();

            // Then the cleaning lady comes and does her thing.
            for (int i = 0; i < 3; i++)
            {
                /*
                    She throws every piece of rotten tomato in the dustbin.
                    This doesn't mean the tomato Garbage instance will be destroyed or anything,
                    they are just now inside of the Dustbin object.
                */
                dustbin.ThrowOutGarbage(rottenTomatoes[i]);
            }

            // Then she cleans the milk jug.
            if (!milkJug.Cleaned)
            {
                milkJug.Clean();
            }

            // Throws out the milk jug.
            dustbin.ThrowOutGarbage(milkJug);

           

            // Displaying what's in there.
            dustbin.DisplayContents();

            // Empties the contents.
            dustbin.EmptyContents();

            // Aaaaaaand the scene fades out!

        }
    }
}
