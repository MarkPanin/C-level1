using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    class Task5
    {

        static void Pause()
        {
            Console.ReadKey();
        }

        static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }

        static void Main(string[] args)
        {
            Print("Марк Панин, Москва", 50, 13);
            Pause();
        }
    }
}
