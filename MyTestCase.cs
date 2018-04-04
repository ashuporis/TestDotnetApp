using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitTestDemo
{
    [TestFixture]
    class MyTestCase
    {
        [TestCase]
        public void Add()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(30, math.Add(20, 10));
        }

        [TestCase]
        public void Sub()
        {
            MyMath math = new MyMath();
            Assert.AreEqual(10, math.Subtract(20, 10));
        }
    }
}
