using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//студент Панин Марк
//задание 1
//Написать метод, возввращающий минимальное из трэх чисел

namespace Lesson2
{
    class Task1
    {
        static double EnterDouble()
        {
            double i = Convert.ToDouble(Console.ReadLine());
            return i;
        }

        static double Min(double a, double b, double c)
        {
            double min = (a < b) ? a : b;
            min = (min < c) ? min : c;
            return min;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            double a = EnterDouble();

            Console.WriteLine("Введите второе число");
            double b = EnterDouble();

            Console.WriteLine("Введите третье число");
            double c = EnterDouble();

            double mini = Min(a, b, c);
            Console.WriteLine(mini);

        Console.ReadKey();
        }
    }
}
