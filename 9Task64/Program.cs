// Задайте значение N. 
// Напишите программу, которая выведет все натуральные числа
//  в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"

Console.WriteLine("Введите натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());

ShowNumbers(num);
Console.WriteLine();

void ShowNumbers(int num)
{
    if(num == 0) return;
    if(num == 1) Console.Write($"{num}");
    else
    {
        Console.Write($"{num}, ");
        ShowNumbers(num - 1);
    }
}