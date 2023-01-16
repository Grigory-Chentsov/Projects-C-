// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int number = new Random().Next(10, 99);

int first_number = number / 10;
int second_number = number % 10;

if (first_number > second_number)
{
    Console.WriteLine(first_number);
}
else
{
    Console.WriteLine(second_number);
}


Console.WriteLine(number);


