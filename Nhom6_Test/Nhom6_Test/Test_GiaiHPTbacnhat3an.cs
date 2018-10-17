﻿using NUnit.Framework;
using Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom6_Test
{
    [TestFixture]
    class Test_GiaiHPTbacnhat3an
    {
        private pt operation;
        private double x, y, z, a1, a2, a3, b1, b2, b3, c1, c2, c3, d1, d2, d3;
        private string voSoNghiem = "Hệ phương trình vô số nghiệm";
        private string voNghiem = "Hệ phương trình vô nghiệm";
        private string co1Nghiem = "Hệ phương trình có 1 nghiệm";
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
        public void TC_HPT3A_02()
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
        public void TC_HPT3A_03()
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
            Assert.AreEqual(co1Nghiem, operation.GiaiHPTbacnhat3an(a1, b1, c1, d1, a2, b2, c2, d2, a3, b3, c3, d3, ref x, ref y, ref z));
            Assert.AreEqual(1, x);
            Assert.AreEqual(2, y);
            Assert.AreEqual(3, z);
        }
    }
}
