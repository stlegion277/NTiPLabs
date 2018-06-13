using System;

namespace FigureLibrary
{
    /// <summary>
    /// Класс шар отнаследованный от абстрактного класса FigureBase
    /// </summary>
    public class Sphere : FigureBase
    {
        /// <summary>
        /// Поле радиус для расчета обьема шара
        /// </summary>
        private double _radius;

        /// <summary>
        /// свойство поля Radius
        /// </summary>
        public double Radius
        {
            get
            {
                return _radius;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Значение должно быть положительным");
                }
                _radius = value;
            }
        }

        /// <summary>
        /// Конструктор класса <see cref="Sphere"/>
        /// </summary>
        /// <param name="radius"></param>
        public Sphere(double radius)
        {
            if (radius < upperlimit)
            {
                Radius = radius;
            }
            else
            {
                throw new Exception("Значение должно быть не больше 1000000");
            }
            
        }

        /// <summary>
        /// расчет обьема Шара
        /// </summary>
        public override double Amount
        {
            get
            {
                return (4 / 3) * Math.PI * Radius * Radius * Radius;
            }
        }
    }
}
