using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Parallelepiped : FigureBase
    {
        private double _a;
        private double _b;
        private double _c;

        public double A
        {
            get { return _a; }

            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Значение должно быть положительным");
                }
                _a = value;
            }
        }
        public double B
        {
            get { return _b; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Значение должно быть положительным");
                }
                _b = value;
            }
        }
        public double C
        {
            get { return _c; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Значение должно быть положительным");
                }
                _c = value;
            }
        }
        /// <summary>
        /// Конструктор класса Параллелепипед
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="c"></param>
        public Parallelepiped(double a, double b, double c)
        {
            A = a;
            B = b;  
            C = c;
        }

        public double GetAmount()
        {
            return A * B * C;
        }
    }
}
