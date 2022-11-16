// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа. 
// Выполнить с помощью числовых операций.

Console.WriteLine("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int ShowSecondNumber(int number)
{
    int twoFigNum = num % 100;
    int result =  twoFigNum / 10;
    return result;
}
Console.WriteLine(ShowSecondNumber(num));