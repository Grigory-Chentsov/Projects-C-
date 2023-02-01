/* Создание рандомного дробного числа */

// Random random = new Random();
// double number = Math.Round(random.Next(10) + random.NextDouble(), 3);
// Console.WriteLine(number);


/* Показать двумерный массив размером m×n заполненный целыми числами */

// Console.WriteLine("Введите m: ");
// int m = int.Parse(Console.ReadLine()!);
// Console.WriteLine("Введите n: ");
// int n = int.Parse(Console.ReadLine()!);

// int[,] table = new int[m, n];

// for (int i = 0; i < table.GetLength(0); i++)
// {
//     for (int j = 0; j < table.GetLength(1); j++)
//     {
//         table[i, j] = new Random().Next(0, 10);
//         Console.Write($" {table[i, j]}");
//     }
//     Console.WriteLine();    
// }



/* В двумерном массиве n×k заменить четные элементы на противоположные */

// Console.Write("Введите кол-во строк: ");
// int n = int.Parse(Console.ReadLine()!);
// Console.Write("Введите кол-во столбцов: ");
// int k = int.Parse(Console.ReadLine()!);

// double[,] table = new double[n, k];

// void PrintTableChange(double[,] table)
// {
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             Console.Write($"{table[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();

//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             if (table[i, j] % 2 == 0 && table[i, j] != 0)
//             {
//                 table[i, j] = table[i, j] * -1;
//                 Console.Write($"{table[i, j]} ");
//             }
//             else
//                 Console.Write($"{table[i, j]} ");
//         }

//         Console.WriteLine();
//     }
// }

// double[,] CreateTable(double[,] table)
// {
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             table[i, j] = new Random().Next(0, 10);
//         }
//     }
//     return table;
// }
// CreateTable(table);
// PrintTableChange(table);


/* В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет */

Console.Write("Введите количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива: ");
int columns = int.Parse(Console.ReadLine()!);
Console.Write("Введите число для поиска в массиве: ");
int number = int.Parse(Console.ReadLine()!);

int[,] table = new int[rows, columns];

int[,] FillArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(1, 10);
        }
    }
    return table;
}

void PrintTable(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i, j]} ");
        }
        Console.WriteLine();
    }
}

string SearchElement(int[,] table, int number)
{
    int row = 0;
    int column = 0;
    string newtext = $"Число {number} в массиве находится";
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (table[i, j] == number)
            {
                row = i + 1;
                column = j + 1;
                newtext = newtext + $"на {row} строке в {column} столбце.";
            }
        }
    }    
    if (row == 0 && column == 0)
        newtext = $"Число {number} в массиве не найдено.";
    
    return newtext;
}



FillArray(table);
PrintTable(table);
Console.WriteLine();
string answer = SearchElement(table, number);
Console.WriteLine(answer);


