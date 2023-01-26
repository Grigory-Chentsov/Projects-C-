// Посчитать сумму чисел в числе

Console.WriteLine("Введите число: ");
string input = Console.ReadLine()!;
int len = input.Length;
int number = int.Parse(input);
int sum = 0; 

for (int i = 0; i <= len; i++)
{
    sum = sum + number % 10;
    number = number / 10;
}

Console.WriteLine(sum);
