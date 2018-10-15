using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNUnit
{
    [TestFixture]
    class Sample
    {
        [Test]
        public void HelloWolrd()
        {
            Assert.AreEqual("HelloWorld", "HelloWorld");
        }
    }
}
