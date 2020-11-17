using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4
{
    //Фамилия - Крупский
    //Задача:
    //Написать программу обмена значениями двух переменных:
    //а) с использованием третьей переменной;
    //б) * без использования третьей переменной.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Последовательно введите a и b");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("Теперь a и b поменялись местами используя c как переходник. " + a + " " + b);
            Console.WriteLine("Последовательно введите a и b");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("Теперь a и b поменялись местами без посредников. " + a + " " + b);
            Console.ReadLine();
        }
    }
}
