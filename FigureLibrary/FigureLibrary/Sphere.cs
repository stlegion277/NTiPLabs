using System;

namespace FigureLibrary
{
    /// <summary>
    /// 
    /// </summary>
    public class Sphere : FigureBase
    {
        /// <summary>
        /// 
        /// </summary>
        private double _radius;

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
            Radius = radius;
        }

        public override double GetAmount
        {
            get
            {
                return 1.33 * Math.PI * Radius * Radius * Radius;

            }
        }
    }
}
