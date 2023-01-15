// Показать вторую цифру трёхзначного числа

Console.Write("Введи трехзначное число: ");
//int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
string? stringNumber = Convert.ToString(Console.ReadLine()!);
Console.WriteLine("Вторая цифра числа -> " + stringNumber[1]);