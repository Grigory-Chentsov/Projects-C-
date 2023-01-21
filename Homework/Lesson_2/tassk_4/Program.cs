// Найти расстояние между точками в пространстве 2D/3D


Console.WriteLine("Расстояние между двумя точками в 2D - 1.");
Console.WriteLine("Расстояние между двумя точками в 3D - 2.");
Console.WriteLine("Выберите вариант 1 или 2: ");

char user_option;

user_option = Convert.ToChar(Console.ReadLine()!);

switch (user_option)
{
    case '1':
        Console.Write("Введите координаты x1: ");
        double x1 = double.Parse(Console.ReadLine()!);

        Console.Write("Введите координаты y1: ");
        double y1 = double.Parse(Console.ReadLine()!);

        Console.Write("Введите координаты x2: ");
        double x2 = double.Parse(Console.ReadLine()!);

        Console.Write("Введите координаты y2: ");
        double y2 = double.Parse(Console.ReadLine()!);

        double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        Console.WriteLine($"Расстояние между двумя точками на плоскости равно {distance}");
        break;
    case '2':
        Console.Write("Введите координаты x1: ");
        x1 = double.Parse(Console.ReadLine()!);

        Console.Write("Введите координаты y1: ");
        y1 = double.Parse(Console.ReadLine()!);

        Console.Write("Введите координаты z1: ");
        double z1 = double.Parse(Console.ReadLine()!);

        Console.Write("Введите координаты x2: ");
        x2 = double.Parse(Console.ReadLine()!);

        Console.Write("Введите координаты y2: ");
        y2 = double.Parse(Console.ReadLine()!);

        Console.Write("Введите координаты z2: ");
        double z2 = double.Parse(Console.ReadLine()!);

        distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
        Console.WriteLine($"Расстояние между двумя точками в пространстве равно {distance}");
        break;
    default:
        Console.WriteLine("Вы ввели неверный символ.");
        break;
}



