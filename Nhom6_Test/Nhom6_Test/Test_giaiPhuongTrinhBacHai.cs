using Calculator;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom6_Test
{
    [TestFixture]
    class Test_giaiPhuongTrinhBacHai
    {

        private pt operation;
        private double x1, x2;
        private string voSoNghiem = "Phương trình vô số nghiệm";
        private string voNghiem = "Phương trình vô nghiệm";
        private string motNghiem = "Phương trình có 1 nghiệm";
        private string haiNghiem = "Phương trình có 2 nghiệm";
        [SetUp]
        public void SetUp()
        {
            operation = new Pheptoan();
        }
        [TearDown]
        public void TearDown()
        {
            operation = null;
        }
        [Test]
        public void Test_ptVoSoNghiem()
        {
            Assert.AreEqual(voSoNghiem,operation.giaiPhuongTrinhBacHai(0, 0, 0, ref x1, ref x2).ToString());
        }
        [Test]
        public void Test_ptVoNghiem()//vô nghiệm với c#0
        {
            Assert.AreEqual(voNghiem,operation.giaiPhuongTrinhBacHai(0, 0, 1, ref x1, ref x2).ToString());
        }
        [Test]
        public void Test_ptCoMotNghiem()//1 nghiệm với pt 1 ẩn ( a=0,b#0,c#0)
        {
            Assert.AreEqual(motNghiem,operation.giaiPhuongTrinhBacHai(0, 4, 2, ref x1, ref x2).ToString());
            Assert.AreEqual(-0.5, x1);
        }
        [Test]
        public void Test_ptVoNghiem1()//vô nghiệm với delta<0 (delta = b * b - 4 * a * c);
        {
            Assert.AreEqual(voNghiem,operation.giaiPhuongTrinhBacHai(2, 3, 3, ref x1, ref x2).ToString() );
        }
        [Test]
        public void Test_ptCoMotNghiem1()//một nghiệm với delta = 0
        {
            Assert.AreEqual(motNghiem,operation.giaiPhuongTrinhBacHai(2, 4, 2, ref x1, ref x2).ToString());
            Assert.AreEqual(-1,x1);
        }
        [Test]
        public void Test_ptCoHaiNghiem()//hai nghiệm với delta > 0
        {
            Assert.AreEqual(haiNghiem,operation.giaiPhuongTrinhBacHai(2, 5, 2, ref x1, ref x2).ToString());
            Assert.AreEqual(2, x1);
            Assert.AreEqual(-0.5, x2);
        }
    }
}
