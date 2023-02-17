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


            int minNumber = 1;
            int maxNumber = 10;
            int sum = 0;
            int composition = 1;
            int numberRow = 1;
            int numberColumn = 0;

            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(minNumber, maxNumber);
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

            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[numberRow, j];
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                composition *= array[i, numberColumn];
            }

            Console.WriteLine($"Сумма втрой строки = {sum}");
            Console.WriteLine($"Произведение первого столбца = {composition}");
        }
    }
}
