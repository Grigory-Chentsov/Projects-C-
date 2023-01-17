// Найти третью цифру числа или сообщить, что её нет

int n = 846;
int len = 0;
int number = n;

while (number > 0)
{
    number = number / 10;
    len++;

}

if (len == 3)
    Console.WriteLine(n % 10);
else
    Console.WriteLine("Не трёхзначное число.");

