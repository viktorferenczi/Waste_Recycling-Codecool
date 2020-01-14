namespace WasteRecycling
{
    public class Dustbin
    {
        public string Color { set; get; }
        PaperGarbage[] PaperContent = new PaperGarbage[20];
        PlasticGarbage[] PlasticContent = new PlasticGarbage[20];
        Garbage[] HouseWasteContent = new Garbage[20];

        public Dustbin(string color)
        {
            Color = color;
        }

        public void DisplayContents()
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
       public void ThrowOutGarbage(Garbage garbage)
        {
            PlasticGarbage plastic = (PlasticGarbage)garbage;
            if (garbage is PlasticGarbage)
            {
                if (((PlasticGarbage)garbage).Cleaned == true)
                {
                    int index = -1;
                    for (int i = 0; i < PlasticContent.Length; i++)
                    {
                        if( PlasticContent[i] == null)
                        {
                            index = i;
                        }
                    }
                    if (index == -1)
                    {
                        throw new DustbinContentException("Full.");
                    }
                    PlasticContent[index] = plastic;
                }
                else
                {
                    throw new DustbinContentException("The plastic is not clean!");
                }
            }
            else if (garbage is PaperGarbage)
            {
                PaperGarbage paper = (PaperGarbage)garbage;
                if (((PaperGarbage)garbage).Squeezed == true)
                {
                    int indexpaper = -1;
                    for (int i = 0; i < PaperContent.Length; i++)
                    {
                        if (PlasticContent[i] == null)
                        {
                            indexpaper = i;
                        }
                    }
                    if(indexpaper == -1)
                    {
                        throw new DustbinContentException("Full.");
                    }
                    PaperContent[indexpaper] = paper;
                }
                else
                {
                    throw new DustbinContentException("The paper is not squeezed!");
                }
            }
            else if (garbage is Garbage &&  garbage !is PaperGarbage && garbage !is PlasticGarbage)
            {
                
                int index2 = -1;
                for (int i = 0; i < HouseWasteContent.Length; i++)
                {
                    if (HouseWasteContent[i] == null)
                    {
                        index2 = i;
                    }
                }
                if (index2 == -1)
                {
                    throw new DustbinContentException("Full.");
                }
                HouseWasteContent[index2] = garbage;
            }
            else
            {
                throw new DustbinContentException("Not plastic or paper.");
            }
        }

        public void EmptyContents()
        {
            for (int i = 0; i < HouseWasteContent.Length; i++)
            {
                HouseWasteContent[i] = null;
            }

            for (int i = 0; i < PlasticContent.Length; i++)
            {
                PlasticContent[i] = null;
            }

            for (int i = 0; i < PaperContent.Length; i++)
            {
                PaperContent[i] = null;
            }
        }
    }
}
