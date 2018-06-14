
using System;

namespace FigureLibrary
{
    /// <summary>
    /// Свойство подсчета обьема
    /// </summary>
    public abstract class FigureBase
    {
        /// <summary>
        /// свойство для расчета обьема фигур
        /// </summary>
        public abstract double Amount { get; }

        /// <summary>
        /// константное значение для ограничения значения сверху TODO: Зачем паблик? RSDN. XML.//сделал
        /// </summary>
        private const double Upperlimit = 1000000;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        protected double CheckValue(double a)
        {
            if (a > Upperlimit)
            {
                throw new ArgumentException("BLA BLA");
            }

            if (a < 0)
            {
                throw new ArgumentException("BLA BLA");
            }
            return a;
        }

    }
}
