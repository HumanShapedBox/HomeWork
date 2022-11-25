// Задайте массив, заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество 
// чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] CreateArrayRndInt (int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max +1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
    {
        if(i < arr.Length -1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int CountEvenNumbers(int[] arr)
{
    int count = default;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 0) count ++;
    }
    return count;
}

Console.WriteLine("Укажите длинну массива (например, 10): ");
int length = Convert.ToInt32(Console.ReadLine());
int[] array = CreateArrayRndInt (length, 100, 1000);
PrintArray(array);
int evenNumbersAmount = CountEvenNumbers(array);
Console.WriteLine($"Количество чётных чисел в массиве -> {evenNumbersAmount}");