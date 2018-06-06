using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigureLibrary
{
    public class Sphere : FigureBase
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            private set
            {
                if (value < 0)
                {
                    Console.WriteLine("Значение должно быть положительным");
                }
                _radius = value;
            }
        }

        /// <summary>
        /// Конструктор класса Шар
        /// </summary>
        /// <param name="radius"></param>
        public Sphere(double radius)
        {
            Radius = radius;
        }

        public double GetAmount()
        {
            return 1.33 * Math.PI * Radius * Radius * Radius;
        }
    }
}
