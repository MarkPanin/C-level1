using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//студент Панин Марк
//задание 2
//Написать метод подсчёта количества цифр числа

namespace HomeWork2
{
    class Task2
    {    
        static double EnterDouble()
        {
        double n = Convert.ToDouble(Console.ReadLine());
        return n;
        }

        static int Counter(double x)
        {
            int i = 1; //количество знаков
            if (x > 10)
            {
                i = 2;
                while ((x / 10) > 10) //если остаток от деления числа на 10 всё ещё больше 10, то цикл продолжается, с каждой итерацией i++
                {
                    x = x / 10;
                    i++;
                }
            }
            return i;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            double x = EnterDouble();

            int i = Counter(x);

            Console.WriteLine($"Количество знаков в числе - {i}");

            Console.ReadKey();
        }
    }
}
