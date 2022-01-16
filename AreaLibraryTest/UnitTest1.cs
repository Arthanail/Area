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
            var a = 5;
            var b = 10;
            var c = 15.64848;
            var triangleCreator = new CreateTriangle(a, b, c);
            triangleCreator.CreateFigure();
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void TestCreateCircle()
        {
            var a = 5;
            var b = 10;
            var c = 15.64848;
            var circleCreator = new CreateCircle(a);
            var circleCreator2 = new CreateCircle(b);
            var circleCreator3 = new CreateCircle(c);
            circleCreator.CreateFigure();
            circleCreator2.CreateFigure();
            circleCreator3.CreateFigure();
            Assert.IsTrue(true);
        }
    }
}