using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinByDelegatePractice;

namespace MinByTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShortestStringIsReturned()
        {
            Assert.AreEqual("h", new string[] { "lol", "asdf", "h", "hello world" }.MinBy(x => x.Length));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ThrowsIfEmpty()
        {
            Assert.AreEqual("h", new string[] { }.MinBy(x => x.Length));
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void ThrowsIfNull()
        {
            string[] arr = null;
            Assert.AreEqual("h", arr.MinBy(x => x.Length));
        }

        [TestMethod]
        public void YoungestDogIsReturned()
        {
            Dog[] dogs = ExtensionMethods.GetDogs();
            Assert.AreEqual("Lucky", dogs.MinBy(x => x.Age).Name);
        }

        [TestMethod]
        public void DogWithShortestNameReturned()
        {
            Dog[] dogs = ExtensionMethods.GetDogs();
            Assert.AreEqual("Bo", dogs.MinBy(x => x.Name.Length).Name);
        }
    }
}
