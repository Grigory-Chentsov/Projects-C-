// Показать четные числа от 1 до N

Console.Write("Введите ваше число: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;

while (count <= n)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
        count += 2;
    }
    else
    {
        count += 1;
    }
}