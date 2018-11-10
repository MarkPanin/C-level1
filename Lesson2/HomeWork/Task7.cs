using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//студент Панин Марк
// 7.а) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b).
// 7 б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

namespace HomeWork
{
    partial class Program
    {
        static bool Check(int a, int b)
        {
            if (a < b) return true;
            else return false;
        }

        static void Loop (int a, int b)
        {
            if (a <= b)
            {
                Console.Write(" " + a);
                Loop(++a, b);
            }
        }

        static void Task7()
        {

            Console.WriteLine("7.а) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b)." +
                "\n7 б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.");

            Console.WriteLine("Для того, чтобы вывести на экран все числа от a до b ведите  значение а, затем значение b. b должен быть больше a.");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (Check(a, b) != true)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }

            Loop(a, b);

            Console.ReadKey();

        }
    }
}
