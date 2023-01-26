// Найдите кубы чисел от 1 до N;

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= N; i++)
{
    int cube = i * i * i;
    Console.WriteLine(cube);
}
