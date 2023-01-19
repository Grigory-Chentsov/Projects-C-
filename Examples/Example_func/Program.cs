// Создание и работа с методами (функциями принято называть в C#)

int Max(int arg1, int arg2, int arg3)   // int-тип данных в функции, Max-имя функции, ()- агрументы функции
{
    int result = arg1;                  // тело функции , что она выполняет
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;                      // возврат результата действия функции
}

int a1 = 541;
int a2 = 26;
int a3 = 3367;
int b1 = 435;
int b2 = 845;
int b3 = 6445;
int c1 = 7;
int c2 = 81;
int c3 = 73459;

// int max1 = Max(a1, a2, a3); // вызываем функцию передав в неё аргументы
// int max2 = Max(b1, b2, b3);
// int max3 = Max(c1, c2, c3);
// int max = Max(max1, max2, max3);

int max = Max(Max(a1, a2, a3), Max(b1, b2, b3), Max(c1, c2, c3));   // в аргумент можно передать функцию


// int max = a1;
// if (a2 > max) max = a2;
// if (a3 > max) max = a3;

// if (b1 > max) max = b1;
// if (b2 > max) max = b2;
// if (b3 > max) max = b3;

// if (c1 > max) max = c1;
// if (c2 > max) max = c2;
// if (c3 > max) max = c3;
Console.WriteLine(max);

