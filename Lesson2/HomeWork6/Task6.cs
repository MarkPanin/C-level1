using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//студент Панин Марк
//Программа подсчёта количества хороших чисел от 1 до 1 000 000 000. "Хорошее" число - число, которое делится на сумму своих цифр.
// Реализовать подсчёт времени работы программы, используя структуру DateTime.

namespace HomeWork6
{
    class Task6
    {
        static int Sum (int n) //метод для подсчёта суммы цифр числа.
        {
            int sum = 0;

            while (n >= 10) //в цикле к сумме прибавляется остаток от деления введенного числа на 10. Входим из цикла, когда число становится менее 10
            {
                sum = sum + (n % 10);
                n = (n - (n % 10)) / 10; //отбрасываем последнюю цифру
            }
            sum = sum + n; //прибавляем оставшийся последний разряд к сумме

            return sum;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("нажмите Enter, чтобы рассчитать сумму хороших чисел");
            Console.ReadLine();

            DateTime start = DateTime.Now;

            int a = 1;
            int b = 1000000000;
            int sumhor = 0;

            while (a <= b)
            {
                if (a%Sum(a)==0)
                {
                    sumhor = sumhor + Sum(a);
                }
                a++;
            }

            Console.WriteLine($"Сумму всех \"хороших\" чисел от 1 до 1 000 000 000 составляет {sumhor}");

            DateTime finish = DateTime.Now;

            Console.WriteLine($"Время исполнения программы {finish - start}");

            Console.ReadKey();
        }
    }
}
