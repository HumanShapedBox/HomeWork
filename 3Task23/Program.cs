// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число");
int n = Convert.ToInt32 (Console.ReadLine());

void Cube (int num)
{
    int count = 0;
    while(count <= num)
    {
        Console.WriteLine($"{count}\t{count * count * count}");
        count++;
    }
}

Console.WriteLine("Число\tКуб");
Cube (n);