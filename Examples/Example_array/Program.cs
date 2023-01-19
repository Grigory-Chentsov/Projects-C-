// Создание и использование массива

// int Max(int arg1, int arg2, int arg3)   // int-тип данных в функции, Max-имя функции, ()- агрументы функции
// {
//     int result = arg1;                  // тело функции , что она выполняет
//     if (arg2 > result) result = arg2;
//     if (arg3 > result) result = arg3;
//     return result;                      // возврат результата действия функции
// }

// int[] array = { 14, 92, 34, 84, 54, 86, 73, 68, 93, 54 };
// array[0] = 12;   // изменение значения по индексу

// int max = Max(
//     Max(array[0], array[1], array[2]),
//     Max(array[3], array[4], array[5]),
//     Max(array[6], array[7], array[8])
//     );

// int len = array.Length;
// int find = 54;
// int index = 0;

// while (index < len)
// {
//     if (array[index] == find)
//     {
//         Console.WriteLine("54 под индексом " + index);
//         break;  // оператор прекращения действий при выполнении условия
//     }
//     index++;
// }


//Console.WriteLine(max);


// Разбор синтаксиса при работе

void FillArray(int[] collection)    // создаём метод наполнения нашего массива, аргумент коллекция
{
    int len = collection.Length;    // узнаём длинну массива
    int index = 0;  // переменная для счета итераций
    while (index < len)    // запускаем цикл
    {
        collection[index] = new Random().Next(1, 10); // рандомно берем новое число и ставим по индексу
        index++;
    }
}

void PrintArray(int[] col) // метод void в C# ничего не возвращает
{                          // этот метод распечатает наш массив
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.Write(col[position] + ", ");
        position++;
    }
}

int FindNum(int[] collect, int find)
{
    int len = collect.Length;
    int count = 0;
    int pos = 0;  // -1 в значенние будет означать что искомого элемента нет в массиве
    while (count < len)
    {
        if (collect[count] == find)
        {
            pos = count;
            break;
        }
        count++;
    }
    return pos; // этот метод поиска числа в массиве будет возвращать индекс числа
}




int[] array = new int[10];  // создай новый массив в котором будет 10 элементов(по умолчанию 0) 

FillArray(array);
PrintArray(array);
int position = FindNum(array, 3);
Console.WriteLine();
if (position == 0)
{
    Console.WriteLine("Не найдено в массиве.");
}
else
    Console.WriteLine(position);