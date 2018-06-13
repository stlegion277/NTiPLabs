using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary;
using NUnit.Framework;
using NUnit.Framework.Internal;

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
        [TestCase(Int32.MaxValue, Int32.MaxValue, Description = "Максимальное значение полей")]
        public void PositiveTest(Int32 area, Int32 height)
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
        [TestCase(Int32.MinValue, Int32.MinValue, Description = "Минимальное значение полей")]
        public void NegativeTest(Int32 area, Int32 height)
        {
            Assert.Throws<Exception>
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
        [TestCase(Int32.MaxValue, Int32.MaxValue, Description = "Максимальное значение полей")]
        public void AmountPositiveTest(Int32 area, Int32 height)
        {
            var pyramid = new Pyramid(area,height);
            var expected = (area * height) / 3.0;
            var actual = pyramid.Amount;
            Assert.AreEqual(expected,actual);

        }
    }
}
