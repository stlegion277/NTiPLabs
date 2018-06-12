using System;

namespace FigureLibrary
{ //TODO: XML
    public class Pyramid : FigureBase
    { //TODO: XML
        private double _area;
        private double _height;
 //TODO: XML
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
        {//TODO: Проверка входных параметров?
            Area = area;
            Height = height;
        }
 //TODO: XML
        public override double GetAmount
        {
            get
            {
                return (Area * Height) / 3.0;
            }

        }
    }
}
