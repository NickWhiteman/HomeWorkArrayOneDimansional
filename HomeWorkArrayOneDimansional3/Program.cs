using System;

// Найти индекс максимального элемента массива

namespace HomeWorkArrayOneDimansional3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = { 24, 54, 2, 65, 76 };
            int Max = Array[0];
            int indexArrayMaxElement = 0;


            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > Max)
                {
                    indexArrayMaxElement = i;
                }
            }

            Console.WriteLine($"Индекс наибольшего элемента массива - {indexArrayMaxElement}");
        }
    }
}
