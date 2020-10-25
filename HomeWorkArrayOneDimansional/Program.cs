using System;

//Условие: Найти максимальный элемент массива.

namespace HomeWorkArrayOneDimansional
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int[5]; 
            int Max = Array[0];
            Random Random = new Random(); 

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = Random.Next(10);
                Console.Write($"{Array[i]} ");
            }


            for (int j = 0; j < Array.Length; j++)
            {
                if(Array[j] > Max)
                {
                    Max = Array[j];
                }
            }

            Console.WriteLine($"Наибольший элемент массива {Max}");
        }
    }
}
