// 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

int[,] numbers = new int[4, 4];

Fill2DArray(numbers);
Print2DArray(numbers);

int IndexRow = EnterInt("Enter row: ");
int IndexColumn = EnterInt("Enter column: ");

FindElement(numbers, IndexRow, IndexColumn);


void Fill2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(-10, 11);
        }
    }
}

void Print2DArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write($"{numbers[i, j],3} ");
        }
        Console.WriteLine();
    }
}

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

void FindElement(int[,] numbers, int row, int column)
{
    if (row < numbers.GetLength(0) && column < numbers.GetLength(1))
        Console.WriteLine(numbers[row, column]);
    else Console.WriteLine("Такого элемента в массиве нет");
}
