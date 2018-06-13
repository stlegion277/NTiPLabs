
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
        public const double upperlimit = 1000000;
        

    }
}
