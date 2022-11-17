// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// Выполнить с помощью числовых операций.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int ThirdNum(int number)
{
   while(num >= 999) num /= 10;
   int result = num % 10;
   return result;
}

Console.WriteLine(ThirdNum(num));