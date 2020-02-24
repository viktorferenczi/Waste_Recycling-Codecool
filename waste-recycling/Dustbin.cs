using System;
using System.Linq;

namespace WasteRecycling
{
    public class Dustbin
    {
        public string Color { get; set; }
        public PaperGarbage[] PaperContent = new PaperGarbage[0];
        public PlasticGarbage[] PlasticContent = new PlasticGarbage[0];
        public Garbage[] HouseWasteContent = new Garbage[0];

        public Dustbin(string color)
        {
            Color = color;
        }

        public void DisplayContents()
        {
            Console.WriteLine(Color + " Dustbin!");
            Console.WriteLine("House waste content: " + HouseWasteContent.Length + " item(s)");
            foreach (Garbage garbage in HouseWasteContent)
            {
                Console.WriteLine(garbage);
            }

            Console.WriteLine("Paper content: " + PaperContent.Length + " item(s)");

            foreach (PaperGarbage paper in PaperContent)
            {
                Console.WriteLine(paper);
            }

            Console.WriteLine("Plastic content: " + PlasticContent.Length + " item(s)");

            foreach (PlasticGarbage plastic in PlasticContent)
            {
                Console.WriteLine(plastic);
            }
        }

        public void ThrowOutGarbage(String text)
        {
            throw new DustbinContentException("LOL XD");
        }
       
       public void ThrowOutGarbage(Garbage garbage)
       {
            
            if (garbage is PlasticGarbage)
            {
                if (((PlasticGarbage)garbage).Cleaned == true)
                {
                    Array.Resize(ref PlasticContent, PlasticContent.Length + 1);
                    int index = -1;
                    for (int i = 0; i < PlasticContent.Length; i++)
                    {
                        index = i;
                    }
                    if (index == -1)
                    {
                        throw new DustbinContentException("Full.");
                    }
                    PlasticContent[index] = (PlasticGarbage)garbage;
                }
                else
                {
                    throw new DustbinContentException("The plastic is not clean!");
                }
            }
            else if (garbage is PaperGarbage)
            {
                if (((PaperGarbage)garbage).Squeezed == true)
                {
                    Array.Resize(ref PaperContent, PaperContent.Length + 1);
                    int indexpaper = -1;
                    for (int i = 0; i < PaperContent.Length; i++)
                    {
                        indexpaper = i;
                    }
                    if(indexpaper == -1) 
                    {
                        throw new DustbinContentException("Full.");
                    }
                    PaperContent[indexpaper] = (PaperGarbage)garbage;
                }
                else
                {
                    throw new DustbinContentException("The paper is not squeezed!");
                }
            }
            else if (garbage is Garbage)
            {
                Array.Resize(ref HouseWasteContent, HouseWasteContent.Length + 1);
                int index2 = -1;
                for (int i = 0; i < HouseWasteContent.Length; i++)
                {
                    index2 = i;
                }
                if (index2 == -1)
                {
                    throw new DustbinContentException("Full.");
                }
                HouseWasteContent[index2] = garbage;
            }
            else
            {
                throw new DustbinContentException("Plastic or Paper.");
            }
       }

        public void EmptyContents()
        {
           // Array.Clear(PlasticContent, 0, PlasticContent.Length);
           // Array.Clear(PaperContent, 0, PaperContent.Length);
           // Array.Clear(HouseWasteContent, 0, HouseWasteContent.Length);

             for (int i = 0; i < PlasticContent.Length; i++)
            {
                PlasticContent[i] = null;
            }

            for (int i = 0; i < PaperContent.Length; i++)
            {
                PaperContent[i] = null;
            }

            for (int i = 0; i < HouseWasteContent.Length; i++)
            {
                HouseWasteContent[i] = null;
            }
            
            Array.Resize(ref PaperContent, 0);
            Array.Resize(ref PlasticContent, 0);
            Array.Resize(ref HouseWasteContent, 0);
        }
    }
}
