// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB % numberA == 0)
    Console.WriteLine(numberB + " кратно " + numberA);
else
    Console.WriteLine(numberB % numberA + " остаток.");

//Console.WriteLine(number);

