/* Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
Первые два элемента последовательности задаются пользователем */

int MetodFibo(int one, int two, int N)
{
    if (N == 1) return one;
    else if (N == 2) return two;
    return MetodFibo(one, two, N - 1) + MetodFibo(one, two, N - 2);
}
    
int N = 10;
Console.Write("Введите первое число: ");
int one = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int two = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= N; i++)
{
    Console.Write(MetodFibo(one, two, i) + " ");
}

