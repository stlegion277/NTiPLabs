using System;

namespace FigureLibrary
{ //TODO: XML//сделал

    /// <summary>
    /// Класс пирамида отнаследованный от абстрактного класса FigureBase
    /// </summary>
    public class Pyramid : FigureBase
    { //TODO: XML//сделал

        /// <summary>
        /// поля для расчета обьема пирамиды
        /// </summary>
        private double _area;
        private double _height;
 //TODO: XML

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
 //TODO: XML

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
        {//TODO: Проверка входных параметров?//сделал(надеюсь правильно)
            if (area > 0)
            {
                Area = area;
            }
            else
            {
                throw new Exception("Значение должно быть положительным");
            }

            if (height > 0)
            {
                Height = height;
            }
            else
            {
                throw  new Exception("Значение должно быть положительным");
            }
           
        }
 //TODO: XML
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
