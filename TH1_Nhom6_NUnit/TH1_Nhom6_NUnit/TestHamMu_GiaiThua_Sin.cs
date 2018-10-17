using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator;
using NUnit.Framework;

namespace Nhom6_Test
{
    [TestFixture]
    class TestHamMu_GiaiThua_Sin
    {
        private Calculator.Calculator cal;

        /// <summary>
        /// Setup
        /// </summary>
        [SetUp]
        public void TestSetup()
        {
            cal = new Calculator.Calculator();
        }

        /// <summary>
        /// Test hàm mũ với hệ số a dương
        /// </summary>
        [Test]
        public void TestHamMu_HeSoA_Duong()
        {
            double a = 2;
            double actual = cal.mu2(a);
            const double expected = 4;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test hàm mũ với hệ số a âm
        /// </summary>
        [Test]
        public void TestHamMu_HeSoA_Am()
        {
            double a = -5;
            double actual = cal.mu2(a);
            const double expected = 25;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test hàm mũ với hệ số a bằng 0
        /// </summary>
        [Test]
        public void TestHamMu_HeSoA_BangKhong()
        {
            double a = 0;
            double actual = cal.mu2(a);
            const double expected = 0;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test hàm giai thừa với hệ số a dương
        /// </summary>
        [Test]
        public void TestHamGiaiThua_HeSoA_Duong()
        {
            double a = 5;
            double actual = cal.tinhGT(a);
            const double expected = 120;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test hàm giai thừa với hệ số a âm
        /// </summary>
        [Test]
        public void TestHamGiaiThua_HeSoA_Am()
        {
            double a = -2;
            double actual = cal.tinhGT(a);
            const double expected = -1; //Quy định -1 là không tính được

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test hàm giai thừa với hệ số a bằng 0
        /// </summary>
        [Test]
        public void TestHamGiaiThua_HeSoA_BangKhong()
        {
            double a = 0;
            double actual = cal.tinhGT(a);
            const double expected = 1;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test hàm Sin với a = -90
        /// </summary>
        [Test]
        public void TestHamSin_HeSoA_BangAm90()
        {
            double a = -90;
            double actual = cal.Sin(a);
            const double expected = -1;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test hàm Sin với a = 90
        /// </summary>
        [Test]
        public void TestHamSin_HeSoA_BangDuong90()
        {
            double a = 90;
            double actual = cal.Sin(a);
            const double expected = 1;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Test hàm Sin với a = -90
        /// </summary>
        [Test]
        public void TestHamSin_HeSoA_Bang0()
        {
            double a = 0;
            double actual = cal.Sin(a);
            const double expected = 0;

            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Teardown
        /// </summary>
        [TearDown]
        public void TestTearDown()
        {
            cal = null;
        }
    }
}
