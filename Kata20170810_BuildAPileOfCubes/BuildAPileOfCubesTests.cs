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

        [TestMethod]
        public void input_4183059834009_should_return_2022()
        {
            ASumFindNbShouldBe(2022, 4183059834009);
        }

        [TestMethod]
        public void input_24723578342962_should_return_n1()
        {
            ASumFindNbShouldBe(-1, 24723578342962);
        }

        [TestMethod]
        public void input_135440716410000_should_return_4824()
        {
            ASumFindNbShouldBe(4824, 135440716410000);
        }

        [TestMethod]
        public void input_40539911473216_should_return_3568()
        {
            ASumFindNbShouldBe(3568, 40539911473216);
        }

        private static void ASumFindNbShouldBe(int expected, long number)
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
