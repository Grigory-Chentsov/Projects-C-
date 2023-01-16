// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int new_number = (number / 100) * 10 + (number % 10);
Console.WriteLine(new_number);

