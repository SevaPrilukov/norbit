using System;
using System.Linq;

namespace Library
{
    public class ZadanieOne
    {
        public void One()
        {
            Console.Write("Введите число N: ");

            int n;
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Некорректный ввод.");
                return;
            }

            string result = string.Join(", ", Enumerable.Range(1, n));
            Console.WriteLine(result);
        }
    }

    public class ZadanieTwo
    {
        public static void Two()
        {
            Console.Write("Введите нечетное число N: ");

            int n;
            if (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Некорректный ввод.");
                return;
            }

            if (n % 2 == 0)
            {
                Console.WriteLine("Вы ввели четное число.");
                return;
            }

            int center = n / 2 + 1;

            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= n; col++)
                {
                    if (row == center && col == center)
                        Console.Write(" ");
                    else
                        Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}