using System;
using NUnit.Framework;

namespace WasteRecycling.Tests
{
    public class PaperGarbageTests
    {
        [Test]
        public void TestInstantiatingPaperGarbage()
        {
            string garbageName = "An empty milk carton";
            PaperGarbage paperGarbage = new PaperGarbage(garbageName, false);
            Assert.AreEqual(garbageName, paperGarbage.Name);
            Assert.IsFalse(paperGarbage.Squeezed);
        }

        [Test]
        public void TestSqueezeOnPaperGarbage()
        {
            PaperGarbage paperGarbage = new PaperGarbage("Paper garbage", false);
            paperGarbage.Squeeze();
            Assert.IsTrue(paperGarbage.Squeezed);
        }
    }
}
