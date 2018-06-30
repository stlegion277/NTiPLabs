﻿
using System;
using System.Runtime.Serialization;

namespace FigureLibrary
{
    /// <summary>
    /// Свойство подсчета обьема
    /// </summary>
    [DataContract]
    public abstract class FigureBase
    {
        /// <summary>
        /// свойство для расчета обьема фигур
        /// </summary>
        [DataMember]
        public abstract double Amount { get; set; }

        /// <summary>
        /// свойство для возврата типа фигуры в WinForms
        /// </summary>
        [DataMember]
        public abstract string FigureType { get; set; }

        /// <summary>
        /// константное значение для ограничения значения сверху TODO: Зачем паблик? RSDN. XML.//сделал
        /// </summary>
        [DataMember]
        private const double Upperlimit = 100000;

        /// <summary>
        /// Метод для проверки правильности введенных значений <see cref="CheckValue"/>
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        protected double CheckValue(double a)
        {
            if (a > Upperlimit)
            {
                throw new ArgumentException("Значение должно быть меньше 100000 ");
            }

            if (a < 0)
            {
                throw new ArgumentException("Значение должно быть больше 0");
            }
            return a;
        }

    }
}
