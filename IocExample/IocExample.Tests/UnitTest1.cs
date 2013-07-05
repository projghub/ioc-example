using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IocExample.Tests
{
    [TestClass]
    public class DerpTests
    {
        [TestInitialize]
        public void Initialize()
        {
            Container container = new Container();
        }

        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }
    }
}
