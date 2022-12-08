// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.

// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


int[] CreateArray (int size, int min, int max)
{
    int[] arr = new int[size];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = min;
        min++;
    }
    return arr;
}

void Shuffle(int[] arr)
{
    Random rnd = new Random();
    for (int i = arr.Length - 1; i >= 1; i--)
    {
        int j = rnd.Next(i + 1);
        int temp = arr[j];
        arr[j] = arr[i];
        arr[i] = temp;
    }
}

int[,,] Create3DMatrix(int rows, int columns, int depth, int[] arr)
{
    int n = default;
    int[,,] matrix = new int[rows, columns, depth];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = arr[n];
                n++;
            }
        }
    }
    return matrix;
}

void Print3DMatrix(int[,,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k}) ");
            }
        }
        Console.WriteLine();
    }
}


int[] availableNumbers = CreateArray (90, 10, 100);
Shuffle(availableNumbers);
int[,,] matrix3D = Create3DMatrix(2, 2, 2, availableNumbers);
Print3DMatrix(matrix3D);