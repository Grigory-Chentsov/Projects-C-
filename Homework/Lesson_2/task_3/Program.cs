// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Введите номер интересующей четверти: ");
int quarter_number = int.Parse(Console.ReadLine()!);

string[] quarters = { "x, y", "-x, y", "-x, -y", "x, -y" };
int index = quarter_number - 1;

if (quarter_number <= 4)
{
    Console.WriteLine(quarters[index]);
}
else 
    Console.WriteLine("Error: Выберите одну из четырёх четвертей.");

