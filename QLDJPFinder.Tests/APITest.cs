using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLDJPFinder.Core;

namespace QLDJPFinder.Tests
{
    [TestClass]
    public class APITest
    {
        [TestMethod]
        public void TestJSONDeserialize()
        {
            var api = new JPFinderAPI();
            var result = api.GetJPList("4000", 5).Result;

            Assert.AreEqual(result.Count, 5);
        }
    }
}
