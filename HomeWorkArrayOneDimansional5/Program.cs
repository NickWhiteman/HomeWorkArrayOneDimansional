using System;

//Сделать реверс массива (массив в обратном направлении).

namespace HomeWorkArrayOneDimansional5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[10];
            Random Random = new Random();

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = Random.Next(10);
                Console.Write($"{Array[i]} ");
            }

            Console.WriteLine();

            for (int i = Array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{Array[i]} ");
            }
        }
    }
}
