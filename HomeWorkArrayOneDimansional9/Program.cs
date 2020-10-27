using System;

// Отсортировать массив по убыванию одним из способов,
// (отличным от способа в 9-м задании) :  пузырьком(Bubble), выбором (Select)
// или вставками (Insert))

namespace HomeWorkArrayOneDimansional9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int [6];
            Random random = new Random();
            int item;

            Console.WriteLine("Несортированный массив: ");

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(1, 20);
                Console.Write($"{Array[i]}, ");
            }

            Console.WriteLine();
            Console.WriteLine("Отсортированный массив: ");

            for (int i = 0; i < Array.Length; i++)
            {
                int min = i;
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[j] < Array[min])
                    {
                        min = j;
                    }
                }
                item = Array[min];
                Array[min] = Array[i];
                Array[i] = item;
                Console.Write($"{Array[i]}, ");
            }
        }
    }
}
