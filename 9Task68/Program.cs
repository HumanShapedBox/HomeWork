// Напишите программу вычисления функции Аккермана
// с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
if(n < 0 || m < 0) Console.WriteLine("Некорректный ввод. Требуется натуральное число.");
else
{
    int ackFunction = Ackermann(n, m);
    Console.WriteLine($"A({n}, {m}) = {ackFunction}");
}

int Ackermann(int num1, int num2)
{
    if (num1 == 0) return num2+1;
    else
    {
        if((num1 != 0) && (num2 == 0)) return Ackermann(num1 - 1, 1);
        else return Ackermann(num1 - 1, Ackermann (num1, num2 - 1));
    }
}