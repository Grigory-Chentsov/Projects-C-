// Написать программу вычисления произведения чисел от 1 до N

int Multiplication(int count)
{
    int result = 1;

    for (int i = 1; i <= count; i++)
    {
        result = result * i;

    }
    return result;
}

Console.WriteLine("Программа вычисления произведения чисел от 1 до N");
Console.WriteLine("Введите число N: ");
int count = int.Parse(Console.ReadLine()!);

int res = Multiplication(count);
Console.WriteLine(res);
    


