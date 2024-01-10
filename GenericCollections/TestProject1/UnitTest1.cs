using Microsoft.VisualStudio.TestTools.UnitTesting;
using Review3;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
             MsTestingCalculateRectangleArea area = new MsTestingCalculateRectangleArea();
            double expected =70;// 989;
            double gained = area.AreaCalculate();
            Assert.AreEqual(expected, gained);
        }
        [TestMethod]
        public void TestMethod2()
        {
            MsTestingCalculateRectangleArea area = new MsTestingCalculateRectangleArea();
            double expected = 700;
            double gained = area.AreaCalculate();
            Assert.AreEqual(expected, gained);
        }
    }
}
