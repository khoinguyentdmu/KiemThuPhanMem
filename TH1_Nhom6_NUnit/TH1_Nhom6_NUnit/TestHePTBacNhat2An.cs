using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator;

namespace Nhom6_Test
{
    [TestFixture]
    class TestHePTBacNhat2An
    {
        private Calculator.pt pt;
        private double[] a;
        private double x, y;
        private string returnMessage;
        private const string voNghiem = "Hệ phương trình vô nghiệm";
        private const string khongPhaiHPT = "Không phải hệ phương trình";
        private const string voSoNghiem = "Hệ phương trình vô số nghiệm";
        private const string coNghiem = "Hệ phương trình có 1 nghiệm";

        /// <summary>
        /// Setup
        /// </summary>
        [SetUp]
        public void TestSetup()
        {
            pt = new pt();
        }

        /// <summary>
        /// Test hệ phương trình có 2 nghiệm
        /// </summary>
        [Test]
        public void TestHPTCo2Nghiem()
        {
            this.a = new double[] { 5, 3, 11, 6, 2, 10 };
            x = -1;
            y = -1;

            this.returnMessage = pt.GiaiHPTbacnhat2an(a[0], a[1], a[2], a[3], a[4], a[5], ref x, ref y);

            Assert.AreEqual(coNghiem, this.returnMessage);
            Assert.AreEqual(x, 1);
            Assert.AreEqual(y, 2);
        }

        /// <summary>
        /// Test hệ phương tình vô số nghiệm
        /// </summary>
        [Test]
        public void TestHPTVoSoNghiem()
        {
            this.a = new double[] { 1, 2, 3, 1, 2, 3 };
            x = -1;
            y = -1;

            this.returnMessage = pt.GiaiHPTbacnhat2an(a[0], a[1], a[2], a[3], a[4], a[5], ref x, ref y);

            Assert.AreEqual(voSoNghiem, this.returnMessage);
            Assert.AreEqual(x, -1);
            Assert.AreEqual(y, -1);
        }

        /// <summary>
        /// Test hệ phương trình vô nghiệm
        /// </summary>
        [Test]
        public void TestHPTVoNghiem()
        {
            this.a = new double[] { 1, 2, 3, 1, 2, 4 };
            x = -1;
            y = -1;

            this.returnMessage = pt.GiaiHPTbacnhat2an(a[0], a[1], a[2], a[3], a[4], a[5], ref x, ref y);

            Assert.AreEqual(voNghiem, this.returnMessage);
            Assert.AreEqual(x, -1);
            Assert.AreEqual(y, -1);
        }

        /// <summary>
        /// Test không phải hệ phương trình bậc 2 với a1 = b1 = 0
        /// </summary>
        [Test]
        public void TestKhongPhaiHPT_a1b1_KhongHopLe()
        {
            this.a = new double[] { 0, 0, 3, 1, 2, 4 };
            x = -1;
            y = -1;

            this.returnMessage = pt.GiaiHPTbacnhat2an(a[0], a[1], a[2], a[3], a[4], a[5], ref x, ref y);

            Assert.AreEqual(khongPhaiHPT, this.returnMessage);
            Assert.AreEqual(x, -1);
            Assert.AreEqual(y, -1);
        }

        /// <summary>
        /// Test không phải hệ phương trình bậc 2 với a1 = b1 = 0
        /// </summary>
        [Test]
        public void TestKhongPhaiHPT_a2b2_KhongHopLe()
        {
            this.a = new double[] { 1, 2, 3, 0, 0, 4 };
            x = -1;
            y = -1;

            this.returnMessage = pt.GiaiHPTbacnhat2an(a[0], a[1], a[2], a[3], a[4], a[5], ref x, ref y);

            Assert.AreEqual(khongPhaiHPT, this.returnMessage);
            Assert.AreEqual(x, -1);
            Assert.AreEqual(y, -1);
        }

        /// <summary>
        /// Teardown
        /// </summary>
        [TearDown]
        public void TestTearDown()
        {
            pt = null;
        }
    }
}
