using System;

//Отсортировать массив по возрастанию одним из способов:  пузырьком(Bubble),
//выбором (Select) или вставками (Insert)) 

namespace HomeWorkArrayOneDimansional8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Array = new int [10];
            int item;
            Random random = new Random();

            Console.WriteLine($"Неотсортированный массив: ");

            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(1, 20);
                Console.Write($"{Array[i]} ,");
            }

            Console.WriteLine();
            Console.WriteLine($"Пузырьковая сортировка:");

            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                    {
                        item = Array[i];
                        Array[i] = Array[j];
                        Array[j] = item;
                    }
                }
                Console.Write($"{Array[i]}, ");
            }
        }
    }
}
