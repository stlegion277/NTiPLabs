using System;


namespace FigureLibrary
{
    /// <summary>
    /// Класс параллелепипед отнаследованный от абстрактного класса FigureBase
    /// </summary>
    public class Parallelepiped : FigureBase
    {
        /// <summary>
        /// Поле А для расчета обьема параллелепипеда
        /// </summary>
        private double _a;
        /// <summary>
        /// Поле Б для расчета обьема параллелепипеда
        /// </summary>
        private double _b;
        /// <summary>
        /// Поле С для расчета обьема параллелепипеда
        /// </summary>
        private double _c;
       

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
        }

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
        }

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
            if (a < upperlimit)
            {
                A = a;
            }
            else
            {
                throw new Exception("Значение должно быть не больше 1000000");
            }

            if (b < upperlimit)
            {
                B = b;
            }
            else
            {
                throw new Exception("Значение должно быть не больше 1000000");
            }

            if (c < upperlimit)
            {
                C = c;
            }
            else
            {
                throw new Exception("Значение должно быть не больше 1000000");
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
