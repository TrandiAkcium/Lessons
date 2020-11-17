using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{ //Фамилия - Крупский
  //Задача:
  //Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес).В результате вся информация выводится в одну строчку:
  //а) используя склеивание;
  //б) используя форматированный вывод;
  //в) используя вывод со знаком $.
    class Program
    {
       
        static void Main(string[] args)
        {

            Console.WriteLine("Введите Имя");
            string name = Console.ReadLine()+" ";
            Console.WriteLine("Введите Фамилию.");
            string suname = Console.ReadLine()+" ";
            Console.WriteLine("Введите Возраст");
            string age = Console.ReadLine()+" ";
            Console.WriteLine("Введите Рост");
            string growth = Console.ReadLine()+" ";
            Console.WriteLine("Введите Вес");
            string weight = Console.ReadLine();
            

            Console.WriteLine("{0:C}", name + suname + age + growth + weight);


            Console.ReadLine();
        }
    }
}
