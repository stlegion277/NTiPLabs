using System;

namespace FigureLibrary
{
    /// <summary>
    /// Класс пирамида отнаследованный от абстрактного класса FigureBase
    /// </summary>
    public class Pyramid : FigureBase
    {
        /// <summary>
        /// свойство поля Area(площадь)
        /// </summary>
        public double Area { get; }

        /// <summary>
        /// свойство поля Height(высота)
        /// </summary>
        public double Height { get; }

        /// <summary>
        /// Конструктор класса <see cref="Pyramid"/>
        /// </summary>
        /// <param name="area"></param>
        /// <param name="height"></param>
        public Pyramid(double area, double height)
        {
            //TODO: Проверка везде дублируется + текст сообщений ВСЕХ в конструкторах также надублирован, что привело к 
            //TODO: Некорректной копипасте сообщения из свойств//сделал
            Area = CheckValue(area);
            Height = CheckValue(height);
           
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
