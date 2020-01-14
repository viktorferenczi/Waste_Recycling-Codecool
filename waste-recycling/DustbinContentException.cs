using System;

namespace WasteRecycling
{
    public class DustbinContentException : Exception
    {
        public DustbinContentException(string message)
        {
            Console.WriteLine(message);
        }
    }
}
