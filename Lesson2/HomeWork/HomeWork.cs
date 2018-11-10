using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в меню домашней работы Панина Марка, урока 2\nВведите номер задания (кроме 5, я его не сделал).\nДля вывода задания 7* введите 8");

            int n = 1;

            do
            {
                Console.WriteLine("Введите номер задания");
                n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        Task1();
                        break;
                
                    case 2:
                        Task2();
                        break;
                 
                    case 3:
                        Task3();
                        break;
                 
                    case 4:
                        Task4();
                        break;
                 
                    case 5:
                    case 6:
                        Task6();
                        break;

                    case 7:
                        Task7();
                        break;

                    case 8:
                        Task72();
                        break;

                    default:
                        break;
                }
           } while (n > 0 && n < 9);
        }
    }
}
