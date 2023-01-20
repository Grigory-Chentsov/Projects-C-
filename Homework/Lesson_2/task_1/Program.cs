// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите число обозначающее день недели: ");
int number_day = int.Parse(Console.ReadLine()!);

if (number_day > 0 && number_day < 8)
{
    if (number_day == 6 || number_day == 7)
    {
        Console.WriteLine("Число " + number_day + " обозначает выходной день");
    }
    else
        Console.WriteLine(number_day + " рабочий день.");
}
else
    Console.WriteLine("Введите число от 1 до 7.");
