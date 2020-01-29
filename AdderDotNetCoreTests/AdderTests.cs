using AdderDotNetCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdderDotNetCoreTests
{
    [TestClass]
    public class AdderTests
    {
        [TestMethod]
        public void Adder_Given_2And2_Returns_4()
        {
            Assert.AreEqual(4, Adder.Add(2, 2));
        }
    }
}
