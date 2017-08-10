using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Kata20170810_BuildAPileOfCubes
{
    [TestClass]
    public class BuildAPileOfCubesTests
    {
        [TestMethod]
        public void input_9_should_return_2()
        {
            ASumFindNbShouldBe(2, 9);
        }

        [TestMethod]
        public void input_28_should_return_3()
        {
            ASumFindNbShouldBe(3, 28);
        }

        private static void ASumFindNbShouldBe(int expected, int number)
        {
            var aSum = new ASum();
            var actual = aSum.findNb(number);
            Assert.AreEqual(expected, actual);
        }
    }

    public class ASum
    {
        public long findNb(long m)
        {
            return (long) Math.Pow(m - 1, 1 / 3.0);
        }
    }
}
