/* Написать программу масштабирования фигуры
   Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
   например: "(0,0) (2,0) (2,2) (0,2)"
   коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
   В результате показать координаты, которые получатся.
   при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)" */

Console.WriteLine("Введите координаты вершин: ");
string? coordinates = Console.ReadLine();

string? StringReplace(ref string coordinates)
{
    coordinates = coordinates.Replace(",", " ");
    coordinates = coordinates.Replace("(", " ");
    coordinates = coordinates.Replace(")", " ");
    coordinates = coordinates.Replace(" ", "");
    coordinates = coordinates.TrimStart();
    return coordinates;
}

StringReplace(ref coordinates!);

Console.WriteLine("Введите коэффициент масштабирования: ");
double k = double.Parse(Console.ReadLine()!);

double[] new_coord = new double[coordinates.Length];

for (int i = 0; i < coordinates.Length; i++)
{
    new_coord[i] = ((double)coordinates[i] - 48) * k;
}
Console.WriteLine($"Координаты расширения ({new_coord[0]},{new_coord[1]})"
                                       + $" ({new_coord[2]},{new_coord[3]})"
                                       + $" ({new_coord[4]},{new_coord[5]})"
                                       + $" ({new_coord[6]},{new_coord[7]})");




