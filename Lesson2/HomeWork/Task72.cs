using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//студент Панин Марк
// 7.а) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b). (делается точно по аналогии с первой рекурсией из урока)
// 7 б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.

namespace HomeWork
{
    partial class Program
    {

        static void Loop(int a, int b, int sum)
        {
            if (a <= b)
            {
                sum = sum + a;
                Loop(++a, b, sum);
            }
            else
            {
                Console.WriteLine($"Сумма числе между a и b  равняется {sum}");
            }
        }

        static void Task72()
        {

            Console.WriteLine("7.а) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b)." +
    "\n7 б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.");

            Console.WriteLine("Для того, чтобы вывести на экран все числа от a до b ведите  значение а, затем значение b. b должен быть больше a.");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sum = 0;

            if (Check(a, b) != true)
            {
                a = a + b;
                b = a - b;
                a = a - b;
            }

            Loop(a, b, sum);

            Console.ReadKey();

        }
    }
}
