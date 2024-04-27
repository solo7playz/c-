using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace с_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, surname;
            int age;
            Console.WriteLine("Введите рост: ");
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите вес: ");
            int weight = int.Parse(Console.ReadLine());
            anketa(h, weight);
            indexOfHeigth(h, weight);
        }
        static void anketa(int h, int weight)
        {
            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("имя={0}, фамилия={1}, возраст={2}, рост={3}, вес={4}", name, surname, age, h, weight);
            Console.WriteLine("имя - " + name + " фамилия - " + surname + " возраст - " + age + " рост - " + h + " вес - " + weight);
            Console.WriteLine($"имя - {name}, фамилия - {surname}, возраст - {age}, рост - {h}, вес - {weight}");
        }
        static void indexOfHeigth(int h, int weight)
        {
            double l = weight / (h/100 * h/100);
            Console.WriteLine("индекс массы тела - " + l);
        }
    }
}
