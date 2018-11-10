using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//студент Панин Марк
// 4. Программа проверка логина и пароля. На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел 
// (Логин: root, Password: GeekBrains). Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль,
// программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.

namespace HomeWork4
{
    class Task4
    {
        static void Pause()
        {
            Console.ReadKey();
        }

        static string LoginPass ()
        {
            Console.WriteLine("Введите Логин");
            string login = Console.ReadLine();
            Console.WriteLine("Введите Пароль");
            string password = Console.ReadLine();
            string loginpass = login + password;
            return loginpass;
        }

        static int CheckPass(string loginpass)
        {
            if (loginpass == "rootGeekBrains") return 2;
            else return 1;
        }

        static void Main(string[] args)
        {
            int i = 1; //счётчик
            int n = 1; //логическая переменная для ветвления через switch
            string loginpass; //строка, куда будет записываться логин и пароль

            Console.WriteLine("Добро пожаловать в программу проверки пользователя, нажмите Enter, чтобы продолжить.");
            Pause();

            do
            {
                loginpass = LoginPass(); //вводим логин и пароль и объединяем их в одну строку

                n = CheckPass(loginpass); //проверяем строку логинпароль на соответствие, возрвраем 2 если true и 1 если false

                switch (n) 
                {
                    case 1:
                        Console.WriteLine($"Отказано в доступе, у Вас осталось {3 - i} попыток");
                        i++;
                        break;
                    case 2:
                        Console.WriteLine("Вы вошли");
                        goto End; //отправляем программу в конец кода, не хотел использовать goto, но так реально короче, один раз, надеюсь, можно
                }

            } while (i != 4);
            Console.WriteLine($"У Вас закончились попытки. Нажмите Enter, чтобы выйти.");
        End:
            Console.ReadKey();
        }
    }
}
