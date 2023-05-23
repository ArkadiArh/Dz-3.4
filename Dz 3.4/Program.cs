using System;

namespace Dz_3._4
{
    class Program
    {
        /* Переставить элементы массива
        в обратном порядке (при этом не используя второй массив)*/
        static void Main(string[] args)
        {
            Console.WriteLine("Input arrey size:");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Input {i + 1} element:");
                array[i] = int.Parse(Console.ReadLine());
            }
            Array.Reverse(array);
            Console.WriteLine();
            foreach (var value in array)
            {
                Console.WriteLine(value);
            }
        }
    }
}
