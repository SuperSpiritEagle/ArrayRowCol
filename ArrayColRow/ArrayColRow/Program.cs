using System;

namespace ArrayColRow
{
    class Program
    {
        static void Main(string[] args)
        {
            int row = 3;
            int column = 3;
            int[,] array = new int[row, column];
            int numberRow = 1;
            int numberColumn = 0;
            int minNumber = 0;
            int maxNumber = 9;
            int sum = 0;
            int composition = 1;

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minNumber, maxNumber);

                    if (i == numberRow)
                    {
                        sum += array[i, j];
                    }
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (j == numberColumn)
                    {
                        composition *= array[i, j];
                    }
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine($"Сумма втрой строки = {sum}");
            Console.WriteLine($"Произведение первого столбца = {composition}");
        }
    }
}
