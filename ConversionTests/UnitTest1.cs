using Microsoft.VisualStudio.TestTools.UnitTesting;
using TempConvert;

namespace ConversionTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestF2c()
        {
            double f = 32;
            double c = 0;
            double rvalue = TempConvert.Convert.f2c(f);
            Assert.AreEqual(c, rvalue);
            Assert.AreEqual(100, TempConvert.Convert.f2c(212));

        }

        [TestMethod]
        public void TestC2F() {
            Assert.AreEqual(212, TempConvert.Convert.c2f(100));
            Assert.AreEqual(100, TempConvert.Convert.c2f(212));

        }

    }
}