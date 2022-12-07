// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4} ");
        }
        Console.WriteLine("|");
    }
}

int[] RowSum(int[,] matrix)
{
    int[] rowSum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = default;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        rowSum[i] = sum;
    }
    return rowSum;
}

int MinSumRow(int[] arr)
{
    int min = arr[0];
    int index = default;
    for (int i = 1; i < arr.Length; i++)
        if (min > arr[i])
        {
            min = arr[i];
            index = i+1;
        }
    return index;
}
int[,] array = CreateMatrixRndInt(5, 3, 0, 10);
PrintMatrix(array);
int[] sumRow = RowSum(array);
int minimalSumRowNumber = MinSumRow(sumRow);
Console.WriteLine($"Номер строки с наименьшей суммой элементов -> {minimalSumRowNumber}");