// Напишите программу, которая найдёт 
// точку пересечения двух прямых, 
// заданных уравнениями 
// y = k1 * x + b1, 
// y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите коэфициент b для первой прямой: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэфициент k для первой прямой: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэфициент b для второй прямой: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите коэфициент k для второй прямой: ");
double k2 = Convert.ToInt32(Console.ReadLine());

double FindX(double ba, double ka, double bb, double kb)
{
    double x = (bb - ba) / (ka - kb);
    Math.Round(x, 1, MidpointRounding.ToZero);
    return x;
}

double FindY(double bb, double kb)
{
    double x = FindX(b1, k1, b2, k2);
    double y = kb * x + bb;
    Math.Round(y, 1, MidpointRounding.ToZero);
    return y;
}

double x = FindX(b1, k1, b2, k2);
double y = FindY(b2, k2);
Console.WriteLine($"Координаты пересечения линий -> ({x}, {y})");