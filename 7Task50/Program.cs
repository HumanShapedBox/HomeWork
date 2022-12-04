// Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

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

int FindNumber(int[,] arr, int row, int column)
{
    int number = default;
    number = arr[row, column];
    return number;
}

int[,] array = CreateMatrixRndInt(3, 5, -10, 11);
Console.WriteLine("Укажите индекс строки требуемого элемента: ");
int userRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите индекс столбца требуемого элемента: ");
int userColumn = Convert.ToInt32(Console.ReadLine());
PrintMatrix(array);
Console.WriteLine();
if ((userRow < 0) || (userColumn < 0)) Console.WriteLine("Некорректный ввод");
else if ((userRow > array.GetLength(0)) || (userColumn > array.GetLength(1))) Console.WriteLine("Такого элемента в массиве нет");
else
{
int userNumber = FindNumber(array, userRow, userColumn);
Console.WriteLine($"Элемент на позиции {userRow},{userColumn} -> {userNumber}");
}
 

