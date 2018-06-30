using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;



namespace FigureLibrary
{
    /// <summary>
    /// Класс шар отнаследованный от абстрактного класса FigureBase
    /// </summary>
    [DataContract]
    public class Sphere : FigureBase
    {
        //TODO: Во всех свойствах не убрали дубли проверки на значение.//сделал
        /// <summary>
        /// свойство поля Radius
        /// </summary>
        [DataMember]
        public double Radius { get; private set; }

        /// <summary>
        /// Конструктор класса <see cref="Sphere"/>
        /// </summary>
        /// <param name="radius"></param>
        public Sphere(double radius)
        {//TODO: Проверка везде дублируется + текст сообщений ВСЕХ в конструкторах также надублирован, что привело к 
            //TODO: Некорректной копипасте сообщения из свойств//сделал
            Radius = CheckValue(radius);
        }

        /// <summary>
        /// расчет обьема Шара
        /// </summary>
        public override double Amount
        {
            get
            {
                return (4.0 / 3.0) * Math.PI * Radius * Radius * Radius;
            }
            set { }
        }

        /// <summary>
        /// возврат типа фигуры Шар
        /// </summary>
        public override string FigureType { get; set; } = "Sphere";
    }
}
