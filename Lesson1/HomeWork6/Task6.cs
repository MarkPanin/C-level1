using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    class Task6
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

        static double EnterDouble(string text, string x)
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

        static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }

        static void Main(string[] args)
        {
        }
    }
}
