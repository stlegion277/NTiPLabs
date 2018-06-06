using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FigureLibrary;

namespace FigureConsole
{
    class Program
    {
        static void Main()
        {
            ///Ввод сторон параллелепипеда
            Console.WriteLine("Введите сторону А");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону B");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите сторону С");
            int c = Convert.ToInt32(Console.ReadLine());
            ///Считаем обьем
            FigureBase parallelepiped = new Parallelepiped(a, b, c);
            double amountParallelepiped = parallelepiped.GetAmount();
            Console.WriteLine("Обьем параллелепипеда = " + amountParallelepiped);
            ///ввод данных для обьема пирамиды
            Console.WriteLine("Введите площадь пирамиды");
            int area = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите высоту пирамиды");
            int height = Convert.ToInt32(Console.ReadLine());
            ///расчет обьема пирамиды
            FigureBase pyramid = new Pyramid(area, height);
            double amountPyramid = pyramid.GetAmount();
            Console.WriteLine("Обьем пирамиды = " + amountPyramid);
            ///ввод данных для расчитывания обьема шара
            Console.WriteLine("Введите радиус шара");
            double radius = Convert.ToDouble(Console.ReadLine());
            ///расчет обьема шара
            FigureBase sphere = new Sphere(radius);
            double amountSphere = sphere.GetAmount();
            Console.WriteLine("Обьем шара = " + amountSphere);
            Console.ReadKey();
        }
    }
}
