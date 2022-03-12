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
            //Arrange
            string user = "ariel";
            string pass = "123456";

            // Act
            bool result = FirstUnitTestingNetcore.Program.Login(user, pass);

            // Assert   
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
