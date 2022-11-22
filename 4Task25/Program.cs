// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int Exponent(int num1, int num2)
{
    int resultExponent = 1;
    for(int i = 0; i < num2; i++)
    {
        resultExponent = resultExponent * num1;
    }
    return resultExponent;
}

if(number2 > 0) 
{
int resultExpo = Exponent(number1, number2);
Console.WriteLine($"Число {number1} в степени {number2} = {resultExpo}");
}
else Console.WriteLine("Некорректный ввод второго числа, введите натуральное число");
