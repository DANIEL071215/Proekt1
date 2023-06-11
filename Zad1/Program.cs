using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int m, n;

            do
            {
                Console.Write("Въведете положително цяло число m между 1 и 100: ");
                m = int.Parse(Console.ReadLine());

                Console.Write("Въведете положително цяло число n между 1 и 100: ");
                n = int.Parse(Console.ReadLine());

            } while (m < 1 || m > 100 || n < 1 || n > 100);

            int sum = 0;
            int count = 0;
            string evenNumbers = "";
            string divisibleBy3 = "";

            if (m < n)
            {
                for (int i = m; i <= n; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenNumbers += i + " ";
                    }

                    if (i % 3 == 0)
                    {
                        divisibleBy3 += i + " ";
                    }

                    if (i > 0)
                    {
                        sum += i;
                        count++;
                    }
                }
            }
            else
            {
                for (int i = m; i >= n; i--)
                {
                    if (i % 2 == 0)
                    {
                        evenNumbers += i + " ";
                    }

                    if (i % 3 == 0)
                    {
                        divisibleBy3 += i + " ";
                    }

                    if (i > 0)
                    {
                        sum += i;
                        count++;
                    }
                }
            }

            double average = (double)sum / count;

            Console.WriteLine("Четните числа: " + evenNumbers);
            Console.WriteLine("Числата които се делят на 3: " + divisibleBy3);
            Console.WriteLine("Средно-аритметично на числата е: " + average);
            Console.WriteLine("Броят на положителните числа в диапазона е:  " + count);
        }
    
    }
}
