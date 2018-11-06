using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
//где m - массе тела в кг, h - рост в метрах

namespace HomeWork2
{
    class Task2
    {

        static double EnterDouble(string text, string x)
        {
            Console.WriteLine(text + x);
            double y = Convert.ToDouble(Console.ReadLine());
            return y;
        }

        static void Pause()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            double height = EnterDouble("Введите Ваш рост в метрах, ", "h = ");

            double weight = EnterDouble("Введите Ваш вес в кг, ", "m = ");

            Console.WriteLine($"Индекс массы Вашего тела = {weight/(height*height):F2}");

            Pause();
        }
    }
}
