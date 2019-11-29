using System;
using NUnit.Framework;
using WasteRecycling;

namespace WasteRecycling.Tests
{
    public class DustbinTests
    {
        [Test]
        public void TestDustbinOutPaperGarbage()
        {
            PaperGarbage paperGarbage = new PaperGarbage("Paper garbage", true);
            Dustbin dustbin = new Dustbin("red");
            dustbin.ThrowOutGarbage(paperGarbage);
            Assert.AreEqual(dustbin.PaperContent.Length, 1);
            Assert.AreEqual(dustbin.PlasticContent.Length, 0);
            Assert.AreEqual(dustbin.HouseWasteContent.Length, 0);
        }

        [Test]
        public void TestDustbinOutPlasticGarbage()
        {
            PlasticGarbage plasticGarbage = new PlasticGarbage("Plastic garbage", true);
            Dustbin dustbin = new Dustbin("red");
            dustbin.ThrowOutGarbage(plasticGarbage);
            Assert.AreEqual(dustbin.PaperContent.Length, 0);
            Assert.AreEqual(dustbin.PlasticContent.Length, 1);
            Assert.AreEqual(dustbin.HouseWasteContent.Length, 0);
        }

        [Test]
        public void testDustbinOutHouseWasteGarbage()
        {
            Garbage garbage = new Garbage("House waste garbage");
            Dustbin dustbin = new Dustbin("red");
            dustbin.ThrowOutGarbage(garbage);
            Assert.AreEqual(dustbin.PaperContent.Length, 0);
            Assert.AreEqual(dustbin.PlasticContent.Length, 0);
            Assert.AreEqual(dustbin.HouseWasteContent.Length, 1);
        }

        [Test]
        public void TestDustbinOutUnsqueezedPaperGarbage()
        {
            PaperGarbage paperGarbage = new PaperGarbage("Paper garbage", false);
            Dustbin dustbin = new Dustbin("red");
            Assert.Throws<DustbinContentException>(() => dustbin.ThrowOutGarbage(paperGarbage));
        }

        [Test]
        public void TestDustbinOutUncleanedPlasticGarbage()
        {
            PlasticGarbage plasticGarbage = new PlasticGarbage("Plastic garbage", false);
            Dustbin dustbin = new Dustbin("red");
            Assert.Throws<DustbinContentException>(() => dustbin.ThrowOutGarbage(plasticGarbage));
        }

        [Test]
        public void TestEmptyContentsOnDustbin()
        {
            Garbage[] garbageList = new Garbage[] {
                new PlasticGarbage("Plastic garbage", true),
                new PaperGarbage("Paper garbage", true),
                new Garbage("House waste garbage")
            };

            Dustbin dustbin = new Dustbin("red");
            foreach (Garbage garbage in garbageList)
            {
                dustbin.ThrowOutGarbage(garbage);
            }

            dustbin.EmptyContents();

            Assert.AreEqual(dustbin.PaperContent.Length, 0);
            Assert.AreEqual(dustbin.PlasticContent.Length, 0);
            Assert.AreEqual(dustbin.HouseWasteContent.Length, 0);
        }

        /*
        // Uncomment this test case.
        // What happens?
        // Why?
        [Test]
        public void TestDustbinOutSomethingWhichIsNotAGarbage()
        {
            string myString = "This is NOT a garbage, right???";
            Dustbin dustbin = new Dustbin("red");
            Assert.Throws<DustbinContentException>(() => dustbin.ThrowOutGarbage(myString));
        }
        */
    }
}
