using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//а) написать программу, которая подсчитывает расстояние между двумя точками с координатами х1, у1 и х2, у2 по формуле 
//r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя спецификатор формата .2f (с двумя знаками после запятой);
//б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.

namespace HomeWork3
{
    class Task3
    {

        static double Coordinates(int n, string c)
        {
            Console.WriteLine("Ведите координаты " + n.ToString() + " точки");
            Console.WriteLine(c + n.ToString() + " = ");
            Console.SetCursorPosition(5, 1);
            double i = Convert.ToDouble(Console.ReadLine());
            Console.Clear();
            return i;
        }

        static void Resume()
        {
            Console.WriteLine("Нажмите Enter, чтобы продолжить.");
            Console.ReadKey();
        }

        static double Distance(double x1, double y1, double x2, double y2)
        {
            double r = 0;
            r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }

        static void Pause()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу по расчёту расстояния между двумя точками в двумерном пространстве.");
            Resume();
            Console.Clear();

            double x1 = Coordinates(1, "x");
            double y1 = Coordinates(1, "y");

            Console.WriteLine("Координаты 1 точки ( " + x1.ToString() + " ; " + y1.ToString() + " )");
            Resume();
            Console.Clear();

            double x2 = Coordinates(2, "x");
            double y2 = Coordinates(2, "y");

            Console.WriteLine("Координаты 1 точки ( " + x1.ToString() + " ; " + y1.ToString() + " )");
            Console.WriteLine("Координаты 2 точки ( " + x2.ToString() + " ; " + y2.ToString() + " )\nНажмите Enter, чтобы рассчитать расстояние.");
            Pause();

            Console.WriteLine($"Расстояние между точками равняется {Distance(x1, y1, x2, y2):F2}");

            Pause();

        }
    }
}