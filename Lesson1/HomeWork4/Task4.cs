using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Написать программу для обмена значениями двух переменных:
//а) с использованием третьей переменной
//б) *без использования третьей переменной

namespace HomeWork4
{
    class Task4
    {

        static double EnterDouble (string text, string x)
        {
            Console.WriteLine(text + x);
            double y = Convert.ToDouble(Console.ReadLine());
            return y;
        }

        static void Resume()
        {
            Console.WriteLine("Нажмите Enter, чтобы продолжить.");
            Console.ReadKey();
        }

        static void Pause()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в программу перемены переменных!");
            Resume();

            double a = EnterDouble("Введите переменную ", "x");
            double b = EnterDouble("Введите переменную ", "y");

            Console.WriteLine($"Переменная x = {a:F2}, переменная y = {b:F2}");
            Resume();

            double c = a;
            a = b;
            b = c;

            Console.WriteLine($"Теперь переменная x = {a:F2}, переменная y = {b:F2}");

            Pause();
        }
    }
}
