using System;


namespace FigureLibrary
{ //TODO: XML
    public class Parallelepiped : FigureBase
    { //TODO: XML
        private double _a;
        private double _b;
        private double _c;
 //TODO: XML
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
            //TODO: Где проверки на значения сверху?
            A = a;
            B = b;  
            C = c;
        }
 //TODO: XML
        public override double GetAmount
        {
            get
            {
                return A * B * C;
            }
            
        }
    }
}
