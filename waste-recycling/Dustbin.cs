namespace WasteRecycling
{
    public class Dustbin
    {
        string Color { set; get; }
        PaperGarbage[] PaperContent;
        PlasticGarbage[] PlasticContent;
        Garbage[] HouseWasteContent;
    }

    void DisplayContents()
    {
        System.Console.WriteLine(Color + "Dustbin!");
        System.Console.WriteLine("House waste content: " + Garbage.Lenght + " item(s)");
        foreach (var item in HouseWasteContent)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine("Paper content: " + PaperGarbage.Lenght + " item(s)");

        foreach (var item in PaperGarbage)
        {
            System.Console.WriteLine(item);
        }

        System.Console.WriteLine("Plastic conten: " + PlasticGarbage.Lenght + " item(s)");

        foreach (var item in PlasticGarbage)
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

            }
        }
    }
}
