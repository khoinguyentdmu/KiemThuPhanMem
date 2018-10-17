using NUnit.Framework;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom6_Test
{
    [TestFixture]
    class Test_GiaiHPTBacNhat3An
    {
        private pt operation;
        private double x, y, z, a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3;
        private string voSoNghiem = "Hệ phương trình vô số nghiệm";
        private string voNghiem = "Hệ phương trình vô nghiệm";
        private string coNghiem = "Hệ phương trình có 1 nghiệm";
        [SetUp] // Sửa lại cho phù hợp với NUnit hiện tại
        public void SetUp()
        {
            operation = new pt();
        }

        [TearDown] // Sửa lại cho phù hợp với NUnit hiện tại
        public void TearDown()
        {
            operation = null;
        }

        [Test]
        /// Kỳ vọng hệ phương trình vô số nghiệm
        public void TC_HPT3A_01()
        {
            a1 = 0;
            b1 = 0;
            c1 = 0;
            d1 = 0;
            a2 = 0;
            b2 = 0;
            c2 = 0;
            d2 = 0;
            a3 = 0;
            b3 = 0;
            c3 = 0;
            d3 = 0;
            Assert.AreEqual(voSoNghiem, operation.GiaiHPTbacnhat3an(a1, b1, c1, d1, a2, b2, c2, d2, a3, b3, c3, d3, ref x, ref y, ref z));
        }

        [Test]
        /// Kỳ vọng hệ phương trình vô số nghiệm
        public void TC_HPT3A_02()
        {
            a1 = -100;
            b1 = -100;
            c1 = -100;
            d1 = 0;
            a2 = 0;
            b2 = 0;
            c2 = 0;
            d2 = 0;
            a3 = 0;
            b3 = 0;
            c3 = 0;
            d3 = 0;
            Assert.AreEqual(voSoNghiem, operation.GiaiHPTbacnhat3an(a1, b1, c1, d1, a2, b2, c2, d2, a3, b3, c3, d3, ref x, ref y, ref z));
        }

        [Test]
        /// Kỳ vọng hệ phương trình vô số nghiệm
        public void TC_HPT3A_03()
        {
            a1 = 100;
            b1 = 100;
            c1 = 100;
            d1 = 0;
            a2 = 0;
            b2 = 0;
            c2 = 0;
            d2 = 0;
            a3 = 0;
            b3 = 0;
            c3 = 0;
            d3 = 0;
            Assert.AreEqual(voSoNghiem, operation.GiaiHPTbacnhat3an(a1, b1, c1, d1, a2, b2, c2, d2, a3, b3, c3, d3, ref x, ref y, ref z));
        }

        [Test]
        /// Kỳ vọng hệ phương trình vô nghiệm
        public void TC_HPT3A_04()
        {
            a1 = 0;
            b1 = 0;
            c1 = 0;
            d1 = 1;
            a2 = 0;
            b2 = 0;
            c2 = 0;
            d2 = 0;
            a3 = 0;
            b3 = 0;
            c3 = 0;
            d3 = 0;
            Assert.AreEqual(voNghiem, operation.GiaiHPTbacnhat3an(a1, b1, c1, d1, a2, b2, c2, d2, a3, b3, c3, d3, ref x, ref y, ref z));
        }

        [Test]
        /// Kỳ vọng hệ phương trình vô nghiệm
        public void TC_HPT3A_05()
        {
            a1 = 0;
            b1 = 0;
            c1 = 0;
            d1 = -1;
            a2 = 0;
            b2 = 0;
            c2 = 0;
            d2 = 0;
            a3 = 0;
            b3 = 0;
            c3 = 0;
            d3 = 0;
            Assert.AreEqual(voNghiem, operation.GiaiHPTbacnhat3an(a1, b1, c1, d1, a2, b2, c2, d2, a3, b3, c3, d3, ref x, ref y, ref z));
        }

        [Test]
        /// Kỳ vọng hệ phương trình có 1 nghiệm
        /// x=1; y=2; z=3
        public void TC_HPT3A_06()
        {
            a1 = 1;
            b1 = 1;
            c1 = 1;
            d1 = 6;
            a2 = 1;
            b2 = -1;
            c2 = 1;
            d2 = 2;
            a3 = 1;
            b3 = 1;
            c3 = -1;
            d3 = 0;
            Assert.AreEqual(coNghiem, operation.GiaiHPTbacnhat3an(a1, b1, c1, d1, a2, b2, c2, d2, a3, b3, c3, d3, ref x, ref y, ref z));
            Assert.AreEqual(1, x);
            Assert.AreEqual(2, y);
            Assert.AreEqual(3, z);
        }

        [Test]
        /// Kỳ vọng hệ phương trình có 1 nghiệm
        /// x=1; y=1; z=1
        public void TC_HPT3A_07()
        {
            a1 = 3;
            b1 = 3;
            c1 = 3;
            d1 = 9;
            a2 = 3;
            b2 = -3;
            c2 = 3;
            d2 = 3;
            a3 = 3;
            b3 = 3;
            c3 = -3;
            d3 = 3;
            Assert.AreEqual(coNghiem, operation.GiaiHPTbacnhat3an(a1, b1, c1, d1, a2, b2, c2, d2, a3, b3, c3, d3, ref x, ref y, ref z));
            Assert.AreEqual(1, x);
            Assert.AreEqual(1, y);
            Assert.AreEqual(1, z);
        }

        [Test]
        /// Kỳ vọng hệ phương trình có 1 nghiệm
        /// x=-1; y=-1; z=-1
        public void TC_HPT3A_08()
        {
            a1 = -2;
            b1 = -3;
            c1 = 5;
            d1 = 0;
            a2 = 4;
            b2 = 3;
            c2 = 2;
            d2 = -9;
            a3 = 1;
            b3 = 2;
            c3 = -3;
            d3 = 0;
            Assert.AreEqual(coNghiem, operation.GiaiHPTbacnhat3an(a1, b1, c1, d1, a2, b2, c2, d2, a3, b3, c3, d3, ref x, ref y, ref z));
            Assert.AreEqual(-1, x);
            Assert.AreEqual(-1, y);
            Assert.AreEqual(-1, z);
        }
    }
}
