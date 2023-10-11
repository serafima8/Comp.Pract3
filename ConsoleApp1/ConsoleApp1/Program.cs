using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя 5 слов, после чего вывести эти слова, каждое через пустую строку от предыдущего. Использовать 7 функции вывода.
            //Вариант 12
            Console.Title = "Программа №2(Лебедева)";
            Console.WriteLine("Ввести 5 слов");
            Console.Write("Введите 1 слово:");
            string word1 = Console.ReadLine();
            Console.Write("Введите 2 слово:");
            string word2 = Console.ReadLine();
            Console.Write("Введите 3 слово:");
            string word3 = Console.ReadLine();
            Console.Write("Введите 4 слово:");
            string word4 = Console.ReadLine();
            Console.Write("Введите 5 слово:");
            string word5 = Console.ReadLine();
            Console.WriteLine($"{word1}");
            Console.WriteLine($" ");
            Console.WriteLine($"{word2}");
            Console.WriteLine($" ");
            Console.WriteLine($"{word1}\n{word2}");
            Console.WriteLine($" ");
            Console.WriteLine($"{word4}");
            Console.WriteLine($" ");
            Console.WriteLine($"{word4}\n{word5}");
            Console.WriteLine($" ");
            Console.WriteLine($"{word3}\n{word4}");
            Console.WriteLine($" ");
            Console.WriteLine($"{word1}\n{word2}");
            Console.ReadKey();
        }
    }
}
