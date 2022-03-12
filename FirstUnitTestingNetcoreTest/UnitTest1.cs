using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FirstUnitTestingNetcoreTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSomething()
        {
            string result = FirstUnitTestingNetcore.Program.Something();
            Assert.AreEqual("something", result);
        }

        [TestMethod]
        public void TestLoginTrue()
        {
            bool result = FirstUnitTestingNetcore.Program.Login("ariel", "123456");
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestLoginFalse()
        {
            bool result = FirstUnitTestingNetcore.Program.Login("ariel", "65464654");
            Assert.AreEqual(false, result);
        }
    }
}
