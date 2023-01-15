// Найти максимальное из трех чисел

Console.WriteLine("Введите первое число: ");
int one = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int two = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int three = Convert.ToInt32(Console.ReadLine());

int max = one;

if (one > max)
    max = one;
if (two > max)
    max = two;
if (three > max)
    max = three;
Console.WriteLine(max + " максимальное число.");
