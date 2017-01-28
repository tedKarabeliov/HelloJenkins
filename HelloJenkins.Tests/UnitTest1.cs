namespace HelloJenkins.Tests
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using HelloJenkins;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Hello Jenkins", Program.CreateMessage());
        }
    }
}
