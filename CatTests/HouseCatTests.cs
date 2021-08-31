using Cats;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CatTests
{
    [TestClass]
    public class HouseCatTests
    {
        [TestMethod]
        public void InheritsBaseInFirstConstructor()
        {
            HouseCat keyboardCat = new HouseCat("Keyboard Cat", 7);
            Assert.AreEqual(7, keyboardCat.Weight, .001);
        }
    }
}