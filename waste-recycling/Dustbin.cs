namespace WasteRecycling
{
    public class Dustbin
    {
        string Color { set; get; }
        PaperGarbage[] PaperContent = new PaperGarbage[20];
        PlasticGarbage[] PlasticContent = new PlasticGarbage[20];
        Garbage[] HouseWasteContent = new Garbage[20];


        void DisplayContents()
        {
            System.Console.WriteLine(Color + "Dustbin!");
            System.Console.WriteLine("House waste content: " + HouseWasteContent.Length + " item(s)");
            foreach (var item in HouseWasteContent)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("Paper content: " + PaperContent.Length + " item(s)");

            foreach (var item in PaperContent)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("Plastic content: " + PlasticContent.Length + " item(s)");

            foreach (var item in PlasticContent)
            {
                System.Console.WriteLine(item);
            }
        }
        void ThrowOutGarbage(Garbage garbage)
        {
            if (garbage is PlasticGarbage)
            {
                if (((PlasticGarbage)garbage).Cleaned == true)
                {
                    int index = -1;
                    for (int i = 0; i < PlasticContent.Length; i++)
                    {

                    }
                }
            }
        }
    }
}
