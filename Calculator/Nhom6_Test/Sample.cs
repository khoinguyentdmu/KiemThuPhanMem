using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Nhom6_Test
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
