using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication4.Logics;

namespace WebApplication4UnitTest
{
    [TestClass]
    public class SampleLogicUnitTest
    {
        [TestMethod]
        public void GetValueTest()
        {
            var logic = new SampleLogic();
            var result = logic.GetValue();
            Assert.AreEqual("Value", result);
        }
    }
}
