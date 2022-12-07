// Задайте две матрицы. 
// Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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
        for (int j = 0; j < matrix.GetLength(1); j++) Console.Write($"{matrix[i, j],4} ");
        Console.WriteLine("|");
    }
}

bool CheckMatrix(int[,] matrix1, int[,] matrix2)
{
    return (matrix1.GetLength(1) == matrix2.GetLength(0));
}

int[,] CreateMultMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] martix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            martix3[i, j] = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                martix3[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return martix3;
}

int[,] firstMatrix = CreateMatrixRndInt(3, 2, 0, 10);
PrintMatrix(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = CreateMatrixRndInt(2, 2, 0, 10);
PrintMatrix(secondMatrix);
Console.WriteLine();
if(CheckMatrix(firstMatrix, secondMatrix) == false) Console.WriteLine("Операция невозможна");
else
{
    int[,] multMatrix = CreateMultMatrix(firstMatrix, secondMatrix);
    Console.WriteLine("Результат произведения матриц:");
    PrintMatrix(multMatrix);
}
