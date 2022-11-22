// Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int SumDigits(int number)
{
    int digit = default;
    int sumDigits = default;
    while(number > 0)
    {
        digit = number % 10;
        sumDigits = sumDigits + digit;
        number = number / 10;
    }
    return sumDigits;
}

if(num < 0) num = -num;
int sumNum = SumDigits(num);
Console.WriteLine($"Сумма цифр в числе {num} = {sumNum}");
