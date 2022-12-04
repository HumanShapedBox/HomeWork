//  Задайте двумерный массив из целых чисел. 
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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

double[] ColumnMean(int[,] matrix)
{
    int size = matrix.GetLength(1);
    int elements = matrix.GetLength(0);
    double[] meanColumns = new double[size];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            meanColumns[j] += matrix[i, j];
        }
        meanColumns[j] = meanColumns[j] / elements;
        meanColumns[j] = Math.Round(meanColumns[j], 1, MidpointRounding.ToZero);
    }
    return  meanColumns;
}

void PrintArray(double[] arr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine();
}

int[,] array = CreateMatrixRndInt(3, 5, 0, 11);
PrintMatrix(array);
double[] arrayColumnMean = ColumnMean(array);
PrintArray(arrayColumnMean);