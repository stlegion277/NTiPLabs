using System;
using FigureLibrary;

namespace FigureConsole
{
    //ToDO: RSDN - явное прописывание модификаторов доступа
    class Program
    {
        //TODO: Зачем это здесь?//сделал

        //TODO: XML//сделал
        /// <summary>
        /// Метод проверки на положительное целое число <see cref="CheckNumbers"/>
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        private static uint CheckNumbers(string input)
        {
            Console.WriteLine(input);
            uint value;
            while (!uint.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("Введите корректное значение, положительное целое число!");
            }
            return value;
        }

        static void Main()
        {
            try
            {
                //TODO: Комменты в коде тривиальные и ненужные//сделал
               
                FigureBase parallelepiped = new Parallelepiped(
                    CheckNumbers("Введите сторону А"), 
                    CheckNumbers("Введите сторону B"), 
                    CheckNumbers(("Введите сторону С")));
                //TODO: Тут и ниже - зачем отдельные переменные под рассчитанные значения?
                double amountParallelepiped = parallelepiped.Amount;
                Console.WriteLine("Обьем параллелепипеда = " + amountParallelepiped);

              
                FigureBase pyramid = new Pyramid(
                    CheckNumbers("Введите площадь"), 
                    CheckNumbers("Введите высоту"));
                double amountPyramid = pyramid.Amount;
                Console.WriteLine("Обьем пирамиды = " + amountPyramid);

               
                FigureBase sphere = new Sphere(CheckNumbers("Введите радиус шара"));
                double amountSphere = sphere.Amount;
                Console.WriteLine("Обьем шара = " + amountSphere);
                Console.ReadKey();
            }
            catch (FormatException)
            {
                Console.WriteLine("Введите корректное значение!");
                Console.ReadKey();
            }
        }
    }
}
