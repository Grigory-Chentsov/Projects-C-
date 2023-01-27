/* Проверить являются ли числа сторонами треугольника */

// Console.WriteLine("Введите первое число ");
// int a =int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите второе число ");
// int b =int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите третье число ");
// int c =int.Parse(Console.ReadLine()!);

// if (a + b > c && a + c > b && b + c > a)
//     Console.WriteLine("треугольник.");
// else
//     Console.WriteLine("Не треугольник.");


/* Записать программу преобразования десятичного числа в двоичное */

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int ostatok = 0;
int temp = number;
int count = 0;

while (temp > 0)
{
    temp = temp / 2;
    count++;
}

int[] array = new int[count];

for (int i = 0; i < array.Length; i++)
{
    ostatok = number % 2;
    array[array.Length - 1 - i] = ostatok;
    number = number / 2;
}

Console.Write(String.Join(" ", array));




