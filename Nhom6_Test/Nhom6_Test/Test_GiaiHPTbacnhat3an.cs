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
    class Test_GiaiHPTbacnhat3an
    {
        private pt operation;
        private double x, y, z;
        private string voSoNghiem = "Hệ phương trình vô số nghiệm";
        private string voNghiem = "Hệ phương trình vô nghiệm";
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
            Assert.AreEqual(voSoNghiem, operation.GiaiHPTbacnhat3an(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, ref x, ref y, ref z));
        }
        [Test]
        public void TC_HPT3A_02()
        {
            Assert.AreEqual(voNghiem, operation.GiaiHPTbacnhat3an(0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, ref x, ref y, ref z));
        }
    }
}
