using System;
using NUnit.Framework;

namespace WasteRecycling.Tests
{
    public class GarbageTests
    {
        [Test]
        public void TestInstantiatingGarbage()
        {
            string garbageName = "Rotten food from the fridge";
            Garbage garbage = new Garbage(garbageName);
            Assert.AreEqual(garbageName, garbage.Name);
        }
    }
}
