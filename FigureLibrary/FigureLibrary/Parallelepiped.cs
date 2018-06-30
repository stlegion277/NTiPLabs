using System;
using System.Runtime.Serialization;


namespace FigureLibrary
{
    /// <summary>
    /// Класс параллелепипед отнаследованный от абстрактного класса FigureBase
    /// </summary>
    [DataContract]
    public class Parallelepiped : FigureBase
    {

        //TODO: Во всех свойствах не убрали дубли проверки на значение.//сделал
        /// <summary>
        /// свойство поля Длина(Length)
        /// </summary>
        [DataMember]
        public double Length { get; private set; }

        /// <summary>
        /// свойство поля Ширина(width)
        /// </summary>
        [DataMember]
        public double Width { get; private set; }

        /// <summary>
        /// свойство поля Высота(Height)
        /// </summary>
        [DataMember]
        public double Height { get; private set; }
        /// <summary>
        /// Конструктор класса <see cref="Parallelepiped"/>
        /// </summary>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        public Parallelepiped(double length, double width, double height)
        {
            //TODO: Проверка везде дублируется + текст сообщений ВСЕХ в конструкторах также надублирован, что привело к 
            //TODO: Некорректной копипасте сообщения из свойcтв //сделал
            Length = CheckValue(length);
            Width = CheckValue(width);
            Height = CheckValue(height);
        }
 //TODO: XML
        /// <summary>
        /// Расчет обьема Параллелепипеда
        /// </summary>
        public override double Amount
        {
            get
            {
                return Length * Width * Height;
            }

            set { }

        }

        /// <summary>
        /// возврат типа фигуры Параллелепипед
        /// </summary>
        public override string FigureType { get; set; } = "Parallelepied";
    }
}
