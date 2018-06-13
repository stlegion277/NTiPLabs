using System;
using FigureLibrary;

namespace FigureConsole
{
    class Program
    {
        // private static double CheckNumbers(string input)
        // {
        //    bool valid = true;
        //    do
        //    {
        //        Console.WriteLine("Введите корректное значение!");
        //        uint value;
        //        Console.WriteLine(input);
        //        string input = Console.ReadLine();
        //        valid = Double.TryParse(input, out double i);
        //    }
        //    while (!valid);
        //    return i;
        //}

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
                //TODO: Программа должна запрашивать у пользователя ввода после каждого некорректного ввода и давать ему 
                //TODO: возможность ввести корректные параметры сразу, а не заставлять вводить все параметры заново  //сделал
                //Ввод сторон параллелепипеда
                FigureBase parallelepiped = new Parallelepiped(CheckNumbers("Введите сторону А"), 
                    CheckNumbers("Введите сторону B"), CheckNumbers(("Введите сторону С")));
                //Считаем обьем
                double amountParallelepiped = parallelepiped.Amount;
                Console.WriteLine("Обьем параллелепипеда = " + amountParallelepiped);

                //ввод данных для расчета обьема пирамиды
                FigureBase pyramid = new Pyramid(CheckNumbers("Введите площадь"), CheckNumbers("Введите высоту"));
                //расчет обьема пирамиды
                double amountPyramid = pyramid.Amount;
                Console.WriteLine("Обьем пирамиды = " + amountPyramid);

                //ввод данных для расчитывания обьема шара
                FigureBase sphere = new Sphere(CheckNumbers("Введите радиус шара"));
                //расчет обьема шара
                double amountSphere = sphere.Amount;
                Console.WriteLine("Обьем шара = " + amountSphere);
                Console.ReadKey();
            }
            catch (FormatException)
            {
                ////TODO: Плохая практика. Лучше цикл с условием!
               Console.WriteLine("Введите корректное значение!");
                Console.ReadKey();
            }
        }
    }
}
