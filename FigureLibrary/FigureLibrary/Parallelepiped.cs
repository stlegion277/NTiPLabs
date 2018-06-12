using System;


namespace FigureLibrary
{ //TODO: XML//сделал

    /// <summary>
    /// Класс параллелепипед отнаследованный от абстрактного класса FigureBase
    /// </summary>
    public class Parallelepiped : FigureBase
    { //TODO: XML
        /// <summary>
        /// Поля для расчета обьема параллелепипеда
        /// </summary>
        private double _a;
        private double _b;
        private double _c;
 //TODO: XML
        /// <summary>
        /// свойство поля А
        /// </summary>
        public double A
        {
            get
            {
                return _a;
            }

            private set
            {
                if (value < 0)
                {
                    throw new Exception("Значение должно быть положительным");
                }
                _a = value;
            }
        } //TODO: XML

        /// <summary>
        /// свойство поля Б
        /// </summary>
        public double B
        {
            get
            {
                return _b;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Значение должно быть положительным");
                }
                _b = value;
            }
        } //TODO: XML

        /// <summary>
        /// свойство поля С
        /// </summary>
        public double C
        {
            get
            {
                return _c;
            }
            private set
            {
                if (value < 0)
                {
                    throw new Exception("Значение должно быть положительным");
                }
                _c = value;
            }
        }
        /// <summary>
        /// Конструктор класса <see cref="Parallelepiped"/>
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Parallelepiped(double a, double b, double c)
        {
            //TODO: Где проверки на значения сверху?//сделал
            if (a > 0)
            {
                A = a;
            }
            else
            {
                throw new Exception("Значение должно быть положительным");
            }

            if (b > 0)
            {
                B = b;
            }
            else
            {
                throw new Exception("Значение должно быть положительным");
            }

            if (c > 0)
            {
                C = c;
            }
            else
            {
                throw new Exception("Значение должно быть положительным");
            }
        }
 //TODO: XML
        /// <summary>
        /// Расчет обьема Параллелепипеда
        /// </summary>
        public override double Amount
        {
            get
            {
                return A * B * C;
            }
            
        }
    }
}
