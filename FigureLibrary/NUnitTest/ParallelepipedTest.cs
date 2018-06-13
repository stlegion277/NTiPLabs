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
        public void ParallelepipedPositiveTest(Double a, Double b, Double c)
        {
            var parallelepiped = new Parallelepiped(a, b ,c);
        }

        [Test]
        [TestCase(-1, -3, -5, Description = "Значения полей -1, -3, -5")]
        [TestCase(Double.MinValue, Double.MinValue, Double.MinValue, Description = "Значения сторон минимальны")]
        public void ParallelepipedNegativeTest(Double a, Double b, Double c)
        {
            Assert.Throws<Exception>
            (
                delegate
                {
                    var parallelepiped = new Parallelepiped(a, b, c);
                }
            );
        }

        [Test]
        [TestCase(222, 232, 43, Description = "Значения полей 222, 232, 43")]
        [TestCase(143, 100, 93, Description = "Значения полей 143, 100, 93")]
        public void ParallelepipedAmountTest(Double a, Double b, Double c)
        {
            var parallelepiped = new Parallelepiped(a, b ,c);
            var expected = a * b * c;
            var actual = parallelepiped.Amount;
            Assert.AreEqual(expected, actual);
        }

        

    }
}
