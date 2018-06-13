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
     internal class SphereTest
    {
        [Test]
        [TestCase(3, Description = "Значение радиуса = 3")]
        [TestCase(Int32.MaxValue, Description = "Максимальное значение радиуса")]
        public void PositiveSphereTest(Int32 radius)
        {
            var sphere = new Sphere(radius);
        }

        [Test]
        [TestCase(-1, Description = "Значение радиуса = -1")]
        [TestCase(Int32.MinValue, Description = "Минмальное значение радиуса")]
        public void NegativeSphereTest(Int32 radius)
        {
            Assert.Throws<Exception>
            (
                delegate
                {
                    var sphere = new Sphere(radius);
                }
            );
        }

        [Test]
        [TestCase(23, Description = "Значение радиуса = 23")]
        [TestCase(643, Description = "Значение радиуса = 643")]
        public void SphereAmountTest(Int32 radius)
        {
            var sphere = new Sphere(radius);
            var expected = (4 / 3) * Math.PI * radius * radius * radius;
            var actual = sphere.Amount;
            Assert.AreEqual(expected, actual);

        }
    }
}
