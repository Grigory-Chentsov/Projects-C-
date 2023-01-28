// Показать числа Фибоначчи

Console.WriteLine("Введите число для поиска последовательности Фибоначчи: ");
int number = int.Parse(Console.ReadLine()!);

int num0 = 0;
int num1 = 1;
int temp;

for (int i = 0; i <= number; i++)
{
    if (number == 0 || number == 1)
        Console.WriteLine(number);
    else
    {
        Console.Write($"{num1} ");
        temp = num1;
        num1 = num1 + num0;
        num0 = temp;
    }

}



