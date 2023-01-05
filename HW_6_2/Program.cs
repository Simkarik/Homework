// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
double b1, k1, b2, k2;
Console.WriteLine($"Enter coordinates of the first line: ");
        b1 = double.Parse(Console.ReadLine());
        k1 = double.Parse(Console.ReadLine());
Console.WriteLine($"Enter coordinates of the second line: ");
        b2 = double.Parse(Console.ReadLine());
        k2 = double.Parse(Console.ReadLine());

(double, double) CrossingPointOf(double x1, double y1, double x2, double y2)
{
    double x = (x2 - x1) / (y1 - y2);
    return (x, y2 * x + x2);
}

Console.WriteLine($"Coordinates of crossing point: {CrossingPointOf(b1, k1, b2, k2)}");