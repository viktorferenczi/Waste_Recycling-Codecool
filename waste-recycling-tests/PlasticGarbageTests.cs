using System;
using NUnit.Framework;

namespace WasteRecycling.Tests
{
    public class PlasticGarbageTests
    {
        [Test]
        public void TestInstantiatingPlasticGarbage()
        {
            string garbageName = "Empty coke bottle";
            PlasticGarbage plasticGarbage = new PlasticGarbage(garbageName, false);
            Assert.AreEqual(garbageName, plasticGarbage.Name);
            Assert.IsFalse(plasticGarbage.Cleaned);
        }

        [Test]
        public void TestCleanOnPlasticGarbage()
        {
            PlasticGarbage plasticGarbage = new PlasticGarbage("Plastic garbage", false);
            plasticGarbage.Clean();
            Assert.IsTrue(plasticGarbage.Cleaned);
        }
    }
}
