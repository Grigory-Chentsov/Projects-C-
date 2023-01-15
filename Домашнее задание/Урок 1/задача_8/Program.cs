// Показать вторую цифру трёхзначного числа

Console.Write("Введи трехзначное число: ");
string? stringNumber = Convert.ToString(Console.ReadLine()!);
Console.WriteLine("Вторая цифра числа -> " + stringNumber[1]);
