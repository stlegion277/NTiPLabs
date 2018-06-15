using System;
using FigureLibrary;
using NUnit.Framework;

namespace NUnitTest
{
   [TestFixture]
   internal class PyramidTest
    {
        /// <summary>
        /// Тест на положительное значение полей
        /// </summary>
        /// <param name="area"></param>
        /// <param name="height"></param>
        [Test]
        [TestCase(1, 1, Description = "Значения полей = 1")]
        [TestCase(320, 549, Description = "Значение площади = 320, значение высоты = 549")]
        [TestCase(100000, 1, Description = "Максимальное значение полей")]
        public void PositiveTest(Double area, Double height)
        {
            var pyramid = new Pyramid(area, height);
        }

        /// <summary>
        /// Тест на отрицательное значение полей
        /// </summary>
        /// <param name="area"></param>
        /// <param name="height"></param>
        [Test]
        [TestCase(-1, -1, Description = "Отрицательное значение полей")]
        [TestCase(-43, -54, Description = "Отрицательное значение полей")]
        [TestCase(Double.MinValue, Double.MinValue, Description = "Минимальное значение полей")]
        public void NegativeTest(Double area, Double height)
        {
            Assert.Throws<ArgumentException>
                (
                    delegate
                    {
                        var pyramid = new Pyramid(area, height);
                    }
                );

        }

        [Test]
        [TestCase(1, 1, Description = "Значения полей = 1")]
        [TestCase(320, 549, Description = "Значение площади = 320, значение высоты = 549")]
        [TestCase(100000, 1, Description = "Максимальное значение полей")]
        public void AmountPositiveTest(Double area, Double height)
        {
            var pyramid = new Pyramid(area,height);
            var expected = (area * height) / 3.0;
            var actual = pyramid.Amount;
            Assert.AreEqual(expected,actual);
            Assert.AreEqual(pyramid.Area,area);
            Assert.AreEqual(pyramid.Height,height);
        }
    }
}
