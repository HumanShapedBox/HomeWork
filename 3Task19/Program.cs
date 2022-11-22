// Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций.

Console.WriteLine("Введите пятизначное число (12345): ");
int num = Convert.ToInt32(Console.ReadLine());
int reverse = Reverse(num);
if(num > 9999 && num < 100000) Console.WriteLine(Palindrome(num, reverse) ? "Число является палиндромом" : "Число не является палиндромом");
else Console.WriteLine("Некорректный ввод");

int Reverse(int number)
{
    int digit = 0;
    int nReverse = 0;
    while(number > 0)
    {
        digit = number % 10;
        nReverse = nReverse * 10 + digit;
        number = number / 10;
    }
    return nReverse;
}

bool Palindrome(int number, int reverse)
{
    return (number == reverse);
}