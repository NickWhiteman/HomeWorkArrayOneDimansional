using System;

//Посчитать сумму элементов Массива с нечетными индексами

namespace HomeWorkArrayOneDimansional4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[10];
            int sumElementArrayOddIndex = 0;
            Random Random = new Random();

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = Random.Next(10);
                Console.Write($"{Array[i]} ");
            }


            for (int j = 0; j < Array.Length; j++)
            {
                if (j % 2 != 0)
                {
                    sumElementArrayOddIndex += Array[j];
                }
            }

            Console.WriteLine($"Сумма элементов массива с нечетными индексами = {sumElementArrayOddIndex}");
        }
    }
}
