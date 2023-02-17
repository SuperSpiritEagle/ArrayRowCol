using System;

namespace ArrayColRow
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowArray = 3;
            int columnArray = 3;
            int[,] arrayNumbers = new int[rowArray, columnArray];
            int minNumber = 1;
            int maxNumber = 10;
            int sumRow = 0;
            int compositionColumn = 1;
            int numberRow = 1;
            int numberColumn = 0;

            Random random = new Random();

            for (int i = 0; i < arrayNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNumbers.GetLength(1); j++)
                {
                    arrayNumbers[i, j] = random.Next(minNumber, maxNumber);
                }
            }

            for (int i = 0; i < arrayNumbers.GetLength(0); i++)
            {
                for (int j = 0; j < arrayNumbers.GetLength(1); j++)
                {
                    Console.Write(arrayNumbers[i, j] + " ");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < arrayNumbers.GetLength(1); j++)
            {
                sumRow += arrayNumbers[numberRow, j];
            }

            for (int i = 0; i < arrayNumbers.GetLength(0); i++)
            {
                compositionColumn *= arrayNumbers[i, numberColumn];
            }

            Console.WriteLine($"Сумма втрой строки = {sumRow}");
            Console.WriteLine($"Произведение первого столбца = {compositionColumn}");
        }
    }
}
