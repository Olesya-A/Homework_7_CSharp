// 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] numbers = new int[4, 4];

Fill2DArray(numbers);
Print2DArray(numbers);

ArithmeticMeanInColumn(numbers);

void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(1, 11);
        }
    }
}

void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j],2} ");
        }
        Console.WriteLine();
    }
}

void ArithmeticMeanInColumn(int[,] numbers)
{
    Console.Write($"Среднее арифметическое каждого столбца: ");
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        double sumInColumn = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            sumInColumn += numbers[i, j];
        }
        double average = sumInColumn / numbers.GetLength(0);
        Console.Write($"{average:F2}  ");
    }    
}
