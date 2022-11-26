// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndInt (int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max +1) + rnd.NextDouble();
        arr[i] = Math.Round(arr[i], 1, MidpointRounding.ToZero);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double Maximum(double[] arr)
{
    double maxNumber = default;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > maxNumber) maxNumber = arr[i];
    }
    return maxNumber;
}

double Minimum(double[] arr)
{
    double minNumber = default;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] < minNumber) minNumber = arr[i];
    }
    return minNumber;
}

Console.WriteLine("Укажите длинну массива (например, 10): ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = CreateArrayRndInt (length, -100, 101);
PrintArray(array);
double maxNum = Maximum(array);
double minNum = Minimum(array);
double diff = maxNum - minNum;
double diffRound = Math.Round(diff, 1, MidpointRounding.ToZero);

Console.WriteLine($"Наибольшее число в массиве = {maxNum}");
Console.WriteLine($"Наименьшее число в массиве = {minNum}");
Console.WriteLine($"Разница между максимальным и минимальным элементами = {diffRound}");