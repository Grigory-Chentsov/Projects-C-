// Выяснить является ли число чётным

Console.Write("Введите ваше число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine(n + " является чётным.");
}
else
{
    Console.WriteLine(n + " является нечётным.");
}