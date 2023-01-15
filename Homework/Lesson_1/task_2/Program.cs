// По двум заданным числам проверять является ли первое квадратом второго
Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (Math.Sqrt(number1) == number2)
{
    Console.Write(number1 + " является квадратом " + number2);
}
else
{
    Console.Write("Условие не верно.");
}

