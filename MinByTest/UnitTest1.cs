using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinByDelegatePractice;

namespace MinByTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void VerifyShortestIsReturned()
        {
            Assert.AreEqual("h", new string[] { "lol", "asdf", "h", "hello world" }.MinBy(x => x.Length));
        }
    }
}
