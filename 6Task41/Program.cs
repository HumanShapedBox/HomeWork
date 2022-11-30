// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int[] CreateArrayRndInt (int size)
{
    Console.WriteLine($"Введите {size} чисел. После ввода каждого числа нажмите 'Enter': ");
    int[] arr = new int[size];
    for(int i = 0; i < size; i++)
    {
        arr[i] = Convert.ToInt32(Console.ReadLine());
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

int PositiveNumbers(int[] arr)
{
    int count = default;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) count++;
    }
    return count;
}

// Console.WriteLine("Введите ряд чисел через пробел (например, 1 2 3 -1 -2 -3): ");
// int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

Console.WriteLine("Эта программа сможет найти все положительные целые числа в ряду. Сколько чисел Вы хотите ей задать?");
int size = Convert.ToInt32(Console.ReadLine());
if (size < 0)
{
    size *= -1;
    Console.WriteLine("Некорректный ввод: требуется положительное число. Введённые данные откорректированы.");
}
int[] array = CreateArrayRndInt(size);
PrintArray(array);
int posNumbers = PositiveNumbers(array);
Console.WriteLine($"Количество положительных чисел в ряду -> {posNumbers}");