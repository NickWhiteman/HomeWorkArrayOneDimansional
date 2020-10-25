using System;

//Найти индекс минимального элемента в массива

namespace HomeWorkOneDimansional2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = {24, 54, 2, 65, 76};
            int indexArrayMinElement = 0;
            int Min = Array[0];

            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] < Min)
                {
                    indexArrayMinElement = i;
                }
            }

            Console.WriteLine($"Индекс минимального элемента массива - {indexArrayMinElement}");
        }
    }
}
