using System;

//Условие: Найти наименьший элемент массива.

namespace HomeWorkArrayOneDimansional1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = {45, 43, 12, 67, 34};
            int Min = Array[0];

            for (int j = 1; j < Array.Length; j++)
            {
                if (Array[j] < Min)
                {
                    Min = Array[j];
                }
            }

            Console.WriteLine($"Наименьший элемент массива {Min}");
        }
    }
}
