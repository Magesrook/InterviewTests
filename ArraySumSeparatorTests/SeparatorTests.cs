using ArraySumSeparator;
using NUnit.Framework;

namespace ArraySumSeparatorTests
{
    [TestFixture]
    public class Tests
    {

        [TestCase(new int[] { 1, 2, 3, 4, 3, 2, 1 }, 3)]
        [TestCase(new int[] { 1, 100, 50, -51, 1, 1 }, 1)]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, -1)]
        [TestCase(new int[] { 20, 10, 30, 10, 10, 15, 35 }, 3)]
        [TestCase(new int[] { 8, 8 }, -1)]
        [TestCase(new int[] { 8, 0 }, 0)]
        [TestCase(new int[] { 0, 8 }, 1)]
        [TestCase(new int[] { 7, 3, -3 }, 0)]
        [TestCase(new int[] { 8 }, 0)]
        [TestCase(new int[] { -5021, 1087, 2775, 4555, -4380, -1783, 4322, 9979, -9660, 11215 }, 7)]
        [TestCase(new int[] { 5426, 8706, -1446, 3472, 7670, 6149, 7255, -2021, -8710, 1196, -6251, -4976, 3586, 1027, 1405, 4646, 309, -3024, 9520, 7200 }, 13)]
        [TestCase(new int[] { 9403, -1742, -2511, -9514, 997, -5291, 7697, 1921, 9913, -1099, 9031, -9413, -9266, 4233 }, -1)]
        [TestCase(new int[] { 1097, -5986, -2065, -9775, -3466, -3815, 4734, 4664, -3322, 3399, -2659, 7761, -8733, -746, -6748, 5219, -4654, -9662, -7079, -347, 6790, -2745, 1085, 1637, -9156, -7933, -841, -5247, 2867, -5381, 15006 }, 15)]
        [Category("ArraySumSeparatorTests")]
        public void ArraySumSeparatorTests(int[] input, int expected)
        {
            Assert.AreEqual(expected, Program.FindSeparator(input));
        }
    }
}