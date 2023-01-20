// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите первое число: ");
int number_one = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int number_two = int.Parse(Console.ReadLine()!);

if (Math.Pow(number_one, 2)  == number_two)
{
    Console.WriteLine("Второе число является квадратом первого числа.");
}
else if (Math.Pow(number_two, 2) == number_one)
{
    Console.WriteLine("Первое число является квадратом второго числа.");
}
else
Console.WriteLine("Ни одно число не является квадратом второго.");

