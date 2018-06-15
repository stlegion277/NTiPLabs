using System;
using NUnit.Framework;
using FigureLibrary;
using NUnit.Framework.Internal;

namespace NUnitTest
{
    [TestFixture]
    internal class ParallelepipedTest
    {
        [Test]
        [TestCase(3, 4, 5, Description = "Значение сторон 3, 4, 5")]
        [TestCase(100, 101, 102, Description = "Значение сторон 100, 101, 102")]
        [TestCase(100000, 1, 1, Description = "Значения сторон максимальное")]
        public void ParallelepipedPositiveTest(Double length, Double width, Double height)
        {
            var parallelepiped = new Parallelepiped(length, width, height);
        }

        [Test]
        [TestCase(-1, -3, -5, Description = "Значения полей -1, -3, -5")]
        [TestCase(Double.MinValue, Double.MinValue, Double.MinValue, Description = "Значения сторон минимальны")]
        public void ParallelepipedNegativeTest(Double length, Double width, Double height)
        {
            Assert.Throws<ArgumentException>
            (
                delegate
                {
                    var parallelepiped = new Parallelepiped(length, width, height);
                }
            );
        }

        [Test]
        [TestCase(222, 232, 43, Description = "Значения полей 222, 232, 43")]
        [TestCase(143, 100, 93, Description = "Значения полей 143, 100, 93")]
        public void ParallelepipedAmountTest(Double length, Double width, Double height)
        {
            var parallelepiped = new Parallelepiped(length, width, height);
            var expected = length * width * height;
            var actual = parallelepiped.Amount;
            Assert.AreEqual(expected, actual);
            Assert.AreEqual(parallelepiped.Length, length);
            Assert.AreEqual(parallelepiped.Width, width);
            Assert.AreEqual(parallelepiped.Height, height);
        }
    }
}
