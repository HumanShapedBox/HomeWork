// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму 
// натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120

Console.WriteLine("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
if ((n < 0) || (m < 0)) Console.WriteLine("Некорректный ввод. Требуется положительное число.");
if (n > m)
{
    int numbersSum = SumNumbers(m, n);
    Console.WriteLine($"Сумма чисел от {n} до {m} = {numbersSum}");
}
else
{
    int numbersSum = SumNumbers(n, m);
    Console.WriteLine($"Сумма чисел от {n} до {m} = {numbersSum}");
}

int SumNumbers(int num1, int num2)
{
    int sum = default;
    if (num1 == num2) return sum = num2;
    else return sum = num1 + SumNumbers(num1 + 1, num2);
}