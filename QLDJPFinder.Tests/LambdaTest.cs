using Alexa.NET.Request;
using Alexa.NET.Request.Type;
using Amazon.Lambda.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QLDJPFinder.Core;
using QLDJPFinder.Lambda;

namespace QLDJPFinder.Tests
{
    [TestClass]
    public class LambdaTest
    {
        [TestMethod]
        public void TestLambaConstructor()
        {
            var func = new Function();
            func.FunctionHandler(new SkillRequest { Request = new LaunchRequest() }, null);
        }
    }
}
