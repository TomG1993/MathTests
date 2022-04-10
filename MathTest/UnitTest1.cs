using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathTest
{
    [TestClass]
    public class SquareRootTests
    {
        [TestMethod]
        public void return_a_square_root()
        {
            Assert.AreEqual(4, MathRoot.SquareRoot(16));

            Assert.AreEqual(3, MathRoot.SquareRoot(9));

        }
    }
}