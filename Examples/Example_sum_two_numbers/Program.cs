// int numberA = 3;    // указываем тип переменной (int) целые числа
// int numberB = 5;

int numberA = new Random().Next(1, 10);    // генерируем случайное число 1,2,3...8,9
int numberB = new Random().Next(1, 10);

Console.WriteLine(numberA + numberB);   // выводим результат в консоль
