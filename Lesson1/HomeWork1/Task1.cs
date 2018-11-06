using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Анекта. Написать программу Анкета. 
//Последовательно задаются вопросы (имя, фамилия, возраст, 
//рост, вес). В результате вся информация выводится в одну строку:
//- используя склеивание
//- используя форматированный вывод
//- используя знако доллара

namespace HomeWork1
{
    class Task1
    {

        static string EnterString(string x)
        {
            Console.WriteLine(x);
            string message = Console.ReadLine();
            return message;
        }

        static void Pause()
        {
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            string name = EnterString("Как Ваше имя?");
            string surname = EnterString("Какова Ваша фамилия?");
            string age = EnterString("Сколько Вам лет?");
            string height = EnterString("Каков Ваш рост?");
            string weight = EnterString("Какой у Вас вес?");

            Console.SetCursorPosition(0, 12);
            Console.WriteLine("Ваше имя: " + name + "\nВаша фамилия: " + surname + "\nВаш возраст: " + age + "\nВаш рост: " + height + "\nВаш вес: " + weight);

            Console.SetCursorPosition(0, 19);
            Console.WriteLine("Ваше имя: {0,4}\nВаша фамилия: {1:F3}\nВаш возраст: {2:E}\nВаш рост: {3}\nВаш вес: {4}", name, surname, age, height, weight);

            Console.SetCursorPosition(0, 26);
            Console.WriteLine($"Ваше имя: {name,4} \nВаша фамилия: {surname:F3}\nВаш возраст: {age:E}\nВаш рост: {height}\nВаш вес: {weight}");

            Pause();
        }
    }
}
