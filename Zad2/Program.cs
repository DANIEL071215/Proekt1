using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи низове с интервал: ");
            string input = Console.ReadLine();

            string[] words = input.Split(' ');

            //обръща масива
            Array.Reverse(words);

            // думите с глажнаа буква
            for (int i = 0; i < words.Length; i++)
            {
                if (char.IsUpper(words[i][0]))
                {
                    Console.Write(words[i]);

                    // добавя запетая ако тва не е последнаата дума с главна буква
                    if (i < words.Length - 1)
                    {
                        Console.Write(", ");
                    }
                }
            }
        }
    }
}
