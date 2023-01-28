/* Найти точку пересечения двух прямых заданных уравнением
   y = k1 * x + b1, y = k2 * x + b2. b1, k1 и b2, k2 заданы */

double k1 = 39;
double b1 = 12;
double b2 = 32;
double k2 = 34;

double x = 0;
double y = 0;

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают.");
    return;
}
else if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны.");
    return;
}
else
{
    x = (b2 - b1) / (k1 - k2);
    y = k1 * x + b1;
}

Console.WriteLine($"{x} {y}");
