using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Въведи брой реални числа: ");
            int n = int.Parse(Console.ReadLine());

            double[] numbers = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Въведи числото {0}: ", i + 1);
                numbers[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Числата в обратен ред:");
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}: {1}", i + 1, numbers[i]);
            }
        }
    }
}
