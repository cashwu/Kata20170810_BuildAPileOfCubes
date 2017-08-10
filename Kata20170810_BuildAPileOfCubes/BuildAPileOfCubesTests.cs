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
        public void input_36_should_return_3()
        {
            ASumFindNbShouldBe(3, 36);
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
        public double findNb(long m)
        {
            var n = 1;
            var result = 0d;
            while (true)
            {
                result += Math.Pow(n, 3);

                if (result == m)
                {
                    return n;
                }

                if (result > m)
                {
                    return -1;
                }
                n++;
            }
        }
    }
}
