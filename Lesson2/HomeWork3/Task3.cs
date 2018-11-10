using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//студент Панин Марк
// 3. С клавиатуры вводятся числа, пока не будет введён ноль. Подсчитать сумму всех нечётных положительных чисел
namespace HomeWork3
{
    class Task3
    {
        static void Pause()
        {
            Console.ReadKey();
        }

       static bool Odd (double n)
        {
            return n % 2 != 0;
        }

        static void Main(string[] args)
        {
            double sum = 0;
            double n = 0;

            Console.WriteLine("Программа подсчитывает сумму всех введенных положительных нечётных чисел. Введите 0, чтобы вывести результат.");

            Console.WriteLine("Введите первое число.");
            n = Convert.ToDouble(Console.ReadLine());

            do
            {
                Console.WriteLine("Введите следующее число.");
                n = Convert.ToDouble(Console.ReadLine());
                if (n > 0 && Odd(n)==true)
                {
                    sum = sum + n;
                }
            } while (n != 0) ;

            Console.WriteLine($"Сумма всех введённых нечётных положительных числе равняется {sum}");

            Console.ReadKey();
        }
    }
}
