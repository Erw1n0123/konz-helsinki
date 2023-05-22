using Microsoft.VisualStudio.TestTools.UnitTesting;
using helsinki1952;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helsinki1952.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void PontTest()
        {
            Assert.AreEqual(7, Program.Pont(1));
        }

        [TestMethod()]
        public void PontTest2()
        {
            Assert.AreEqual(5, Program.Pont(2));
            Assert.AreEqual(4, Program.Pont(3));
            Assert.AreEqual(3, Program.Pont(4));
            Assert.AreEqual(2, Program.Pont(5));
            Assert.AreEqual(1, Program.Pont(6));
        }

        [TestMethod()]
        public void PontTest3()
        {
            Assert.AreEqual(0, Program.Pont(7));
        }
    }
}