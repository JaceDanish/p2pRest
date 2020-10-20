using Microsoft.VisualStudio.TestTools.UnitTesting;
using p2pRest.ManagerDb;
using p2pRest.Model;
using System.Text.Json;

namespace UnitTestREST
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ManageRegistry mr = new ManageRegistry();

            FileEndPoint fep = new FileEndPoint("123", 555);

            string json = JsonSerializer.Serialize(fep);

            Assert.AreEqual(1, mr.Register("woop", json));
        }
    }
}
