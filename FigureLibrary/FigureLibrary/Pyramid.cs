using System;

namespace FigureLibrary
{
    public class Pyramid : FigureBase
    {
        private double _area;
        private double _height;

        public double Area
        {
            get
            {
                return _area;
            }
            private set
            {
                if (value < 0)
                {
                   throw new Exception("Значение должно быть положительным");
                }
                _area = value;
            }
        }

        public double Height
        {
            get
            {
                return _height;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Значение должно быть положительным");
                }
                _height = value;
            }
        }

        /// <summary>
        /// Конструктор класса <see cref="Pyramid"/>
        /// </summary>
        /// <param name="area"></param>
        /// <param name="height"></param>
        public Pyramid(double area, double height)
        {
            Area = area;
            Height = height;
        }

        public override double GetAmount
        {
            get
            {
                return (Area * Height) / 3.0;
            }

        }
    }
}
