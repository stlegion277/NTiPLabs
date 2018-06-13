using System;

namespace FigureLibrary
{
    /// <summary>
    /// Класс пирамида отнаследованный от абстрактного класса FigureBase
    /// </summary>
    public class Pyramid : FigureBase
    {
        /// <summary>
        /// поле area(площадь) для расчета обьема пирамиды
        /// </summary>
        private double _area;
        /// <summary>
        /// поле height(высота) для расчета обьема пирамиды
        /// </summary>
        private double _height;


        /// <summary>
        /// свойство поля Area(площадь)
        /// </summary>
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

        /// <summary>
        /// свойство поля Height(высота)
        /// </summary>
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
            if (area < upperlimit)
            {
                Area = area;
            }
            else
            {
                throw new Exception("Значение должно быть не больше 1000000 ");
            }

            if (height < upperlimit)
            {
                Height = height;
            }
            else
            {
                throw  new Exception("Значение должно быть не больше 1000000");
            }
           
        }

        /// <summary>
        /// Расчет обьема Пирамиды
        /// </summary>
        public override double Amount
        {
            get
            {
                return (Area * Height) / 3.0;
            }

        }
    }
}
