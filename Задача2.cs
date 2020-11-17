using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2
{
    //Фамилия - Крупский 
    //    Задача:
    //    Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах.


    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Введите Вес в кг");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите Рост в метрах");
        double growth = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Ваш индекс массы тела: " + weight / (growth * growth));
        Console.ReadLine();
        }
    }
}
