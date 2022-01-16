using Microsoft.VisualStudio.TestTools.UnitTesting;
using AreaCalculator;

namespace AreaLibraryTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCreateTriangle()
        {
            
            double[] legA = {10, 6.5, 5, 25, 30};
            foreach (var legs in legA)
            {
                bool result = legs.CreateTriangle();
                Assert.IsTrue(result);
            }
        }
    }
}