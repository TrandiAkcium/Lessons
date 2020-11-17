using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5
{
    //Фамилия - Крупский
    //Задача:
    //а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
    //б) * Сделать задание, только вывод организовать в центре экрана.
    //в) ** Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y).
    class Program
    {
        static void Print(string msg, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(msg);
        }
            static void Main(string[] args)
        {
            Console.WriteLine("Введите последовательно Имя, Фамилию и Город проживания");
            string name = Console.ReadLine();
            string suname = Console.ReadLine();
            string home = Console.ReadLine();
            string msg = name + ", " + suname + ", " + home;
            Print(msg, Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.ReadLine();
        }
    }
}
