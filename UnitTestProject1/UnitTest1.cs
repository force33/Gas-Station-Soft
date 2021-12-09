using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMathLiter()
        {
            string a = Gas_Station_Soft.OilForm.MathLiter("2", "10"); 
            Assert.AreEqual("5",a);
        }

        [TestMethod]
        public void TestMathSumm()
        {
            string a = Gas_Station_Soft.OilForm.MathSumm("2", "10");
            Assert.AreEqual("20", a);
        }
    }
}
