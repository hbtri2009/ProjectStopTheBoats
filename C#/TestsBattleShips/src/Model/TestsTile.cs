using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class TestsTile
    {
        [TestMethod()]
        public void TestTile()
        {
            Tile test = new Tile(10, 10, new Ship(ShipName.Destroyer));

            Assert.IsFalse(test.Shot);

            test.

            Assert.Fail();
        }

        [TestMethod()]
        public void TestClearShip()
        {
            Assert.Fail();
        }
    }
}