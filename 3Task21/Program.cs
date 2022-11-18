// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
//
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки.");
Console.WriteLine("По оси X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("По оси Y: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("По оси Z: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки.");
Console.WriteLine("По оси X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("По оси Y: ");
Console.WriteLine("Введите координаты точки YB: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("По оси Z: ");
int zb = Convert.ToInt32(Console.ReadLine());

double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double xAxis = (x1 - x2) * (x1 - x2);
    double yAxis = (y1 - y2) * (y1 - y2);
    double ZAxis = (z1 - z2) * (z1 - z2);
    double result = Math.Sqrt(xAxis + yAxis + ZAxis);
    return result;
}

double res = Distance(xa, ya, za, xb, yb, zb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);

Console.WriteLine(resRound);